
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Braintrust.JsonConverters.ViewTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.AclObjectTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.AclObjectTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.AclListOrgObjectTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.AclListOrgObjectTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.AclListPermissionJsonConverter),

            typeof(global::Braintrust.JsonConverters.AclListPermissionNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.AclListRestrictObjectTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.AclListRestrictObjectTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectScoreTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectScoreTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.EnvVarObjectTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.EnvVarObjectTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionTypeEnumJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionTypeEnumNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.NullableSavedFunctionIdFunctionTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.NullableSavedFunctionIdFunctionTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.NullableSavedFunctionIdGlobalTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.NullableSavedFunctionIdGlobalTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant1JsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant1NullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant2JsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant2NullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.SpanTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.SpanTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ObjectReferenceNullishObjectTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ObjectReferenceNullishObjectTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.SavedFunctionIdFunctionTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.SavedFunctionIdFunctionTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.SavedFunctionIdGlobalTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.SavedFunctionIdGlobalTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectLogsEventLogIdJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectLogsEventLogIdNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FeedbackResponseSchemaStatusJsonConverter),

            typeof(global::Braintrust.JsonConverters.FeedbackResponseSchemaStatusNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FeedbackProjectLogsItemSourceJsonConverter),

            typeof(global::Braintrust.JsonConverters.FeedbackProjectLogsItemSourceNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FeedbackExperimentItemSourceJsonConverter),

            typeof(global::Braintrust.JsonConverters.FeedbackExperimentItemSourceNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FeedbackDatasetItemSourceJsonConverter),

            typeof(global::Braintrust.JsonConverters.FeedbackDatasetItemSourceNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartTextTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartTextTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartTextCacheControlTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartTextCacheControlTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleCacheControlTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleCacheControlTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailAutoJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailAutoNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailLowJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailLowNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailHighJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailHighNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartFileWithTitleTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartFileWithTitleTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageParamSystemRoleJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageParamSystemRoleNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageParamUserRoleJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageParamUserRoleNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageParamAssistantRoleJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageParamAssistantRoleNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageParamToolRoleJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageParamToolRoleNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageParamFunctionRoleJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageParamFunctionRoleNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageParamDeveloperRoleJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageParamDeveloperRoleNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageParamFallbackRoleJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageParamFallbackRoleNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptBlockDataNullishChatTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptBlockDataNullishChatTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptBlockDataNullishCompletionTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptBlockDataNullishCompletionTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ResponseFormatNullishJsonObjectTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ResponseFormatNullishJsonObjectTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ResponseFormatNullishJsonSchemaTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ResponseFormatNullishJsonSchemaTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ResponseFormatNullishTextTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ResponseFormatNullishTextTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceAutoJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceAutoNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceNoneJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceNoneNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceRequiredJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceRequiredNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceFunctionTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceFunctionTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallAutoJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallAutoNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallNoneJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallNoneNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsReasoningEffortJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsReasoningEffortNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsVerbosityJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsVerbosityNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptParserNullishTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptParserNullishTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataNullishToolFunctionVariant2FunctionTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataNullishToolFunctionVariant2FunctionTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataNullishToolFunctionVariant2GlobalTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataNullishToolFunctionVariant2GlobalTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataNullishTemplateFormatJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataNullishTemplateFormatNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionTypeEnumNullishJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionTypeEnumNullishNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptLogIdJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptLogIdNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PermissionJsonConverter),

            typeof(global::Braintrust.JsonConverters.PermissionNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.RetentionObjectTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.RetentionObjectTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2FunctionTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2FunctionTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2GlobalTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2GlobalTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.SpanScopeTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.SpanScopeTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TraceScopeTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.TraceScopeTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GroupScopeTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.GroupScopeTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant2TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant3TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant3TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationConfigEventTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationConfigEventTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationConfigFacetFunctionVariant2FunctionTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationConfigFacetFunctionVariant2FunctionTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationConfigFacetFunctionVariant2GlobalTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationConfigFacetFunctionVariant2GlobalTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1EventTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1EventTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1ActionVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1ActionVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1ActionVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1ActionVariant2TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2EventTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2EventTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant2TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2FormatJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2FormatNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant3EventTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant3EventTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4EventTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4EventTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4ActionVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4ActionVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4ActionVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4ActionVariant2TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1EventTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1EventTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant2TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2EventTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2EventTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2FormatJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2FormatNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant3EventTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant3EventTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4EventTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4EventTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant2TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1EventTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1EventTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant2TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2EventTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2EventTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2FormatJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2FormatNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant3EventTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant3EventTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4EventTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4EventTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant2TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2FunctionTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2FunctionTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2GlobalTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2GlobalTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.EvalStatusPageThemeJsonConverter),

            typeof(global::Braintrust.JsonConverters.EvalStatusPageThemeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.EvalStatusPageConfigSortOrderJsonConverter),

            typeof(global::Braintrust.JsonConverters.EvalStatusPageConfigSortOrderNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleRuntimeContextRuntimeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleRuntimeContextRuntimeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionScorerTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionScorerTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationFunctionTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationFunctionTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationVariant3TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationVariant3TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant1ProviderJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant1ProviderNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant2ProviderJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant2ProviderNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptBlockDataChatTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptBlockDataChatTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptBlockDataCompletionTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptBlockDataCompletionTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeVariant2TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeVariant3TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeVariant3TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeVariant4TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeVariant4TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeVariant5TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeVariant5TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeVariant6TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeVariant6TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeVariant7TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeVariant7TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeVariant8TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeVariant8TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphEdgePurposeJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphEdgePurposeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphDataTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphDataTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FacetDataTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FacetDataTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapDataTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapDataTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.BatchedFacetDataTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.BatchedFacetDataTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataPromptTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataPromptTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataCodeTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataCodeTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataCodeDataTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataCodeDataTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataCodeDataType2JsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataCodeDataType2NullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataCodeDataRuntimeContextRuntimeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataCodeDataRuntimeContextRuntimeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataRemoteEvalTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataRemoteEvalTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataGlobalTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataGlobalTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataParametersTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataParametersTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataParametersSchemaTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataParametersSchemaTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionLogIdJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionLogIdNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishPromptTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishPromptTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishCodeTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishCodeTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishCodeDataTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishCodeDataTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishCodeDataType2JsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishCodeDataType2NullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishCodeDataRuntimeContextRuntimeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishCodeDataRuntimeContextRuntimeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishRemoteEvalTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishRemoteEvalTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishGlobalTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishGlobalTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishParametersTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishParametersTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishParametersSchemaTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishParametersSchemaTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.InvokeParentSpanParentStructObjectTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.InvokeParentSpanParentStructObjectTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.StreamingModeJsonConverter),

            typeof(global::Braintrust.JsonConverters.StreamingModeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsViewTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsViewTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsSpanTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsSpanTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsExcludedMeasureTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsExcludedMeasureTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsYMetricTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsYMetricTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsXAxisTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsXAxisTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsSymbolGroupingTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsSymbolGroupingTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsQueryShapeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsQueryShapeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewViewTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewViewTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateViewViewTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateViewViewTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchViewViewTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchViewViewTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ImageRenderingModeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ImageRenderingModeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchOrganizationMembersOutputStatusJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchOrganizationMembersOutputStatusNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.EnvVarObjectType2JsonConverter),

            typeof(global::Braintrust.JsonConverters.EnvVarObjectType2NullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.EnvVarSecretCategoryJsonConverter),

            typeof(global::Braintrust.JsonConverters.EnvVarSecretCategoryNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataToolFunctionVariant2FunctionTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataToolFunctionVariant2FunctionTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataToolFunctionVariant2GlobalTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataToolFunctionVariant2GlobalTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataTemplateFormatJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataTemplateFormatNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionIdInlineCodeInlineContextRuntimeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionIdInlineCodeInlineContextRuntimeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GitMetadataSettingsCollectJsonConverter),

            typeof(global::Braintrust.JsonConverters.GitMetadataSettingsCollectNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GitMetadataSettingsFieldJsonConverter),

            typeof(global::Braintrust.JsonConverters.GitMetadataSettingsFieldNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PostEnvVarRequestObjectTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PostEnvVarRequestObjectTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PutEnvVarRequestObjectTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PutEnvVarRequestObjectTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.IdsJsonConverter),

            typeof(global::Braintrust.JsonConverters.UserGivenNameJsonConverter),

            typeof(global::Braintrust.JsonConverters.UserFamilyNameJsonConverter),

            typeof(global::Braintrust.JsonConverters.UserEmailJsonConverter),

            typeof(global::Braintrust.JsonConverters.AISecretTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.NullableSavedFunctionIdJsonConverter),

            typeof(global::Braintrust.JsonConverters.SavedFunctionIdJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartJsonConverter),

            typeof(global::Braintrust.JsonConverters.ChatCompletionMessageParamJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptBlockDataNullishJsonConverter),

            typeof(global::Braintrust.JsonConverters.ResponseFormatNullishJsonConverter),

            typeof(global::Braintrust.JsonConverters.ModelParamsJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationDataScopeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectScoreCategoriesJsonConverter),

            typeof(global::Braintrust.JsonConverters.PromptBlockDataJsonConverter),

            typeof(global::Braintrust.JsonConverters.GraphNodeJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionDataNullishJsonConverter),

            typeof(global::Braintrust.JsonConverters.InvokeParentJsonConverter),

            typeof(global::Braintrust.JsonConverters.ViewOptionsJsonConverter),

            typeof(global::Braintrust.JsonConverters.FunctionIdJsonConverter),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant1?, global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant2?, object>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.ProjectSettings, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPart>>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, object?>, string>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallFunction>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>?>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>?>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::Braintrust.TopicAutomationConfigBackfillTimeRange, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant4ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant4ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig, object>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant4ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.CodeBundleLocationExperiment, global::Braintrust.CodeBundleLocationFunction, global::Braintrust.CodeBundleLocationVariant3>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1, global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.NullableSavedFunctionId?, object>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.NullableSavedFunctionId?, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataCodeData2>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.TopicMapData, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataNullishCodeData2>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.TopicMapData, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter, object>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.RunEvalDataDatasetId, global::Braintrust.RunEvalDataProjectDatasetName, global::Braintrust.RunEvalDataDatasetRows>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionId?, object>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.InvokeParent?, object>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.RepoInfo, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.ProjectScoreType?, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Braintrust.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Ids), TypeInfoPropertyName = "Ids2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewType), TypeInfoPropertyName = "ViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.UserGivenName), TypeInfoPropertyName = "UserGivenName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.UserFamilyName), TypeInfoPropertyName = "UserFamilyName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.UserEmail), TypeInfoPropertyName = "UserEmail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AclObjectType), TypeInfoPropertyName = "AclObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AclListOrgObjectType), TypeInfoPropertyName = "AclListOrgObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AclListPermission), TypeInfoPropertyName = "AclListPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AclListRestrictObjectType), TypeInfoPropertyName = "AclListRestrictObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreType), TypeInfoPropertyName = "ProjectScoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AISecretType), TypeInfoPropertyName = "AISecretType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EnvVarObjectType), TypeInfoPropertyName = "EnvVarObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionTypeEnum), TypeInfoPropertyName = "FunctionTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionId), TypeInfoPropertyName = "NullableSavedFunctionId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionIdFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionIdFunctionType), TypeInfoPropertyName = "NullableSavedFunctionIdFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionIdGlobal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionIdGlobalType), TypeInfoPropertyName = "NullableSavedFunctionIdGlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ProjectSettingsSpanFieldOrderItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectSettingsSpanFieldOrderItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant1?, global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant2?, object>), TypeInfoPropertyName = "AnyOfProjectSettingsSpanFieldOrderItemLayoutVariant1ProjectSettingsSpanFieldOrderItemLayoutVariant2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant1), TypeInfoPropertyName = "ProjectSettingsSpanFieldOrderItemLayoutVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant2), TypeInfoPropertyName = "ProjectSettingsSpanFieldOrderItemLayoutVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ProjectSettingsRemoteEvalSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectSettingsRemoteEvalSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Project))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.ProjectSettings, object>), TypeInfoPropertyName = "AllOfProjectSettingsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanType), TypeInfoPropertyName = "SpanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ObjectReferenceNullish))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ObjectReferenceNullishObjectType), TypeInfoPropertyName = "ObjectReferenceNullishObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertProjectLogsEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertProjectLogsEventMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertProjectLogsEventMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertProjectLogsEventContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.InsertProjectLogsEventArrayDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertProjectLogsEventArrayDeleteItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertProjectLogsEventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.InsertProjectLogsEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionId), TypeInfoPropertyName = "SavedFunctionId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdFunctionType), TypeInfoPropertyName = "SavedFunctionIdFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdGlobal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdGlobalType), TypeInfoPropertyName = "SavedFunctionIdGlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectLogsEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectLogsEventLogId), TypeInfoPropertyName = "ProjectLogsEventLogId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectLogsEventMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectLogsEventMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectLogsEventContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.ProjectLogsEventClassification>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ProjectLogsEventClassification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectLogsEventClassification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FetchProjectLogsEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ProjectLogsEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FetchEventsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackResponseSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackResponseSchemaStatus), TypeInfoPropertyName = "FeedbackResponseSchemaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackProjectLogsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackProjectLogsItemSource), TypeInfoPropertyName = "FeedbackProjectLogsItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackProjectLogsEventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.FeedbackProjectLogsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.RepoInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Experiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertExperimentEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertExperimentEventMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertExperimentEventMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertExperimentEventContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.InsertExperimentEventArrayDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertExperimentEventArrayDeleteItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertExperimentEventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.InsertExperimentEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ExperimentEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ExperimentEventMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ExperimentEventMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ExperimentEventContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.ExperimentEventClassification>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ExperimentEventClassification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ExperimentEventClassification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FetchExperimentEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ExperimentEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackExperimentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackExperimentItemSource), TypeInfoPropertyName = "FeedbackExperimentItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackExperimentEventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.FeedbackExperimentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ScoreSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.MetricSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SummarizeExperimentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Braintrust.ScoreSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Braintrust.MetricSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertDatasetEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertDatasetEventMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.InsertDatasetEventArrayDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertDatasetEventArrayDeleteItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertDatasetEventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.InsertDatasetEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.DatasetEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.DatasetEventMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.DatasetEventClassification>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.DatasetEventClassification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.DatasetEventClassification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FetchDatasetEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.DatasetEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackDatasetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackDatasetItemSource), TypeInfoPropertyName = "FeedbackDatasetItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackDatasetEventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.FeedbackDatasetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.DataSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SummarizeDatasetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextType), TypeInfoPropertyName = "ChatCompletionContentPartTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextCacheControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextCacheControlType), TypeInfoPropertyName = "ChatCompletionContentPartTextCacheControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextWithTitle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleType), TypeInfoPropertyName = "ChatCompletionContentPartTextWithTitleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType), TypeInfoPropertyName = "ChatCompletionContentPartTextWithTitleCacheControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?>), TypeInfoPropertyName = "AnyOfChatCompletionContentPartImageWithTitleImageUrlDetailAutoChatCompletionContentPartImageWithTitleImageUrlDetailLowChatCompletionContentPartImageWithTitleImageUrlDetailHigh2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto), TypeInfoPropertyName = "ChatCompletionContentPartImageWithTitleImageUrlDetailAuto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow), TypeInfoPropertyName = "ChatCompletionContentPartImageWithTitleImageUrlDetailLow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh), TypeInfoPropertyName = "ChatCompletionContentPartImageWithTitleImageUrlDetailHigh2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleType), TypeInfoPropertyName = "ChatCompletionContentPartImageWithTitleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartFileFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartFileWithTitle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleType), TypeInfoPropertyName = "ChatCompletionContentPartFileWithTitleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPart), TypeInfoPropertyName = "ChatCompletionContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageToolCallType), TypeInfoPropertyName = "ChatCompletionMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParam), TypeInfoPropertyName = "ChatCompletionMessageParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamSystem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>>), TypeInfoPropertyName = "AnyOfStringIListChatCompletionContentPartText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamSystemRole), TypeInfoPropertyName = "ChatCompletionMessageParamSystemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPart>>), TypeInfoPropertyName = "AnyOfStringIListChatCompletionContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamUserRole), TypeInfoPropertyName = "ChatCompletionMessageParamUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamAssistantRole), TypeInfoPropertyName = "ChatCompletionMessageParamAssistantRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>, object>), TypeInfoPropertyName = "AnyOfStringIListChatCompletionContentPartTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamAssistantFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageReasoning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamToolRole), TypeInfoPropertyName = "ChatCompletionMessageParamToolRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamFunctionRole), TypeInfoPropertyName = "ChatCompletionMessageParamFunctionRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamDeveloper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamDeveloperRole), TypeInfoPropertyName = "ChatCompletionMessageParamDeveloperRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamFallback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamFallbackRole), TypeInfoPropertyName = "ChatCompletionMessageParamFallbackRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptBlockDataNullish), TypeInfoPropertyName = "PromptBlockDataNullish2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptBlockDataNullishChat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptBlockDataNullishChatType), TypeInfoPropertyName = "PromptBlockDataNullishChatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptBlockDataNullishCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptBlockDataNullishCompletionType), TypeInfoPropertyName = "PromptBlockDataNullishCompletionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::System.Collections.Generic.Dictionary<string, object?>, string>), TypeInfoPropertyName = "AnyOfDictionaryStringObjectString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ResponseFormatNullish), TypeInfoPropertyName = "ResponseFormatNullish2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ResponseFormatNullishJsonObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ResponseFormatNullishJsonObjectType), TypeInfoPropertyName = "ResponseFormatNullishJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ResponseFormatNullishJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ResponseFormatNullishJsonSchemaType), TypeInfoPropertyName = "ResponseFormatNullishJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ResponseFormatNullishText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ResponseFormatNullishTextType), TypeInfoPropertyName = "ResponseFormatNullishTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParams), TypeInfoPropertyName = "ModelParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction>), TypeInfoPropertyName = "AnyOfModelParamsOpenAIModelParamsToolChoiceAutoModelParamsOpenAIModelParamsToolChoiceNoneModelParamsOpenAIModelParamsToolChoiceRequiredModelParamsOpenAIModelParamsToolChoiceFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsToolChoiceAuto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsToolChoiceNone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsToolChoiceRequired2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionType), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsToolChoiceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallFunction>), TypeInfoPropertyName = "AnyOfModelParamsOpenAIModelParamsFunctionCallAutoModelParamsOpenAIModelParamsFunctionCallNoneModelParamsOpenAIModelParamsFunctionCallFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsFunctionCallAuto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsFunctionCallNone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsReasoningEffort), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsVerbosity), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsAnthropicModelParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsGoogleModelParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsWindowAIModelParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsJsCompletionParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptOptionsNullish))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptParserNullish))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptParserNullishType), TypeInfoPropertyName = "PromptParserNullishType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>), TypeInfoPropertyName = "DictionaryStringDouble_System_Collections_Generic_Dictionary_string_double")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullish))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>?>), TypeInfoPropertyName = "AllOfSavedFunctionIdAnyOfPromptDataNullishToolFunctionVariant2FunctionPromptDataNullishToolFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>), TypeInfoPropertyName = "AnyOfPromptDataNullishToolFunctionVariant2FunctionPromptDataNullishToolFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2FunctionType), TypeInfoPropertyName = "PromptDataNullishToolFunctionVariant2FunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2Global))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2GlobalType), TypeInfoPropertyName = "PromptDataNullishToolFunctionVariant2GlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishTemplateFormat), TypeInfoPropertyName = "PromptDataNullishTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>), TypeInfoPropertyName = "OneOfPromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsPromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType), TypeInfoPropertyName = "PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType), TypeInfoPropertyName = "PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishOrigin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionTypeEnumNullish), TypeInfoPropertyName = "FunctionTypeEnumNullish2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Prompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptLogId), TypeInfoPropertyName = "PromptLogId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreatePrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Permission), TypeInfoPropertyName = "Permission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.RoleMemberPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.RoleMemberPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.CreateRoleMemberPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateRoleMemberPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.PatchRoleAddMemberPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchRoleAddMemberPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.PatchRoleRemoveMemberPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchRoleRemoveMemberPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Group))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Acl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AclItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AclBatchUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.Acl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AclBatchUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.AclItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.RetentionObjectType), TypeInfoPropertyName = "RetentionObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapFunctionAutomation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>?>), TypeInfoPropertyName = "AllOfSavedFunctionIdAnyOfTopicMapFunctionAutomationFunctionVariant2FunctionTopicMapFunctionAutomationFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>), TypeInfoPropertyName = "AnyOfTopicMapFunctionAutomationFunctionVariant2FunctionTopicMapFunctionAutomationFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2FunctionType), TypeInfoPropertyName = "TopicMapFunctionAutomationFunctionVariant2FunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2GlobalType), TypeInfoPropertyName = "TopicMapFunctionAutomationFunctionVariant2GlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanScopeType), TypeInfoPropertyName = "SpanScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TraceScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TraceScopeType), TypeInfoPropertyName = "TraceScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GroupScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GroupScopeType), TypeInfoPropertyName = "GroupScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScope), TypeInfoPropertyName = "TopicAutomationDataScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScopeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScopeVariant1Type), TypeInfoPropertyName = "TopicAutomationDataScopeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScopeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScopeVariant2Type), TypeInfoPropertyName = "TopicAutomationDataScopeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScopeVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScopeVariant3Type), TypeInfoPropertyName = "TopicAutomationDataScopeVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationConfigEventType), TypeInfoPropertyName = "TopicAutomationConfigEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>), TypeInfoPropertyName = "AllOfSavedFunctionIdAnyOfTopicAutomationConfigFacetFunctionVariant2FunctionTopicAutomationConfigFacetFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>), TypeInfoPropertyName = "AnyOfTopicAutomationConfigFacetFunctionVariant2FunctionTopicAutomationConfigFacetFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationConfigFacetFunctionVariant2FunctionType), TypeInfoPropertyName = "TopicAutomationConfigFacetFunctionVariant2FunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalType), TypeInfoPropertyName = "TopicAutomationConfigFacetFunctionVariant2GlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.TopicMapFunctionAutomation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>), TypeInfoPropertyName = "AnyOfSpanScopeTraceScopeGroupScopeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::Braintrust.TopicAutomationConfigBackfillTimeRange, object>), TypeInfoPropertyName = "AnyOfStringTopicAutomationConfigBackfillTimeRangeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationConfigBackfillTimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>), TypeInfoPropertyName = "AnyOfProjectAutomationConfigVariant1ProjectAutomationConfigVariant2ProjectAutomationConfigVariant3ProjectAutomationConfigVariant4TopicAutomationConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant1EventType), TypeInfoPropertyName = "ProjectAutomationConfigVariant1EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2>), TypeInfoPropertyName = "OneOfProjectAutomationConfigVariant1ActionVariant1ProjectAutomationConfigVariant1ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1Type), TypeInfoPropertyName = "ProjectAutomationConfigVariant1ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2Type), TypeInfoPropertyName = "ProjectAutomationConfigVariant1ActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2EventType), TypeInfoPropertyName = "ProjectAutomationConfigVariant2EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>), TypeInfoPropertyName = "OneOfProjectAutomationConfigVariant2ExportDefinitionVariant1ProjectAutomationConfigVariant2ExportDefinitionVariant2ProjectAutomationConfigVariant2ExportDefinitionVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1Type), TypeInfoPropertyName = "ProjectAutomationConfigVariant2ExportDefinitionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2Type), TypeInfoPropertyName = "ProjectAutomationConfigVariant2ExportDefinitionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type), TypeInfoPropertyName = "ProjectAutomationConfigVariant2ExportDefinitionVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2Format), TypeInfoPropertyName = "ProjectAutomationConfigVariant2Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2Credentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2CredentialsType), TypeInfoPropertyName = "ProjectAutomationConfigVariant2CredentialsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant3EventType), TypeInfoPropertyName = "ProjectAutomationConfigVariant3EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant4EventType), TypeInfoPropertyName = "ProjectAutomationConfigVariant4EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant4ActionVariant2>), TypeInfoPropertyName = "OneOfProjectAutomationConfigVariant4ActionVariant1ProjectAutomationConfigVariant4ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant4ActionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant4ActionVariant1Type), TypeInfoPropertyName = "ProjectAutomationConfigVariant4ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant4ActionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant4ActionVariant2Type), TypeInfoPropertyName = "ProjectAutomationConfigVariant4ActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>), TypeInfoPropertyName = "AnyOfCreateProjectAutomationConfigVariant1CreateProjectAutomationConfigVariant2CreateProjectAutomationConfigVariant3CreateProjectAutomationConfigVariant4TopicAutomationConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant1EventType), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant1EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2>), TypeInfoPropertyName = "OneOfCreateProjectAutomationConfigVariant1ActionVariant1CreateProjectAutomationConfigVariant1ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1Type), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant1ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2Type), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant1ActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2EventType), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>), TypeInfoPropertyName = "OneOfCreateProjectAutomationConfigVariant2ExportDefinitionVariant1CreateProjectAutomationConfigVariant2ExportDefinitionVariant2CreateProjectAutomationConfigVariant2ExportDefinitionVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2Format), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2Credentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsType), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2CredentialsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant3EventType), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant3EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant4EventType), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant4EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant4ActionVariant2>), TypeInfoPropertyName = "OneOfCreateProjectAutomationConfigVariant4ActionVariant1CreateProjectAutomationConfigVariant4ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant4ActionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant4ActionVariant1Type), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant4ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant4ActionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant4ActionVariant2Type), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant4ActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig, object>), TypeInfoPropertyName = "AnyOfPatchProjectAutomationConfigVariant1PatchProjectAutomationConfigVariant2PatchProjectAutomationConfigVariant3PatchProjectAutomationConfigVariant4TopicAutomationConfigObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant1EventType), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant1EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2>), TypeInfoPropertyName = "OneOfPatchProjectAutomationConfigVariant1ActionVariant1PatchProjectAutomationConfigVariant1ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1Type), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant1ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2Type), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant1ActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2EventType), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3>), TypeInfoPropertyName = "OneOfPatchProjectAutomationConfigVariant2ExportDefinitionVariant1PatchProjectAutomationConfigVariant2ExportDefinitionVariant2PatchProjectAutomationConfigVariant2ExportDefinitionVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2Format), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2Credentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsType), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2CredentialsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant3EventType), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant3EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant4EventType), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant4EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant4ActionVariant2>), TypeInfoPropertyName = "OneOfPatchProjectAutomationConfigVariant4ActionVariant1PatchProjectAutomationConfigVariant4ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant4ActionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant4ActionVariant1Type), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant4ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant4ActionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant4ActionVariant2Type), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant4ActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreCategories), TypeInfoPropertyName = "ProjectScoreCategories2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ProjectScoreCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OnlineScoreConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>), TypeInfoPropertyName = "AllOfSavedFunctionIdAnyOfOnlineScoreConfigScorerVariant2FunctionOnlineScoreConfigScorerVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>), TypeInfoPropertyName = "AnyOfOnlineScoreConfigScorerVariant2FunctionOnlineScoreConfigScorerVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OnlineScoreConfigScorerVariant2Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType), TypeInfoPropertyName = "OnlineScoreConfigScorerVariant2FunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OnlineScoreConfigScorerVariant2Global))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType), TypeInfoPropertyName = "OnlineScoreConfigScorerVariant2GlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanIFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateSpanIFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchSpanIFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EvalStatusPageTheme), TypeInfoPropertyName = "EvalStatusPageTheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EvalStatusPageConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EvalStatusPageConfigSortOrder), TypeInfoPropertyName = "EvalStatusPageConfigSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EvalStatusPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateEvalStatusPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchEvalStatusPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleRuntimeContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleRuntimeContextRuntime), TypeInfoPropertyName = "CodeBundleRuntimeContextRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperiment, global::Braintrust.CodeBundleLocationFunction, global::Braintrust.CodeBundleLocationVariant3>), TypeInfoPropertyName = "AnyOfCodeBundleLocationExperimentCodeBundleLocationFunctionCodeBundleLocationVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperimentType), TypeInfoPropertyName = "CodeBundleLocationExperimentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer>), TypeInfoPropertyName = "AnyOfCodeBundleLocationExperimentPositionVariant1CodeBundleLocationExperimentPositionScorer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperimentPositionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperimentPositionVariant1Type), TypeInfoPropertyName = "CodeBundleLocationExperimentPositionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperimentPositionScorer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperimentPositionScorerType), TypeInfoPropertyName = "CodeBundleLocationExperimentPositionScorerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationFunctionType), TypeInfoPropertyName = "CodeBundleLocationFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationVariant3Type), TypeInfoPropertyName = "CodeBundleLocationVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1, global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2>), TypeInfoPropertyName = "OneOfCodeBundleLocationVariant3SandboxSpecVariant1CodeBundleLocationVariant3SandboxSpecVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1Provider), TypeInfoPropertyName = "CodeBundleLocationVariant3SandboxSpecVariant1Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2Provider), TypeInfoPropertyName = "CodeBundleLocationVariant3SandboxSpecVariant2Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptBlockData), TypeInfoPropertyName = "PromptBlockData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptBlockDataChat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptBlockDataChatType), TypeInfoPropertyName = "PromptBlockDataChatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptBlockDataCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptBlockDataCompletionType), TypeInfoPropertyName = "PromptBlockDataCompletionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNode), TypeInfoPropertyName = "GraphNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant1Position))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant1Type), TypeInfoPropertyName = "GraphNodeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant2Position))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant2Type), TypeInfoPropertyName = "GraphNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant3Position))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant3Type), TypeInfoPropertyName = "GraphNodeVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant4Position))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant4Type), TypeInfoPropertyName = "GraphNodeVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant5Position))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant5Type), TypeInfoPropertyName = "GraphNodeVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant6Position))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant6Type), TypeInfoPropertyName = "GraphNodeVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant7Position))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant7Type), TypeInfoPropertyName = "GraphNodeVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant8Position))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant8Type), TypeInfoPropertyName = "GraphNodeVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphEdgeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphEdgeTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphEdgePurpose), TypeInfoPropertyName = "GraphEdgePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphDataType), TypeInfoPropertyName = "GraphDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Braintrust.GraphEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetDataType), TypeInfoPropertyName = "FacetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.NullableSavedFunctionId?, object>), TypeInfoPropertyName = "AllOfNullableSavedFunctionIdObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapDataType), TypeInfoPropertyName = "TopicMapDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.BatchedFacetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.BatchedFacetDataType), TypeInfoPropertyName = "BatchedFacetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataFacet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.BatchedFacetDataFacet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataTopicMap>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataTopicMap>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.BatchedFacetDataTopicMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionData), TypeInfoPropertyName = "FunctionData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataPromptType), TypeInfoPropertyName = "FunctionDataPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataCodeType), TypeInfoPropertyName = "FunctionDataCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataCodeData2>), TypeInfoPropertyName = "AnyOfAllOfFunctionDataCodeDataCodeBundleFunctionDataCodeData22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>), TypeInfoPropertyName = "AllOfFunctionDataCodeDataCodeBundle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataCodeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataCodeDataType), TypeInfoPropertyName = "FunctionDataCodeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataCodeData2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataCodeDataType2), TypeInfoPropertyName = "FunctionDataCodeDataType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataCodeDataRuntimeContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataCodeDataRuntimeContextRuntime), TypeInfoPropertyName = "FunctionDataCodeDataRuntimeContextRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataRemoteEval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataRemoteEvalType), TypeInfoPropertyName = "FunctionDataRemoteEvalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataGlobal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataGlobalType), TypeInfoPropertyName = "FunctionDataGlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataParametersType), TypeInfoPropertyName = "FunctionDataParametersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataParametersSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataParametersSchemaType), TypeInfoPropertyName = "FunctionDataParametersSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, object?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>), TypeInfoPropertyName = "AllOfTopicMapDataObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Function2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionLogId), TypeInfoPropertyName = "FunctionLogId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionOrigin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionFunctionSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateFunctionOrigin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateFunctionFunctionSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullish), TypeInfoPropertyName = "FunctionDataNullish2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishPromptType), TypeInfoPropertyName = "FunctionDataNullishPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishCodeType), TypeInfoPropertyName = "FunctionDataNullishCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataNullishCodeData2>), TypeInfoPropertyName = "AnyOfAllOfFunctionDataNullishCodeDataCodeBundleFunctionDataNullishCodeData22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>), TypeInfoPropertyName = "AllOfFunctionDataNullishCodeDataCodeBundle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishCodeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishCodeDataType), TypeInfoPropertyName = "FunctionDataNullishCodeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishCodeData2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishCodeDataType2), TypeInfoPropertyName = "FunctionDataNullishCodeDataType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishCodeDataRuntimeContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishCodeDataRuntimeContextRuntime), TypeInfoPropertyName = "FunctionDataNullishCodeDataRuntimeContextRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishRemoteEval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishRemoteEvalType), TypeInfoPropertyName = "FunctionDataNullishRemoteEvalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishGlobal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishGlobalType), TypeInfoPropertyName = "FunctionDataNullishGlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishParametersType), TypeInfoPropertyName = "FunctionDataNullishParametersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishParametersSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishParametersSchemaType), TypeInfoPropertyName = "FunctionDataNullishParametersSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InvokeParent), TypeInfoPropertyName = "InvokeParent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InvokeParentSpanParentStruct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InvokeParentSpanParentStructObjectType), TypeInfoPropertyName = "InvokeParentSpanParentStructObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InvokeParentSpanParentStructRowIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.StreamingMode), TypeInfoPropertyName = "StreamingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InvokeApi))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Braintrust.InvokeApiMcpAuth2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InvokeApiMcpAuth2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewDataSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptions), TypeInfoPropertyName = "ViewOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsMonitorViewOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsMonitorViewOptionsViewType), TypeInfoPropertyName = "ViewOptionsMonitorViewOptionsViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType), TypeInfoPropertyName = "ViewOptionsMonitorViewOptionsOptionsSpanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType), TypeInfoPropertyName = "ViewOptionsMonitorViewOptionsOptionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType), TypeInfoPropertyName = "ViewOptionsTableViewOptionsExcludedMeasureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsYMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsYMetricType), TypeInfoPropertyName = "ViewOptionsTableViewOptionsYMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsXAxis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsXAxisType), TypeInfoPropertyName = "ViewOptionsTableViewOptionsXAxisType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsSymbolGrouping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType), TypeInfoPropertyName = "ViewOptionsTableViewOptionsSymbolGroupingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter, object>), TypeInfoPropertyName = "AnyOfStringViewOptionsTableViewOptionsTimeRangeFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsQueryShape), TypeInfoPropertyName = "ViewOptionsTableViewOptionsQueryShape2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.View))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewViewType), TypeInfoPropertyName = "ViewViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateViewViewType), TypeInfoPropertyName = "CreateViewViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchViewViewType), TypeInfoPropertyName = "PatchViewViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.DeleteView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ImageRenderingMode), TypeInfoPropertyName = "ImageRenderingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchOrganization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchOrganizationMembersOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchOrganizationMembersOutputStatus), TypeInfoPropertyName = "PatchOrganizationMembersOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.PatchOrganizationMembersOutputAddedUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchOrganizationMembersOutputAddedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchOrganizationMembers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchOrganizationMembersInviteUsers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchOrganizationMembersRemoveUsers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateApiKeyOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateServiceTokenOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ServiceToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.DeleteServiceToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AISecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateAISecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.DeleteAISecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchAISecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EnvVar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EnvVarObjectType2), TypeInfoPropertyName = "EnvVarObjectType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EnvVarSecretCategory), TypeInfoPropertyName = "EnvVarSecretCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.MCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Environment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateEnvironment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchEnvironment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CrossObjectInsertResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Braintrust.InsertEventsResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CrossObjectInsertRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestExperiment2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CrossObjectInsertRequestExperiment2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestDataset2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CrossObjectInsertRequestDataset2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestProjectLogs2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CrossObjectInsertRequestProjectLogs2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>), TypeInfoPropertyName = "AllOfSavedFunctionIdAnyOfPromptDataToolFunctionVariant2FunctionPromptDataToolFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>), TypeInfoPropertyName = "AnyOfPromptDataToolFunctionVariant2FunctionPromptDataToolFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataToolFunctionVariant2Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataToolFunctionVariant2FunctionType), TypeInfoPropertyName = "PromptDataToolFunctionVariant2FunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataToolFunctionVariant2Global))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataToolFunctionVariant2GlobalType), TypeInfoPropertyName = "PromptDataToolFunctionVariant2GlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataTemplateFormat), TypeInfoPropertyName = "PromptDataTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>), TypeInfoPropertyName = "OneOfPromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsPromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType), TypeInfoPropertyName = "PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType), TypeInfoPropertyName = "PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataOrigin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionId), TypeInfoPropertyName = "FunctionId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionIdFunctionId1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionIdProjectSlug))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionIdGlobalFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionIdPromptSessionId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionIdInlineCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionIdInlineCodeInlineContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionIdInlineCodeInlineContextRuntime), TypeInfoPropertyName = "FunctionIdInlineCodeInlineContextRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionIdInlineFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionIdInlinePrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GitMetadataSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GitMetadataSettingsCollect), TypeInfoPropertyName = "GitMetadataSettingsCollect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.GitMetadataSettingsField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GitMetadataSettingsField), TypeInfoPropertyName = "GitMetadataSettingsField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.RunEval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.RunEvalDataDatasetId, global::Braintrust.RunEvalDataProjectDatasetName, global::Braintrust.RunEvalDataDatasetRows>), TypeInfoPropertyName = "AnyOfRunEvalDataDatasetIdRunEvalDataProjectDatasetNameRunEvalDataDatasetRows2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.RunEvalDataDatasetId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.RunEvalDataProjectDatasetName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.RunEvalDataDatasetRows))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>), TypeInfoPropertyName = "AllOfFunctionIdObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.InvokeParent?, object>), TypeInfoPropertyName = "AllOfInvokeParentObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.RepoInfo, object>), TypeInfoPropertyName = "AllOfRepoInfoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Braintrust.RunEvalMcpAuth2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.RunEvalMcpAuth2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PostApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PostServiceTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PutServiceTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PostEnvVarRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PostEnvVarRequestObjectType), TypeInfoPropertyName = "PostEnvVarRequestObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PutEnvVarRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PutEnvVarRequestObjectType), TypeInfoPropertyName = "PutEnvVarRequestObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchEnvVarIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProxycredentialsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProxycredentialsRequestLogging))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>), TypeInfoPropertyName = "AnyOfProjectScoreTypeIListAllOfProjectScoreTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>), TypeInfoPropertyName = "AllOfProjectScoreTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>), TypeInfoPropertyName = "AnyOfGuidIListGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetExperimentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.Experiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetDatasetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetPromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetRoleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.Group>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetAclResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetProjectAutomationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ProjectAutomation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetProjectScoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ProjectScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetProjectTagResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ProjectTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetSpanIframeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.SpanIFrame>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetEvalStatusPageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.EvalStatusPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetFunctionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.Function2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetViewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.View>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetOrganizationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.Organization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetServiceTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ServiceToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetAiSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.AISecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetEnvVarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.EnvVar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetMcpServerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.MCPServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ListEnvironmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.Environment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProxycredentialsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectSettingsSpanFieldOrderItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectSettingsRemoteEvalSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.InsertProjectLogsEventArrayDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.InsertProjectLogsEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.ProjectLogsEventClassification>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectLogsEventClassification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectLogsEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.FeedbackProjectLogsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.InsertExperimentEventArrayDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.InsertExperimentEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.ExperimentEventClassification>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ExperimentEventClassification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ExperimentEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.FeedbackExperimentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.InsertDatasetEventArrayDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.InsertDatasetEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.DatasetEventClassification>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.DatasetEventClassification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.DatasetEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.FeedbackDatasetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPartText>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPartText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPartText>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ChatCompletionMessageReasoning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ChatCompletionMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.RoleMemberPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.CreateRoleMemberPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.PatchRoleAddMemberPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.PatchRoleRemoveMemberPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.Acl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AclItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.TopicMapFunctionAutomation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectScoreCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.BatchedFacetDataFacet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.BatchedFacetDataTopicMap>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.BatchedFacetDataTopicMap>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.PatchOrganizationMembersOutputAddedUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.GitMetadataSettingsField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::System.Guid?, global::System.Collections.Generic.List<global::System.Guid>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.Experiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.Group>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectAutomation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.SpanIFrame>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.EvalStatusPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.Function2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.View>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.Organization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ServiceToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AISecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.EnvVar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.MCPServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.Environment>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}