#!/bin/sh

# TODO: make script automatically extract join token from `polytoria.com/api/places/join`.
beta_token="a88bc47e6e23960f8bf3d06928b3b8f9"

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