
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

            typeof(global::Braintrust.JsonConverters.SpanAttributesPurposeJsonConverter),

            typeof(global::Braintrust.JsonConverters.SpanAttributesPurposeNullableJsonConverter),

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

            typeof(global::Braintrust.JsonConverters.AutomationStatusJsonConverter),

            typeof(global::Braintrust.JsonConverters.AutomationStatusNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.SpanScopeTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.SpanScopeTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TraceScopeTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.TraceScopeTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GroupScopeTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.GroupScopeTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GroupScopePlacementJsonConverter),

            typeof(global::Braintrust.JsonConverters.GroupScopePlacementNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.RetentionObjectTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.RetentionObjectTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationFacetModelJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationFacetModelNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2FunctionTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2FunctionTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2GlobalTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2GlobalTypeNullableJsonConverter),

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

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant2TypeNullableJsonConverter),

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

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsVariant2TypeNullableJsonConverter),

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

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsVariant2TypeNullableJsonConverter),

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

            typeof(global::Braintrust.JsonConverters.CodeBundleRuntimeContextRuntimeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleRuntimeContextRuntimeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionScorerTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionScorerTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionClassifierTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionClassifierTypeNullableJsonConverter),

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

            typeof(global::Braintrust.JsonConverters.TopicMapGenerationSettingsAlgorithmJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapGenerationSettingsAlgorithmNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapGenerationSettingsDimensionReductionJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapGenerationSettingsDimensionReductionNullableJsonConverter),

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

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant4ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant4ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig, object>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant4ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.CodeBundleLocationExperiment, global::Braintrust.CodeBundleLocationFunction, global::Braintrust.CodeBundleLocationVariant3>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer, global::Braintrust.CodeBundleLocationExperimentPositionClassifier>),

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

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionTypeEnum?, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.RunEvalDataDatasetId, global::Braintrust.RunEvalDataProjectDatasetName, global::Braintrust.RunEvalDataDatasetRows>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionId?, object>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.InvokeParent?, object>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.RepoInfo, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.ProjectScoreType?, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Braintrust.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionId), TypeInfoPropertyName = "NullableSavedFunctionId_Braintrust_NullableSavedFunctionId")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionIdFunctionType), TypeInfoPropertyName = "NullableSavedFunctionIdFunctionType_Braintrust_NullableSavedFunctionIdFunctionType")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionIdGlobalType), TypeInfoPropertyName = "NullableSavedFunctionIdGlobalType_Braintrust_NullableSavedFunctionIdGlobalType")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?>), TypeInfoPropertyName = "ChatCompletionContentPartImageWithTitleImageUrlDetailHigh_e8d70c92af1da1bc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction>), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsToolChoiceFunction_10f78e443eec5956")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallFunction>), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsFunctionCallFunction_fae5e4272e975e60")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>), TypeInfoPropertyName = "PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers_011c031415cbd2fb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>?>), TypeInfoPropertyName = "TopicMapFunctionAutomationFunctionVariant2Global_31dc6848fbb9ed5d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>>), TypeInfoPropertyName = "TopicAutomationConfigFacetFunctionVariant2Global_385eb3dc65d85bbf")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>), TypeInfoPropertyName = "TopicAutomationConfigFacetFunctionVariant2Global_35e623b86265f845")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>), TypeInfoPropertyName = "TopicAutomationConfig_eaf8b9b49c567561")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>), TypeInfoPropertyName = "ProjectAutomationConfigVariant2ExportDefinitionVariant3_2a6132df942795d9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>), TypeInfoPropertyName = "TopicAutomationConfig_ccd36d425d0ff8b1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2ExportDefinitionVariant3_378e18d0da0115e9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig, object>), TypeInfoPropertyName = "TopicAutomationConfig_object_c1d13683938f4e63")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3>), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2ExportDefinitionVariant3_a18e2b09c026c85e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer, global::Braintrust.CodeBundleLocationExperimentPositionClassifier>), TypeInfoPropertyName = "CodeBundleLocationExperimentPositionClassifier_b29c562fd5b3ee2b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>), TypeInfoPropertyName = "PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers_5dbc7250a4b23b86")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionId?), TypeInfoPropertyName = "NullableSavedFunctionId_Braintrust_SavedFunctionId")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdFunctionType?), TypeInfoPropertyName = "NullableSavedFunctionIdFunctionType_Braintrust_SavedFunctionIdFunctionType")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdGlobalType?), TypeInfoPropertyName = "NullableSavedFunctionIdGlobalType_Braintrust_SavedFunctionIdGlobalType")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?>?), TypeInfoPropertyName = "ChatCompletionContentPartImageWithTitleImageUrlDetailHigh_3533da88d7ecf2d5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction>?), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsToolChoiceFunction_185a87e2aac60e39")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallFunction>?), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsFunctionCallFunction_b998c4cffab2d96d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>?>?), TypeInfoPropertyName = "PromptDataNullishToolFunctionVariant2Global_9bd0fd9ab612ae14")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>?), TypeInfoPropertyName = "PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers_d50854d224e89aa6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>?>?), TypeInfoPropertyName = "TopicMapFunctionAutomationFunctionVariant2Global_dd10e9b65bc14212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>?), TypeInfoPropertyName = "TopicAutomationConfigFacetFunctionVariant2Global_e7c55b45c643ace1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>?), TypeInfoPropertyName = "TopicAutomationConfig_58df192aaf6fc2e5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>?), TypeInfoPropertyName = "ProjectAutomationConfigVariant2ExportDefinitionVariant3_ec6424933b017d35")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>?), TypeInfoPropertyName = "TopicAutomationConfig_881d1aa9c96b0132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>?), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2ExportDefinitionVariant3_c447fd26e3994f56")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2>?), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2CredentialsVariant2_4d1ae1fb74e40163")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig, object>?), TypeInfoPropertyName = "TopicAutomationConfig_object_d9870abf8360f205")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3>?), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2ExportDefinitionVariant3_406398cc1ac2a868")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2>?), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2CredentialsVariant2_8e5c5ea50cba239d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer, global::Braintrust.CodeBundleLocationExperimentPositionClassifier>?), TypeInfoPropertyName = "CodeBundleLocationExperimentPositionClassifier_c4d9fe7d3ca7c609")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>?), TypeInfoPropertyName = "PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers_2c2424cd8ae0cdf5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>>), TypeInfoPropertyName = "TopicAutomationConfigFacetFunctionVariant2Global_0de25e7b7f3aebf4")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EnvVarObjectType), TypeInfoPropertyName = "EnvVarObjectType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionTypeEnum), TypeInfoPropertyName = "FunctionTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionIdFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionIdGlobal))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanAttributesPurpose), TypeInfoPropertyName = "SpanAttributesPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ObjectReferenceNullish))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ObjectReferenceNullishObjectType), TypeInfoPropertyName = "ObjectReferenceNullishObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertProjectLogsEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double?>), TypeInfoPropertyName = "DictionaryStringDouble_System_Collections_Generic_Dictionary_string_double")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertProjectLogsEventMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertProjectLogsEventMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertProjectLogsEventContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ExperimentInternalMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateExperimentInternalMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchExperimentInternalMetadata))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsToolChoiceAuto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsToolChoiceNone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsToolChoiceRequired2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionType), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsToolChoiceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionFunction))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>), TypeInfoPropertyName = "DictionaryStringDouble_System_Collections_Generic_Dictionary_string_double_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullish))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>?>), TypeInfoPropertyName = "AllOfSavedFunctionIdAnyOfPromptDataNullishToolFunctionVariant2FunctionPromptDataNullishToolFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>), TypeInfoPropertyName = "AnyOfPromptDataNullishToolFunctionVariant2FunctionPromptDataNullishToolFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2FunctionType), TypeInfoPropertyName = "PromptDataNullishToolFunctionVariant2FunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2Global))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2GlobalType), TypeInfoPropertyName = "PromptDataNullishToolFunctionVariant2GlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishTemplateFormat), TypeInfoPropertyName = "PromptDataNullishTemplateFormat2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AutomationStatus), TypeInfoPropertyName = "AutomationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanScopeType), TypeInfoPropertyName = "SpanScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TraceScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TraceScopeType), TypeInfoPropertyName = "TraceScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GroupScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GroupScopeType), TypeInfoPropertyName = "GroupScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GroupScopePlacement), TypeInfoPropertyName = "GroupScopePlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.RetentionObjectType), TypeInfoPropertyName = "RetentionObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationFacetModel), TypeInfoPropertyName = "TopicAutomationFacetModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapFunctionAutomation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>), TypeInfoPropertyName = "AnyOfTopicMapFunctionAutomationFunctionVariant2FunctionTopicMapFunctionAutomationFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2FunctionType), TypeInfoPropertyName = "TopicMapFunctionAutomationFunctionVariant2FunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2GlobalType), TypeInfoPropertyName = "TopicMapFunctionAutomationFunctionVariant2GlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScope), TypeInfoPropertyName = "TopicAutomationDataScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScopeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScopeVariant1Type), TypeInfoPropertyName = "TopicAutomationDataScopeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScopeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScopeVariant2Type), TypeInfoPropertyName = "TopicAutomationDataScopeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScopeVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScopeVariant3Type), TypeInfoPropertyName = "TopicAutomationDataScopeVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationConfigEventType), TypeInfoPropertyName = "TopicAutomationConfigEventType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant1EventType), TypeInfoPropertyName = "ProjectAutomationConfigVariant1EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2>), TypeInfoPropertyName = "OneOfProjectAutomationConfigVariant1ActionVariant1ProjectAutomationConfigVariant1ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1Type), TypeInfoPropertyName = "ProjectAutomationConfigVariant1ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2Type), TypeInfoPropertyName = "ProjectAutomationConfigVariant1ActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2EventType), TypeInfoPropertyName = "ProjectAutomationConfigVariant2EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1Type), TypeInfoPropertyName = "ProjectAutomationConfigVariant2ExportDefinitionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2Type), TypeInfoPropertyName = "ProjectAutomationConfigVariant2ExportDefinitionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type), TypeInfoPropertyName = "ProjectAutomationConfigVariant2ExportDefinitionVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2Format), TypeInfoPropertyName = "ProjectAutomationConfigVariant2Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2>), TypeInfoPropertyName = "OneOfProjectAutomationConfigVariant2CredentialsVariant1ProjectAutomationConfigVariant2CredentialsVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1Type), TypeInfoPropertyName = "ProjectAutomationConfigVariant2CredentialsVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2Type), TypeInfoPropertyName = "ProjectAutomationConfigVariant2CredentialsVariant2Type2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant1EventType), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant1EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2>), TypeInfoPropertyName = "OneOfCreateProjectAutomationConfigVariant1ActionVariant1CreateProjectAutomationConfigVariant1ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1Type), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant1ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2Type), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant1ActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2EventType), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2Format), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2>), TypeInfoPropertyName = "OneOfCreateProjectAutomationConfigVariant2CredentialsVariant1CreateProjectAutomationConfigVariant2CredentialsVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1Type), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2CredentialsVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2Type), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2CredentialsVariant2Type2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant1EventType), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant1EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2>), TypeInfoPropertyName = "OneOfPatchProjectAutomationConfigVariant1ActionVariant1PatchProjectAutomationConfigVariant1ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1Type), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant1ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2Type), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant1ActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2EventType), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2Format), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2>), TypeInfoPropertyName = "OneOfPatchProjectAutomationConfigVariant2CredentialsVariant1PatchProjectAutomationConfigVariant2CredentialsVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1Type), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2CredentialsVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2Type), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2CredentialsVariant2Type2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreConfigVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanIFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateSpanIFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchSpanIFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleRuntimeContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleRuntimeContextRuntime), TypeInfoPropertyName = "CodeBundleRuntimeContextRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperiment, global::Braintrust.CodeBundleLocationFunction, global::Braintrust.CodeBundleLocationVariant3>), TypeInfoPropertyName = "AnyOfCodeBundleLocationExperimentCodeBundleLocationFunctionCodeBundleLocationVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperimentType), TypeInfoPropertyName = "CodeBundleLocationExperimentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperimentPositionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperimentPositionVariant1Type), TypeInfoPropertyName = "CodeBundleLocationExperimentPositionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperimentPositionScorer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperimentPositionScorerType), TypeInfoPropertyName = "CodeBundleLocationExperimentPositionScorerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperimentPositionClassifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperimentPositionClassifierType), TypeInfoPropertyName = "CodeBundleLocationExperimentPositionClassifierType2")]
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
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

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

            typeof(global::Braintrust.JsonConverters.SpanAttributesPurposeJsonConverter),

            typeof(global::Braintrust.JsonConverters.SpanAttributesPurposeNullableJsonConverter),

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

            typeof(global::Braintrust.JsonConverters.AutomationStatusJsonConverter),

            typeof(global::Braintrust.JsonConverters.AutomationStatusNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.SpanScopeTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.SpanScopeTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TraceScopeTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.TraceScopeTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GroupScopeTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.GroupScopeTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.GroupScopePlacementJsonConverter),

            typeof(global::Braintrust.JsonConverters.GroupScopePlacementNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.RetentionObjectTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.RetentionObjectTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationFacetModelJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicAutomationFacetModelNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2FunctionTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2FunctionTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2GlobalTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2GlobalTypeNullableJsonConverter),

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

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant2TypeNullableJsonConverter),

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

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsVariant2TypeNullableJsonConverter),

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

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsVariant2TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsVariant2TypeNullableJsonConverter),

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

            typeof(global::Braintrust.JsonConverters.CodeBundleRuntimeContextRuntimeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleRuntimeContextRuntimeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionVariant1TypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionVariant1TypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionScorerTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionScorerTypeNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionClassifierTypeJsonConverter),

            typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionClassifierTypeNullableJsonConverter),

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

            typeof(global::Braintrust.JsonConverters.TopicMapGenerationSettingsAlgorithmJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapGenerationSettingsAlgorithmNullableJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapGenerationSettingsDimensionReductionJsonConverter),

            typeof(global::Braintrust.JsonConverters.TopicMapGenerationSettingsDimensionReductionNullableJsonConverter),

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

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant4ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant4ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig, object>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2>),

            typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant4ActionVariant2>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.CodeBundleLocationExperiment, global::Braintrust.CodeBundleLocationFunction, global::Braintrust.CodeBundleLocationVariant3>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer, global::Braintrust.CodeBundleLocationExperimentPositionClassifier>),

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

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionTypeEnum?, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.RunEvalDataDatasetId, global::Braintrust.RunEvalDataProjectDatasetName, global::Braintrust.RunEvalDataDatasetRows>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionId?, object>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.InvokeParent?, object>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.RepoInfo, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>),

            typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.ProjectScoreType?, object>),

            typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::Braintrust.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionId), TypeInfoPropertyName = "NullableSavedFunctionId_Braintrust_NullableSavedFunctionId")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionIdFunctionType), TypeInfoPropertyName = "NullableSavedFunctionIdFunctionType_Braintrust_NullableSavedFunctionIdFunctionType")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionIdGlobalType), TypeInfoPropertyName = "NullableSavedFunctionIdGlobalType_Braintrust_NullableSavedFunctionIdGlobalType")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?>), TypeInfoPropertyName = "ChatCompletionContentPartImageWithTitleImageUrlDetailHigh_e8d70c92af1da1bc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction>), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsToolChoiceFunction_10f78e443eec5956")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallFunction>), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsFunctionCallFunction_fae5e4272e975e60")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>), TypeInfoPropertyName = "PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers_011c031415cbd2fb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>?>), TypeInfoPropertyName = "TopicMapFunctionAutomationFunctionVariant2Global_31dc6848fbb9ed5d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>>), TypeInfoPropertyName = "TopicAutomationConfigFacetFunctionVariant2Global_385eb3dc65d85bbf")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>), TypeInfoPropertyName = "TopicAutomationConfigFacetFunctionVariant2Global_35e623b86265f845")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>), TypeInfoPropertyName = "TopicAutomationConfig_eaf8b9b49c567561")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>), TypeInfoPropertyName = "ProjectAutomationConfigVariant2ExportDefinitionVariant3_2a6132df942795d9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>), TypeInfoPropertyName = "TopicAutomationConfig_ccd36d425d0ff8b1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2ExportDefinitionVariant3_378e18d0da0115e9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig, object>), TypeInfoPropertyName = "TopicAutomationConfig_object_c1d13683938f4e63")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3>), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2ExportDefinitionVariant3_a18e2b09c026c85e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer, global::Braintrust.CodeBundleLocationExperimentPositionClassifier>), TypeInfoPropertyName = "CodeBundleLocationExperimentPositionClassifier_b29c562fd5b3ee2b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>), TypeInfoPropertyName = "PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers_5dbc7250a4b23b86")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionId?), TypeInfoPropertyName = "NullableSavedFunctionId_Braintrust_SavedFunctionId")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdFunctionType?), TypeInfoPropertyName = "NullableSavedFunctionIdFunctionType_Braintrust_SavedFunctionIdFunctionType")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdGlobalType?), TypeInfoPropertyName = "NullableSavedFunctionIdGlobalType_Braintrust_SavedFunctionIdGlobalType")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?>?), TypeInfoPropertyName = "ChatCompletionContentPartImageWithTitleImageUrlDetailHigh_3533da88d7ecf2d5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction>?), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsToolChoiceFunction_185a87e2aac60e39")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallFunction>?), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsFunctionCallFunction_b998c4cffab2d96d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>?>?), TypeInfoPropertyName = "PromptDataNullishToolFunctionVariant2Global_9bd0fd9ab612ae14")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>?), TypeInfoPropertyName = "PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers_d50854d224e89aa6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>?>?), TypeInfoPropertyName = "TopicMapFunctionAutomationFunctionVariant2Global_dd10e9b65bc14212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>?), TypeInfoPropertyName = "TopicAutomationConfigFacetFunctionVariant2Global_e7c55b45c643ace1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>?), TypeInfoPropertyName = "TopicAutomationConfig_58df192aaf6fc2e5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>?), TypeInfoPropertyName = "ProjectAutomationConfigVariant2ExportDefinitionVariant3_ec6424933b017d35")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>?), TypeInfoPropertyName = "TopicAutomationConfig_881d1aa9c96b0132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>?), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2ExportDefinitionVariant3_c447fd26e3994f56")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2>?), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2CredentialsVariant2_4d1ae1fb74e40163")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig, object>?), TypeInfoPropertyName = "TopicAutomationConfig_object_d9870abf8360f205")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3>?), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2ExportDefinitionVariant3_406398cc1ac2a868")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2>?), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2CredentialsVariant2_8e5c5ea50cba239d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer, global::Braintrust.CodeBundleLocationExperimentPositionClassifier>?), TypeInfoPropertyName = "CodeBundleLocationExperimentPositionClassifier_c4d9fe7d3ca7c609")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>?), TypeInfoPropertyName = "PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers_2c2424cd8ae0cdf5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>>), TypeInfoPropertyName = "TopicAutomationConfigFacetFunctionVariant2Global_0de25e7b7f3aebf4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Braintrust.GraphEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetDataType), TypeInfoPropertyName = "FacetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.NullableSavedFunctionId?, object>), TypeInfoPropertyName = "AllOfNullableSavedFunctionIdObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapGenerationSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapGenerationSettingsAlgorithm), TypeInfoPropertyName = "TopicMapGenerationSettingsAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapGenerationSettingsDimensionReduction), TypeInfoPropertyName = "TopicMapGenerationSettingsDimensionReduction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapDataType), TypeInfoPropertyName = "TopicMapDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataCodeDataType), TypeInfoPropertyName = "FunctionDataCodeDataType2_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishCodeDataType), TypeInfoPropertyName = "FunctionDataNullishCodeDataType2_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.DatasetSnapshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateDatasetSnapshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchDatasetSnapshot))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.FunctionTypeEnum?, object>), TypeInfoPropertyName = "AllOfFunctionTypeEnumObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetDatasetSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.DatasetSnapshot>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.Function2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.View>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.Organization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ServiceToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AISecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.EnvVar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.MCPServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.DatasetSnapshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.Environment>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default
            );

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.AclObjectTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.AclObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.AclListOrgObjectTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.AclListOrgObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.AclListPermissionJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.AclListPermissionNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.AclListRestrictObjectTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.AclListRestrictObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectScoreTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectScoreTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.EnvVarObjectTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.EnvVarObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionTypeEnumJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionTypeEnumNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.NullableSavedFunctionIdFunctionTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.NullableSavedFunctionIdFunctionTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.NullableSavedFunctionIdGlobalTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.NullableSavedFunctionIdGlobalTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant1JsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant1NullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant2JsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant2NullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.SpanTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.SpanTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.SpanAttributesPurposeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.SpanAttributesPurposeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ObjectReferenceNullishObjectTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ObjectReferenceNullishObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.SavedFunctionIdFunctionTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.SavedFunctionIdFunctionTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.SavedFunctionIdGlobalTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.SavedFunctionIdGlobalTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectLogsEventLogIdJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectLogsEventLogIdNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FeedbackResponseSchemaStatusJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FeedbackResponseSchemaStatusNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FeedbackProjectLogsItemSourceJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FeedbackProjectLogsItemSourceNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FeedbackExperimentItemSourceJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FeedbackExperimentItemSourceNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FeedbackDatasetItemSourceJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FeedbackDatasetItemSourceNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartTextTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartTextTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartTextCacheControlTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartTextCacheControlTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleCacheControlTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleCacheControlTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailAutoJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailAutoNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailLowJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailLowNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailHighJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailHighNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartFileWithTitleTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartFileWithTitleTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageParamSystemRoleJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageParamSystemRoleNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageParamUserRoleJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageParamUserRoleNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageParamAssistantRoleJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageParamAssistantRoleNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageParamToolRoleJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageParamToolRoleNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageParamFunctionRoleJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageParamFunctionRoleNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageParamDeveloperRoleJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageParamDeveloperRoleNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageParamFallbackRoleJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageParamFallbackRoleNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptBlockDataNullishChatTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptBlockDataNullishChatTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptBlockDataNullishCompletionTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptBlockDataNullishCompletionTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ResponseFormatNullishJsonObjectTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ResponseFormatNullishJsonObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ResponseFormatNullishJsonSchemaTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ResponseFormatNullishJsonSchemaTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ResponseFormatNullishTextTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ResponseFormatNullishTextTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceAutoJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceAutoNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceNoneJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceNoneNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceRequiredJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceRequiredNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceFunctionTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceFunctionTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallAutoJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallAutoNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallNoneJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallNoneNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsReasoningEffortJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsReasoningEffortNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsVerbosityJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsVerbosityNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptParserNullishTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptParserNullishTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataNullishToolFunctionVariant2FunctionTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataNullishToolFunctionVariant2FunctionTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataNullishToolFunctionVariant2GlobalTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataNullishToolFunctionVariant2GlobalTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataNullishTemplateFormatJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataNullishTemplateFormatNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionTypeEnumNullishJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionTypeEnumNullishNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptLogIdJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptLogIdNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PermissionJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PermissionNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.AutomationStatusJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.AutomationStatusNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.SpanScopeTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.SpanScopeTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TraceScopeTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TraceScopeTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GroupScopeTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GroupScopeTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GroupScopePlacementJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GroupScopePlacementNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.RetentionObjectTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.RetentionObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicAutomationFacetModelJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicAutomationFacetModelNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2FunctionTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2FunctionTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2GlobalTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2GlobalTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant1TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant2TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant3TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant3TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicAutomationConfigEventTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicAutomationConfigEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicAutomationConfigFacetFunctionVariant2FunctionTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicAutomationConfigFacetFunctionVariant2FunctionTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicAutomationConfigFacetFunctionVariant2GlobalTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicAutomationConfigFacetFunctionVariant2GlobalTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1EventTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1EventTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1ActionVariant1TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1ActionVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1ActionVariant2TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1ActionVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2EventTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2EventTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant1TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2FormatJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2FormatNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant1TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant2TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant3EventTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant3EventTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4EventTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4EventTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4ActionVariant1TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4ActionVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4ActionVariant2TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4ActionVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1EventTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1EventTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant1TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant2TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2EventTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2EventTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2FormatJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2FormatNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsVariant1TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsVariant2TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant3EventTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant3EventTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4EventTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4EventTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant1TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant2TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1EventTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1EventTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant1TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant2TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2EventTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2EventTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2FormatJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2FormatNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsVariant1TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsVariant2TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant3EventTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant3EventTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4EventTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4EventTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant1TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant2TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2FunctionTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2FunctionTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2GlobalTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2GlobalTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleRuntimeContextRuntimeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleRuntimeContextRuntimeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleLocationExperimentTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleLocationExperimentTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionVariant1TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionScorerTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionScorerTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionClassifierTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionClassifierTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleLocationFunctionTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleLocationFunctionTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleLocationVariant3TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleLocationVariant3TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant1ProviderJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant1ProviderNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant2ProviderJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant2ProviderNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptBlockDataChatTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptBlockDataChatTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptBlockDataCompletionTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptBlockDataCompletionTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeVariant1TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeVariant2TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeVariant3TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeVariant3TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeVariant4TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeVariant4TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeVariant5TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeVariant5TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeVariant6TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeVariant6TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeVariant7TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeVariant7TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeVariant8TypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeVariant8TypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphEdgePurposeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphEdgePurposeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphDataTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphDataTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FacetDataTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FacetDataTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicMapGenerationSettingsAlgorithmJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicMapGenerationSettingsAlgorithmNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicMapGenerationSettingsDimensionReductionJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicMapGenerationSettingsDimensionReductionNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicMapDataTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicMapDataTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.BatchedFacetDataTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.BatchedFacetDataTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataPromptTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataPromptTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataCodeTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataCodeTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataCodeDataTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataCodeDataTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataCodeDataType2JsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataCodeDataType2NullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataCodeDataRuntimeContextRuntimeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataCodeDataRuntimeContextRuntimeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataRemoteEvalTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataRemoteEvalTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataGlobalTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataGlobalTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataParametersTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataParametersTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataParametersSchemaTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataParametersSchemaTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionLogIdJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionLogIdNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishPromptTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishPromptTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishCodeTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishCodeTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataType2JsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataType2NullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataRuntimeContextRuntimeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataRuntimeContextRuntimeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishRemoteEvalTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishRemoteEvalTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishGlobalTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishGlobalTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishParametersTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishParametersTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishParametersSchemaTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishParametersSchemaTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.InvokeParentSpanParentStructObjectTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.InvokeParentSpanParentStructObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.StreamingModeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.StreamingModeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsViewTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsViewTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsSpanTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsSpanTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsExcludedMeasureTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsExcludedMeasureTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsYMetricTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsYMetricTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsXAxisTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsXAxisTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsSymbolGroupingTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsSymbolGroupingTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsQueryShapeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsQueryShapeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewViewTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewViewTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateViewViewTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.CreateViewViewTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchViewViewTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchViewViewTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ImageRenderingModeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ImageRenderingModeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchOrganizationMembersOutputStatusJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PatchOrganizationMembersOutputStatusNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.EnvVarObjectType2JsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.EnvVarObjectType2NullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.EnvVarSecretCategoryJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.EnvVarSecretCategoryNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataToolFunctionVariant2FunctionTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataToolFunctionVariant2FunctionTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataToolFunctionVariant2GlobalTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataToolFunctionVariant2GlobalTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataTemplateFormatJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataTemplateFormatNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionIdInlineCodeInlineContextRuntimeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionIdInlineCodeInlineContextRuntimeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GitMetadataSettingsCollectJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GitMetadataSettingsCollectNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GitMetadataSettingsFieldJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GitMetadataSettingsFieldNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PostEnvVarRequestObjectTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PostEnvVarRequestObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PutEnvVarRequestObjectTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PutEnvVarRequestObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.IdsJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.UserGivenNameJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.UserFamilyNameJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.UserEmailJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.AISecretTypeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.NullableSavedFunctionIdJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.SavedFunctionIdJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageParamJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptBlockDataNullishJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ResponseFormatNullishJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicAutomationDataScopeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectScoreCategoriesJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptBlockDataJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionDataNullishJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.InvokeParentJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ViewOptionsJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FunctionIdJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant1?, global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant2?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.ProjectSettings, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPart>>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, object?>, string>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallFunction>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>?>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>?>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::Braintrust.TopicAutomationConfigBackfillTimeRange, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant4ActionVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant4ActionVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.TopicAutomationConfig, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant4ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant4ActionVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.CodeBundleLocationExperiment, global::Braintrust.CodeBundleLocationFunction, global::Braintrust.CodeBundleLocationVariant3>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer, global::Braintrust.CodeBundleLocationExperimentPositionClassifier>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1, global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.NullableSavedFunctionId?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.NullableSavedFunctionId?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataCodeData2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.TopicMapData, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataNullishCodeData2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.TopicMapData, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionTypeEnum?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.RunEvalDataDatasetId, global::Braintrust.RunEvalDataProjectDatasetName, global::Braintrust.RunEvalDataDatasetRows>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionId?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.InvokeParent?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.RepoInfo, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.ProjectScoreType?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::Braintrust.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}