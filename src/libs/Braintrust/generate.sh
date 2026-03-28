#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://raw.githubusercontent.com/braintrustdata/braintrust-openapi/main/openapi/spec.json

# Remove /v1/proxy/{path+} endpoint — generates invalid C# identifiers
jq 'del(.paths["/v1/proxy/{path+}"])' openapi.yaml > openapi_fixed.yaml && mv openapi_fixed.yaml openapi.yaml

autosdk generate openapi.yaml \
  --namespace Braintrust \
  --clientClassName BraintrustClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations

# Fix namespace in JsonSerializerContextTypes (AutoSDK generates 'System' instead of 'Braintrust')
sed -i '' 's/namespace System/namespace Braintrust/' Generated/System.JsonSerializerContextTypes.g.cs
