#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated

openapi_url="https://raw.githubusercontent.com/dust-tt/dust/main/front-api/public/swagger.json"
openapi_tmp="$(mktemp)"
trap 'rm -f "$openapi_tmp"' EXIT

fetch_spec -fLSo "$openapi_tmp" "$openapi_url"

# Add top-level security array and strip blank descriptions that generate empty XML docs.
jq '
  def strip_empty_descriptions:
    walk(
      if type == "object"
        and (.description? | type) == "string"
        and (.description | test("^\\s*$"))
      then del(.description)
      else .
      end
    );

  strip_empty_descriptions | .security = [{"BearerAuth": []}]
' "$openapi_tmp" > openapi.yaml

autosdk generate openapi.yaml \
  --namespace Dust \
  --clientClassName DustClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
