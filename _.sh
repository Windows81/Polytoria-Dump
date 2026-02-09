curl -A "PolytoriaLauncher/4.13" "https://api.polytoria.com/v1/launcher/updates?os=windows&release=stable" | jq -M >windows-updates.json

jq -r 'to_entries.[] | (.key? + "|" + .value.Download?)' windows-updates.json | awk -F'|' '{ system("wget --directory-prefix Downloads/\"" $1 "\" -U PolytoriaLauncher/4.13 --no-clobber \"" $2 "\"") }'

ls Downloads | xargs -P3 -I{} 7z x -y "Downloads/{}/*" -o"Unzipped/{}/*"