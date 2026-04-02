
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// API specification for the backend data server. The API is hosted globally at<br/>
    /// https://api.braintrust.dev or in your own environment.<br/>
    /// You can access the OpenAPI spec for this API at https://github.com/braintrustdata/braintrust-openapi.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class BraintrustClient : global::Braintrust.IBraintrustClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.braintrust.dev";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Braintrust.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Braintrust.JsonConverters.ViewTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.AclObjectTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.AclObjectTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.AclListOrgObjectTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.AclListOrgObjectTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.AclListPermissionJsonConverter(),
                    new global::Braintrust.JsonConverters.AclListPermissionNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.AclListRestrictObjectTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.AclListRestrictObjectTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectScoreTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectScoreTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.EnvVarObjectTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.EnvVarObjectTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionTypeEnumJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionTypeEnumNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.NullableSavedFunctionIdFunctionTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.NullableSavedFunctionIdFunctionTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.NullableSavedFunctionIdGlobalTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.NullableSavedFunctionIdGlobalTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant1JsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant1NullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant2JsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant2NullableJsonConverter(),
                    new global::Braintrust.JsonConverters.SpanTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.SpanTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ObjectReferenceNullishObjectTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ObjectReferenceNullishObjectTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.SavedFunctionIdFunctionTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.SavedFunctionIdFunctionTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.SavedFunctionIdGlobalTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.SavedFunctionIdGlobalTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectLogsEventLogIdJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectLogsEventLogIdNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FeedbackResponseSchemaStatusJsonConverter(),
                    new global::Braintrust.JsonConverters.FeedbackResponseSchemaStatusNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FeedbackProjectLogsItemSourceJsonConverter(),
                    new global::Braintrust.JsonConverters.FeedbackProjectLogsItemSourceNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FeedbackExperimentItemSourceJsonConverter(),
                    new global::Braintrust.JsonConverters.FeedbackExperimentItemSourceNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FeedbackDatasetItemSourceJsonConverter(),
                    new global::Braintrust.JsonConverters.FeedbackDatasetItemSourceNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartTextTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartTextTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartTextCacheControlTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartTextCacheControlTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleCacheControlTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleCacheControlTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailAutoJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailAutoNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailLowJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailLowNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailHighJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailHighNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartFileWithTitleTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartFileWithTitleTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageParamSystemRoleJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageParamSystemRoleNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageParamUserRoleJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageParamUserRoleNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageParamAssistantRoleJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageParamAssistantRoleNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageParamToolRoleJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageParamToolRoleNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageParamFunctionRoleJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageParamFunctionRoleNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageParamDeveloperRoleJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageParamDeveloperRoleNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageParamFallbackRoleJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageParamFallbackRoleNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptBlockDataNullishChatTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptBlockDataNullishChatTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptBlockDataNullishCompletionTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptBlockDataNullishCompletionTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ResponseFormatNullishJsonObjectTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ResponseFormatNullishJsonObjectTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ResponseFormatNullishJsonSchemaTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ResponseFormatNullishJsonSchemaTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ResponseFormatNullishTextTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ResponseFormatNullishTextTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceAutoJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceAutoNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceNoneJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceNoneNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceRequiredJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceRequiredNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceFunctionTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceFunctionTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallAutoJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallAutoNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallNoneJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallNoneNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsReasoningEffortJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsReasoningEffortNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsVerbosityJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsVerbosityNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptParserNullishTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptParserNullishTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataNullishToolFunctionVariant2FunctionTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataNullishToolFunctionVariant2FunctionTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataNullishToolFunctionVariant2GlobalTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataNullishToolFunctionVariant2GlobalTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataNullishTemplateFormatJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataNullishTemplateFormatNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionTypeEnumNullishJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionTypeEnumNullishNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptLogIdJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptLogIdNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PermissionJsonConverter(),
                    new global::Braintrust.JsonConverters.PermissionNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.RetentionObjectTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.RetentionObjectTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2FunctionTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2FunctionTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2GlobalTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2GlobalTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.SpanScopeTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.SpanScopeTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.TraceScopeTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.TraceScopeTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.GroupScopeTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.GroupScopeTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant1TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant1TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant2TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant2TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant3TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant3TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicAutomationConfigEventTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicAutomationConfigEventTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicAutomationConfigFacetFunctionVariant2FunctionTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicAutomationConfigFacetFunctionVariant2FunctionTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicAutomationConfigFacetFunctionVariant2GlobalTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicAutomationConfigFacetFunctionVariant2GlobalTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1EventTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1EventTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1ActionVariant1TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1ActionVariant1TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1ActionVariant2TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1ActionVariant2TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2EventTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2EventTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant1TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant1TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant2TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2FormatJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2FormatNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant3EventTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant3EventTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4EventTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4EventTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4ActionVariant1TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4ActionVariant1TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4ActionVariant2TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4ActionVariant2TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1EventTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1EventTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant1TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant1TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant2TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant2TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2EventTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2EventTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2FormatJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2FormatNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant3EventTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant3EventTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4EventTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4EventTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant1TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant1TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant2TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant2TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1EventTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1EventTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant1TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant1TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant2TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant2TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2EventTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2EventTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2FormatJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2FormatNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant3EventTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant3EventTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4EventTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4EventTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant1TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant1TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant2TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant2TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2FunctionTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2FunctionTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2GlobalTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2GlobalTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.EvalStatusPageThemeJsonConverter(),
                    new global::Braintrust.JsonConverters.EvalStatusPageThemeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.EvalStatusPageConfigSortOrderJsonConverter(),
                    new global::Braintrust.JsonConverters.EvalStatusPageConfigSortOrderNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CodeBundleRuntimeContextRuntimeJsonConverter(),
                    new global::Braintrust.JsonConverters.CodeBundleRuntimeContextRuntimeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CodeBundleLocationExperimentTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CodeBundleLocationExperimentTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionVariant1TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionVariant1TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionScorerTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionScorerTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CodeBundleLocationFunctionTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CodeBundleLocationFunctionTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CodeBundleLocationVariant3TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CodeBundleLocationVariant3TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant1ProviderJsonConverter(),
                    new global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant1ProviderNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant2ProviderJsonConverter(),
                    new global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant2ProviderNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptBlockDataChatTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptBlockDataChatTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptBlockDataCompletionTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptBlockDataCompletionTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeVariant1TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeVariant1TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeVariant2TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeVariant2TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeVariant3TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeVariant3TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeVariant4TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeVariant4TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeVariant5TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeVariant5TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeVariant6TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeVariant6TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeVariant7TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeVariant7TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeVariant8TypeJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeVariant8TypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphEdgePurposeJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphEdgePurposeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphDataTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphDataTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FacetDataTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.FacetDataTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicMapDataTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicMapDataTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.BatchedFacetDataTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.BatchedFacetDataTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataPromptTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataPromptTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataCodeTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataCodeTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataCodeDataTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataCodeDataTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataCodeDataType2JsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataCodeDataType2NullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataCodeDataRuntimeContextRuntimeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataCodeDataRuntimeContextRuntimeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataRemoteEvalTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataRemoteEvalTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataGlobalTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataGlobalTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataParametersTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataParametersTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataParametersSchemaTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataParametersSchemaTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionLogIdJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionLogIdNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishPromptTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishPromptTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishCodeTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishCodeTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataType2JsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataType2NullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataRuntimeContextRuntimeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataRuntimeContextRuntimeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishRemoteEvalTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishRemoteEvalTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishGlobalTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishGlobalTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishParametersTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishParametersTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishParametersSchemaTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishParametersSchemaTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.InvokeParentSpanParentStructObjectTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.InvokeParentSpanParentStructObjectTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.StreamingModeJsonConverter(),
                    new global::Braintrust.JsonConverters.StreamingModeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsViewTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsViewTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsSpanTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsSpanTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsExcludedMeasureTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsExcludedMeasureTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsYMetricTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsYMetricTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsXAxisTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsXAxisTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsSymbolGroupingTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsSymbolGroupingTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsQueryShapeJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsQueryShapeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewViewTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewViewTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateViewViewTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.CreateViewViewTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchViewViewTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchViewViewTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.ImageRenderingModeJsonConverter(),
                    new global::Braintrust.JsonConverters.ImageRenderingModeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchOrganizationMembersOutputStatusJsonConverter(),
                    new global::Braintrust.JsonConverters.PatchOrganizationMembersOutputStatusNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.EnvVarObjectType2JsonConverter(),
                    new global::Braintrust.JsonConverters.EnvVarObjectType2NullableJsonConverter(),
                    new global::Braintrust.JsonConverters.EnvVarSecretCategoryJsonConverter(),
                    new global::Braintrust.JsonConverters.EnvVarSecretCategoryNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataToolFunctionVariant2FunctionTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataToolFunctionVariant2FunctionTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataToolFunctionVariant2GlobalTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataToolFunctionVariant2GlobalTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataTemplateFormatJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataTemplateFormatNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionIdInlineCodeInlineContextRuntimeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionIdInlineCodeInlineContextRuntimeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.GitMetadataSettingsCollectJsonConverter(),
                    new global::Braintrust.JsonConverters.GitMetadataSettingsCollectNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.GitMetadataSettingsFieldJsonConverter(),
                    new global::Braintrust.JsonConverters.GitMetadataSettingsFieldNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PostEnvVarRequestObjectTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PostEnvVarRequestObjectTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.PutEnvVarRequestObjectTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.PutEnvVarRequestObjectTypeNullableJsonConverter(),
                    new global::Braintrust.JsonConverters.IdsJsonConverter(),
                    new global::Braintrust.JsonConverters.UserGivenNameJsonConverter(),
                    new global::Braintrust.JsonConverters.UserFamilyNameJsonConverter(),
                    new global::Braintrust.JsonConverters.UserEmailJsonConverter(),
                    new global::Braintrust.JsonConverters.AISecretTypeJsonConverter(),
                    new global::Braintrust.JsonConverters.NullableSavedFunctionIdJsonConverter(),
                    new global::Braintrust.JsonConverters.SavedFunctionIdJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionContentPartJsonConverter(),
                    new global::Braintrust.JsonConverters.ChatCompletionMessageParamJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptBlockDataNullishJsonConverter(),
                    new global::Braintrust.JsonConverters.ResponseFormatNullishJsonConverter(),
                    new global::Braintrust.JsonConverters.ModelParamsJsonConverter(),
                    new global::Braintrust.JsonConverters.TopicAutomationDataScopeJsonConverter(),
                    new global::Braintrust.JsonConverters.ProjectScoreCategoriesJsonConverter(),
                    new global::Braintrust.JsonConverters.PromptBlockDataJsonConverter(),
                    new global::Braintrust.JsonConverters.GraphNodeJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionDataNullishJsonConverter(),
                    new global::Braintrust.JsonConverters.InvokeParentJsonConverter(),
                    new global::Braintrust.JsonConverters.ViewOptionsJsonConverter(),
                    new global::Braintrust.JsonConverters.FunctionIdJsonConverter(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant1?, global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant2?, object>(),
                    new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.ProjectSettings, object>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPart>>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>, object>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, object?>, string>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallFunction>(),
                    new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>?>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>(),
                    new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>(),
                    new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>?>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>(),
                    new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::Braintrust.TopicAutomationConfigBackfillTimeRange, object>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>(),
                    new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2>(),
                    new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>(),
                    new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant4ActionVariant2>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>(),
                    new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2>(),
                    new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>(),
                    new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant4ActionVariant2>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig, object>(),
                    new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2>(),
                    new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3>(),
                    new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant4ActionVariant2>(),
                    new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.CodeBundleLocationExperiment, global::Braintrust.CodeBundleLocationFunction, global::Braintrust.CodeBundleLocationVariant3>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer>(),
                    new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1, global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2>(),
                    new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.NullableSavedFunctionId?, object>(),
                    new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.NullableSavedFunctionId?, object>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataCodeData2>(),
                    new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>(),
                    new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.TopicMapData, object>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataNullishCodeData2>(),
                    new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>(),
                    new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.TopicMapData, object>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter, object>(),
                    new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>(),
                    new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.RunEvalDataDatasetId, global::Braintrust.RunEvalDataProjectDatasetName, global::Braintrust.RunEvalDataDatasetRows>(),
                    new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionId?, object>(),
                    new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.InvokeParent?, object>(),
                    new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.RepoInfo, object>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>(),
                    new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.ProjectScoreType?, object>(),
                    new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>(),
                    new global::Braintrust.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AclsClient Acls => new AclsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AiSecretsClient AiSecrets => new AiSecretsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ApiKeysClient ApiKeys => new ApiKeysClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CorsClient Cors => new CorsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CrossObjectClient CrossObject => new CrossObjectClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EnvVarsClient EnvVars => new EnvVarsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentsClient Environments => new EnvironmentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvalStatusPagesClient EvalStatusPages => new EvalStatusPagesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvalsClient Evals => new EvalsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExperimentsClient Experiments => new ExperimentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FunctionsClient Functions => new FunctionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GroupsClient Groups => new GroupsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LogsClient Logs => new LogsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public McpServersClient McpServers => new McpServersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations => new OrganizationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OtherClient Other => new OtherClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectAutomationsClient ProjectAutomations => new ProjectAutomationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectScoresClient ProjectScores => new ProjectScoresClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectTagsClient ProjectTags => new ProjectTagsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProxyClient Proxy => new ProxyClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RolesClient Roles => new RolesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ServiceTokensClient ServiceTokens => new ServiceTokensClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SpanIframesClient SpanIframes => new SpanIframesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ViewsClient Views => new ViewsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the BraintrustClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public BraintrustClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Braintrust.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Braintrust.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}