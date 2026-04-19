#!/bin/sh

# PT_AUTH cookie value of an account to generate cookies with. Should be
if [ -z "$PT_AUTH" ]; then
    echo "PT_AUTH environment variable is not set!"
    echo "Please set it to the value of your PT_AUTH cookie and run the again!"
    exit 1
fi

cookie_jar_path="$(mktemp -d)"

# First request is to fetch XSRF-TOKEN and SESSION cookies.
# The use of edit endpoint is just a personal preference
curl -A "PolytoriaLauncher/4.13" -X "POST" "https://polytoria.com/api/places/edit" --cookie-jar "$cookie_jar_path/cookies.txt" &> /dev/null

xsrf="$(grep -E -o 'XSRF-TOKEN\s([a-zA-Z0-9!-\)_\-\.]+)' "$cookie_jar_path/cookies.txt" | grep -E -o '([a-zA-Z0-9!-\)_\-\.]+)' | tail -n1)"
session="$(grep -E -o 'SESSION\s([a-zA-Z0-9!-\)_\-\.]+)' "$cookie_jar_path/cookies.txt" | grep -E -o '([a-zA-Z0-9!-\)_\-\.]+)' | tail -n1)"
beta_token="$(curl -s -A "PolytoriaLauncher/4.13" -b "PT_AUTH=$PT_AUTH" -b "SESSION=$session" -H "x-xsrf-token: $xsrf" -H "content-type: application/json" -X "POST" "https://polytoria.com/api/places/edit" -d "{\"placeId\": null, \"isBeta\": true}" | jq -r .token)"

if [ "$beta_token" = "null" ]; then
    echo "Failed fetching token!"
    echo "You are entirely on your own. Good luck!"
    exit 1
fi

rm -r "$cookie_jar_path"

download_stable_update_json() {
    curl -A "PolytoriaLauncher/4.13" "https://api.polytoria.com/v1/launcher/updates?os=$1&release=stable" | \
    jq -M >"updates-$1-stable.json"
}

download_stable_update_json "windows"
download_stable_update_json "macos"
download_stable_update_json "linux"


download_beta_update_json() {
    curl -A "PolytoriaLauncher/4.13" "https://api.polytoria.com/v1/launcher/updates?os=$1&release=beta" -H "authorization: $beta_token" | \
    jq -M >"updates-$1-beta.json"
}

download_beta_update_json "windows"
download_beta_update_json "macos"
download_beta_update_json "linux"


# NOTE:
# The "${1^}" syntax denotes "use $1 and make the first letter uppercase".
download_stable_releases() {
    jq -r 'to_entries.[] | (.key? + "|" + .value.Download?)' updates-$1-stable.json | \
    awk -v os="${1^}" -F'|' '{ system("wget --no-clobber --directory-prefix Downloads/\"" os $1 "\" -U PolytoriaLauncher/4.13 \"" $2 "\"") }'
}

download_stable_releases "windows"
download_stable_releases "macos"
download_stable_releases "linux"


download_beta_releases() {
    jq -r 'to_entries.[] | (.key? + "|" + .value.Download?)' updates-$1-beta.json | \
    awk -v os="${1^}" -F'|' '{ system("wget --no-clobber --directory-prefix Downloads/\"" os $1 "Beta\" -U PolytoriaLauncher/4.13 \"" $2 "\"") }'
}

download_beta_releases "windows"
download_beta_releases "macos"
download_beta_releases "linux"


jq -r 'to_entries.[] | (.key? + "|" + .value.Download?)' *-updates-beta.json | \
awk -F'|' '{ system("wget --no-clobber --directory-prefix Downloads/\"" $1 "\" -U PolytoriaLauncher/4.13 \"" $2 "\"") }'

find ./Downloads/* -maxdepth 0 -printf "%f\n" | xargs -P3 -I{} 7z x -y "Downloads/{}/*" -o"Unzipped/{}/*"


# Use AssetRipper and Cpp2IL to extract source code.
wget --no-clobber https://github.com/Windows81/AssetRipper-CLI/releases/download/v20260222T003813Z/AssetRipper.CLI.Free.exe
wget --no-clobber https://github.com/SamboyCoding/Cpp2IL/releases/download/2022.1.0-pre-release.21/Cpp2IL-2022.1.0-pre-release.21-Windows.exe

rip_assets_unity() {
    rm -rf "./Unpacked/$1"
    ./AssetRipper.CLI.Free.exe -InputPath "./Unzipped/$1" -OutputPath "./Unpacked/$1"
    ./Cpp2IL-2022.1.0-pre-release.21-Windows.exe --output-as isil --game-path "./Unzipped/$1" --output-to "./Unpacked/$1/cpp2il_out"
    rm -rf "./Unpacked/$1/ExportedProject/Assets/Scripts"
    rm -rf "./Unpacked/$1/cpp2il_out/IsilDump/"UnityEngine.*
    rm -rf "./Unpacked/$1/cpp2il_out/IsilDump/"Unity.*
    rm -rf "./Unpacked/$1/cpp2il_out/IsilDump/"System.*
    rm -rf "./Unpacked/$1/cpp2il_out/IsilDump/mscorlib"
}
rip_assets_unity 'Creator'
rip_assets_unity 'Client'

# Extract downloader script.
7z e -i!'resources/app.asar' './Unzipped/Installer/*/$PLUGINSDIR/app-64.7z' -aoa -o'./Unzipped/Installer'
npm install -g asar webcrack
asar e './Unzipped/Installer/app.asar' './Unpacked/Installer'
webcrack './Unpacked/Installer/src/main/index.js' >'./Unpacked/Installer/src/main/index-deobfuscated.js'