#!/bin/sh

curl -A "PolytoriaLauncher/4.13" "https://api.polytoria.com/v1/launcher/updates?os=windows&release=stable" | \
jq -M >windows-updates.json

rm -rf ./Downloads/
jq -r 'to_entries.[] | (.key? + "|" + .value.Download?)' windows-updates.json | \
awk -F'|' '{ system("wget --directory-prefix Downloads/\"" $1 "\" -U PolytoriaLauncher/4.13 --no-clobber \"" $2 "\"") }'

find './Downloads/*' -maxdepth 0 -printf "%f\n" | xargs -P3 -I{} 7z x -y "Downloads/{}/*" -o"Unzipped/{}/*"


# Extract downloader script.
7z e -i!'resources/app.asar' './Unzipped/Installer/*/$PLUGINSDIR/app-64.7z' -aoa -o'./Unzipped/Installer'
npm install -g asar webcrack
asar e './Unzipped/Installer/app.asar' './Unpacked/Installer'
webcrack './Unpacked/Installer/src/main/index.js' >'./Unpacked/Installer/src/main/index-deobfuscated.js'

# Use AssetRipper to extract source code.
wget https://github.com/Windows81/AssetRipper-CLI/releases/download/v20260222T003813Z/AssetRipper.CLI.Free.exe --no-clobbers
rip_assets() {
    rm -rf "./Unpacked/$1"
    ./AssetRipper.CLI.Free.exe -InputPath "./Unzipped/$1" -OutputPath "./Unpacked/$1"
}
rip_assets 'Creator'
rip_assets 'Client'