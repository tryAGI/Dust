dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://dust.tt/swagger.json

# Add top-level security array (spec defines BearerAuth scheme but has empty security array)
jq '.security = [{"BearerAuth": []}]' openapi.yaml > openapi.tmp && mv openapi.tmp openapi.yaml

autosdk generate openapi.yaml \
  --namespace Dust \
  --clientClassName DustClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
