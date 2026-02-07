mkdir download
curl -A "PolytoriaLauncher/4.13" "https://api.polytoria.com/v1/launcher/updates?os=windows&release=stable" | jq -M | tee windows-updates.json | jq 'to_entries.[] | .value.Download?' | xargs wget --directory-prefix download -U "PolytoriaLauncher/4.13" --no-clobber
