dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/braintrustdata/braintrust-openapi/main/openapi/spec.json

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

# Fix SYSLIB1031 type name collisions in JsonSerializerContext
# NullableSavedFunctionId types are registered both via JsonSerializerContextTypes properties
# and explicit [JsonSerializable] attributes, causing duplicate TypeInfoPropertyName collisions.
CONTEXT_FILE="Generated/Braintrust..JsonSerializerContext.g.cs"
sed -i '' 's/\[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionId))\]/[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionId), TypeInfoPropertyName = "NullableSavedFunctionId2")]/' "$CONTEXT_FILE"
sed -i '' 's/\[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionIdFunctionType))\]/[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionIdFunctionType), TypeInfoPropertyName = "NullableSavedFunctionIdFunctionType2")]/' "$CONTEXT_FILE"
sed -i '' 's/\[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionIdGlobalType))\]/[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionIdGlobalType), TypeInfoPropertyName = "NullableSavedFunctionIdGlobalType2")]/' "$CONTEXT_FILE"
sed -i '' 's/\[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.NullableSavedFunctionId?, object>))\]/[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.NullableSavedFunctionId?, object>), TypeInfoPropertyName = "AllOfNullableSavedFunctionIdObject")]/' "$CONTEXT_FILE"
