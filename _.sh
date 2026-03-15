#!/bin/sh

curl -A "PolytoriaLauncher/4.13" "https://api.polytoria.com/v1/launcher/updates?os=windows&release=stable" | \
jq -M >windows-updates.json

rm -rf ./Downloads/
jq -r 'to_entries.[] | (.key? + "|" + .value.Download?)' windows-updates.json | \
awk -F'|' '{ system("wget --no-clobber --directory-prefix Downloads/\"" $1 "\" -U PolytoriaLauncher/4.13 \"" $2 "\"") }'

find './Downloads/*' -maxdepth 0 -printf "%f\n" | xargs -P3 -I{} 7z x -y "Downloads/{}/*" -o"Unzipped/{}/*"

# Use AssetRipper and Cpp2IL to extract source code.
wget --no-clobber https://github.com/Windows81/AssetRipper-CLI/releases/download/v20260222T003813Z/AssetRipper.CLI.Free.exe
wget --no-clobber https://github.com/SamboyCoding/Cpp2IL/releases/download/2022.1.0-pre-release.21/Cpp2IL-2022.1.0-pre-release.21-Windows.exe

rip_assets() {
    rm -rf "./Unpacked/$1"
    ./AssetRipper.CLI.Free.exe -InputPath "./Unzipped/$1" -OutputPath "./Unpacked/$1"
    ./Cpp2IL-2022.1.0-pre-release.21-Windows.exe --output-as isil --game-path "./Unzipped/$1" --output-to "./Unpacked/$1/cpp2il_out"
    rm -rf "./Unpacked/$1/ExportedProject/Assets/Scripts"
    rm -rf "./Unpacked/$1/cpp2il_out/IsilDump/"UnityEngine.*
    rm -rf "./Unpacked/$1/cpp2il_out/IsilDump/"Unity.*
    rm -rf "./Unpacked/$1/cpp2il_out/IsilDump/"System.*
    rm -rf "./Unpacked/$1/cpp2il_out/IsilDump/mscorlib"
}
rip_assets 'Creator'
rip_assets 'Client'

# Extract downloader script.
7z e -i!'resources/app.asar' './Unzipped/Installer/*/$PLUGINSDIR/app-64.7z' -aoa -o'./Unzipped/Installer'
npm install -g asar webcrack
asar e './Unzipped/Installer/app.asar' './Unpacked/Installer'
webcrack './Unpacked/Installer/src/main/index.js' >'./Unpacked/Installer/src/main/index-deobfuscated.js'