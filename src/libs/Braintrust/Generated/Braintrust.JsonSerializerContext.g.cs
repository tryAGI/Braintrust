
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.ProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig>), TypeInfoPropertyName = "TopicDigestAutomationConfig_a53a8472277d3cbb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>), TypeInfoPropertyName = "ProjectAutomationConfigVariant2ExportDefinitionVariant3_2a6132df942795d9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.CreateProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig>), TypeInfoPropertyName = "TopicDigestAutomationConfig_881b44345301a863")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2ExportDefinitionVariant3_378e18d0da0115e9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.PatchProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig, object>), TypeInfoPropertyName = "TopicDigestAutomationConfig_object_f49eab62885d1964")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.ProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig>?), TypeInfoPropertyName = "TopicDigestAutomationConfig_58d61efe1875894e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>?), TypeInfoPropertyName = "ProjectAutomationConfigVariant2ExportDefinitionVariant3_ec6424933b017d35")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.CreateProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig>?), TypeInfoPropertyName = "TopicDigestAutomationConfig_055fe4ec45a86863")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>?), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2ExportDefinitionVariant3_c447fd26e3994f56")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2>?), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2CredentialsVariant2_4d1ae1fb74e40163")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.PatchProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig, object>?), TypeInfoPropertyName = "TopicDigestAutomationConfig_object_45351e097d855605")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3>?), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2ExportDefinitionVariant3_406398cc1ac2a868")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2>?), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2CredentialsVariant2_8e5c5ea50cba239d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer, global::Braintrust.CodeBundleLocationExperimentPositionClassifier>?), TypeInfoPropertyName = "CodeBundleLocationExperimentPositionClassifier_c4d9fe7d3ca7c609")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function, global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global>?>?), TypeInfoPropertyName = "TopicMapDataSourceFacetFunctionVariant2Global_601624aac81dbccb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>?), TypeInfoPropertyName = "PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers_2c2424cd8ae0cdf5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>>), TypeInfoPropertyName = "TopicAutomationConfigFacetFunctionVariant2Global_0de25e7b7f3aebf4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.InsertProjectLogsEventArrayDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InsertProjectLogsEventArrayDeleteItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object?>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextCacheControlTtl), TypeInfoPropertyName = "ChatCompletionContentPartTextCacheControlTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextWithTitle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleType), TypeInfoPropertyName = "ChatCompletionContentPartTextWithTitleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType), TypeInfoPropertyName = "ChatCompletionContentPartTextWithTitleCacheControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlTtl), TypeInfoPropertyName = "ChatCompletionContentPartTextWithTitleCacheControlTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto), TypeInfoPropertyName = "ChatCompletionContentPartImageWithTitleImageUrlDetailAuto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow), TypeInfoPropertyName = "ChatCompletionContentPartImageWithTitleImageUrlDetailLow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh), TypeInfoPropertyName = "ChatCompletionContentPartImageWithTitleImageUrlDetailHigh2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleType), TypeInfoPropertyName = "ChatCompletionContentPartImageWithTitleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlType), TypeInfoPropertyName = "ChatCompletionContentPartImageWithTitleCacheControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlTtl), TypeInfoPropertyName = "ChatCompletionContentPartImageWithTitleCacheControlTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartFileFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartFileWithTitle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleType), TypeInfoPropertyName = "ChatCompletionContentPartFileWithTitleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlType), TypeInfoPropertyName = "ChatCompletionContentPartFileWithTitleCacheControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlTtl), TypeInfoPropertyName = "ChatCompletionContentPartFileWithTitleCacheControlTtl2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PreprocessorId), TypeInfoPropertyName = "PreprocessorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PreprocessorIdFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PreprocessorIdFunctionType), TypeInfoPropertyName = "PreprocessorIdFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PreprocessorIdPreprocessorGlobal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PreprocessorIdPreprocessorGlobalType), TypeInfoPropertyName = "PreprocessorIdPreprocessorGlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PreprocessorIdPreprocessorGlobalFunctionType), TypeInfoPropertyName = "PreprocessorIdPreprocessorGlobalFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PreprocessorIdPreprocessorInline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PreprocessorIdPreprocessorInlineType), TypeInfoPropertyName = "PreprocessorIdPreprocessorInlineType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Acl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AclItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AclBatchUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.Acl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AclBatchUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.AclItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Agent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AutomationStatus), TypeInfoPropertyName = "AutomationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanScopeType), TypeInfoPropertyName = "SpanScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TraceScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TraceScopeType), TypeInfoPropertyName = "TraceScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GroupScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GroupScopeType), TypeInfoPropertyName = "GroupScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GroupScopePlacement), TypeInfoPropertyName = "GroupScopePlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.RetentionObjectType), TypeInfoPropertyName = "RetentionObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigEventType), TypeInfoPropertyName = "WindowedAutomationConfigEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigProductOrigin), TypeInfoPropertyName = "WindowedAutomationConfigProductOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigThreshold))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigThresholdCalculation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigThresholdCalculationType), TypeInfoPropertyName = "WindowedAutomationConfigThresholdCalculationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigThresholdCalculationOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigThresholdCalculationOutputType), TypeInfoPropertyName = "WindowedAutomationConfigThresholdCalculationOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType), TypeInfoPropertyName = "WindowedAutomationConfigThresholdPolicyConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator), TypeInfoPropertyName = "WindowedAutomationConfigThresholdPolicyConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyNoDataBehavior), TypeInfoPropertyName = "WindowedAutomationConfigThresholdPolicyNoDataBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigWindow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1, global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2>), TypeInfoPropertyName = "OneOfWindowedAutomationConfigWindowScheduleVariant1WindowedAutomationConfigWindowScheduleVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1Type), TypeInfoPropertyName = "WindowedAutomationConfigWindowScheduleVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2Type), TypeInfoPropertyName = "WindowedAutomationConfigWindowScheduleVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigLoop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigLoopHarness), TypeInfoPropertyName = "WindowedAutomationConfigLoopHarness2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigLoopReasoningEffort), TypeInfoPropertyName = "WindowedAutomationConfigLoopReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigActionVariant1, global::Braintrust.WindowedAutomationConfigActionVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigActionVariant1, global::Braintrust.WindowedAutomationConfigActionVariant2>), TypeInfoPropertyName = "OneOfWindowedAutomationConfigActionVariant1WindowedAutomationConfigActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigActionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigActionVariant1Type), TypeInfoPropertyName = "WindowedAutomationConfigActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigActionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigActionVariant2Type), TypeInfoPropertyName = "WindowedAutomationConfigActionVariant2Type2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicDigestAutomationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicDigestAutomationConfigEventType), TypeInfoPropertyName = "TopicDigestAutomationConfigEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicDigestAutomationConfigAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicDigestAutomationConfigActionType), TypeInfoPropertyName = "TopicDigestAutomationConfigActionType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant3ObjectType), TypeInfoPropertyName = "ProjectAutomationConfigVariant3ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant3Format), TypeInfoPropertyName = "ProjectAutomationConfigVariant3Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant4EventType), TypeInfoPropertyName = "ProjectAutomationConfigVariant4EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant5EventType), TypeInfoPropertyName = "ProjectAutomationConfigVariant5EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2>), TypeInfoPropertyName = "OneOfProjectAutomationConfigVariant5ActionVariant1ProjectAutomationConfigVariant5ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1Type), TypeInfoPropertyName = "ProjectAutomationConfigVariant5ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2Type), TypeInfoPropertyName = "ProjectAutomationConfigVariant5ActionVariant2Type2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant3ObjectType), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant3ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant3Format), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant3Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant4EventType), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant4EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant5EventType), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant5EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2>), TypeInfoPropertyName = "OneOfCreateProjectAutomationConfigVariant5ActionVariant1CreateProjectAutomationConfigVariant5ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1Type), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant5ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2Type), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant5ActionVariant2Type2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant3ObjectType), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant3ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant3Format), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant3Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant4EventType), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant4EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant5EventType), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant5EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2>), TypeInfoPropertyName = "OneOfPatchProjectAutomationConfigVariant5ActionVariant1PatchProjectAutomationConfigVariant5ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1Type), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant5ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2Type), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant5ActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OrgAutomation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OrgAutomationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OrgAutomationConfigEventType), TypeInfoPropertyName = "OrgAutomationConfigEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateOrgAutomation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateOrgAutomationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateOrgAutomationConfigEventType), TypeInfoPropertyName = "CreateOrgAutomationConfigEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchOrgAutomation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchOrgAutomationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchOrgAutomationConfigEventType), TypeInfoPropertyName = "PatchOrgAutomationConfigEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreCategory))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.ProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig>), TypeInfoPropertyName = "TopicDigestAutomationConfig_a53a8472277d3cbb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>), TypeInfoPropertyName = "ProjectAutomationConfigVariant2ExportDefinitionVariant3_2a6132df942795d9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.CreateProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig>), TypeInfoPropertyName = "TopicDigestAutomationConfig_881b44345301a863")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2ExportDefinitionVariant3_378e18d0da0115e9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.PatchProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig, object>), TypeInfoPropertyName = "TopicDigestAutomationConfig_object_f49eab62885d1964")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.ProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig>?), TypeInfoPropertyName = "TopicDigestAutomationConfig_58d61efe1875894e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>?), TypeInfoPropertyName = "ProjectAutomationConfigVariant2ExportDefinitionVariant3_ec6424933b017d35")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.CreateProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig>?), TypeInfoPropertyName = "TopicDigestAutomationConfig_055fe4ec45a86863")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>?), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2ExportDefinitionVariant3_c447fd26e3994f56")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2>?), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2CredentialsVariant2_4d1ae1fb74e40163")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.PatchProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig, object>?), TypeInfoPropertyName = "TopicDigestAutomationConfig_object_45351e097d855605")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3>?), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2ExportDefinitionVariant3_406398cc1ac2a868")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2>?), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2CredentialsVariant2_8e5c5ea50cba239d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer, global::Braintrust.CodeBundleLocationExperimentPositionClassifier>?), TypeInfoPropertyName = "CodeBundleLocationExperimentPositionClassifier_c4d9fe7d3ca7c609")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function, global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global>?>?), TypeInfoPropertyName = "TopicMapDataSourceFacetFunctionVariant2Global_601624aac81dbccb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>?), TypeInfoPropertyName = "PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers_2c2424cd8ae0cdf5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>>), TypeInfoPropertyName = "TopicAutomationConfigFacetFunctionVariant2Global_0de25e7b7f3aebf4")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreConditionWhen))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreConditionBehavior), TypeInfoPropertyName = "ProjectScoreConditionBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreConfigVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ProjectScoreConfigObjectType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreConfigObjectType), TypeInfoPropertyName = "ProjectScoreConfigObjectType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Braintrust.GraphEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetPreprocessorId), TypeInfoPropertyName = "FacetPreprocessorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetPreprocessorIdFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetPreprocessorIdFunctionType), TypeInfoPropertyName = "FacetPreprocessorIdFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetPreprocessorIdGlobal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetPreprocessorIdGlobalType), TypeInfoPropertyName = "FacetPreprocessorIdGlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetPreprocessorIdPreprocessorInline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetPreprocessorIdPreprocessorInlineType), TypeInfoPropertyName = "FacetPreprocessorIdPreprocessorInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetDataType), TypeInfoPropertyName = "FacetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapGenerationSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapGenerationSettingsAlgorithm), TypeInfoPropertyName = "TopicMapGenerationSettingsAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapGenerationSettingsDimensionReduction), TypeInfoPropertyName = "TopicMapGenerationSettingsDimensionReduction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapDataType), TypeInfoPropertyName = "TopicMapDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function, global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global>?>), TypeInfoPropertyName = "AllOfSavedFunctionIdAnyOfTopicMapDataSourceFacetFunctionVariant2FunctionTopicMapDataSourceFacetFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function, global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global>), TypeInfoPropertyName = "AnyOfTopicMapDataSourceFacetFunctionVariant2FunctionTopicMapDataSourceFacetFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapDataSourceFacetFunctionVariant2FunctionType), TypeInfoPropertyName = "TopicMapDataSourceFacetFunctionVariant2FunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalType), TypeInfoPropertyName = "TopicMapDataSourceFacetFunctionVariant2GlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapDataReconcileMode), TypeInfoPropertyName = "TopicMapDataReconcileMode2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType), TypeInfoPropertyName = "ViewOptionsTableViewOptionsPointSizeMetricType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.RunEvalDataDatasetId, global::Braintrust.RunEvalDataProjectDatasetName, global::Braintrust.RunEvalDataDatasetRows, global::Braintrust.RunEvalDataExperimentName>), TypeInfoPropertyName = "AnyOfRunEvalDataDatasetIdRunEvalDataProjectDatasetNameRunEvalDataDatasetRowsRunEvalDataExperimentName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.RunEvalDataDatasetId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.RunEvalDataProjectDatasetName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.RunEvalDataDatasetRows))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.RunEvalDataExperimentName))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetProjectGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ProjectGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetAclResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetProjectAutomationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.ProjectAutomation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetOrgAutomationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.OrgAutomation>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Ids?), TypeInfoPropertyName = "NullableIds2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewType?), TypeInfoPropertyName = "NullableViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.UserGivenName?), TypeInfoPropertyName = "NullableUserGivenName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.UserFamilyName?), TypeInfoPropertyName = "NullableUserFamilyName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.UserEmail?), TypeInfoPropertyName = "NullableUserEmail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AclObjectType?), TypeInfoPropertyName = "NullableAclObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AclListOrgObjectType?), TypeInfoPropertyName = "NullableAclListOrgObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AclListPermission?), TypeInfoPropertyName = "NullableAclListPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AclListRestrictObjectType?), TypeInfoPropertyName = "NullableAclListRestrictObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreType?), TypeInfoPropertyName = "NullableProjectScoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AISecretType?), TypeInfoPropertyName = "NullableAISecretType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EnvVarObjectType?), TypeInfoPropertyName = "NullableEnvVarObjectType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionTypeEnum?), TypeInfoPropertyName = "NullableFunctionTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionId?), TypeInfoPropertyName = "NullableNullableSavedFunctionId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionIdFunctionType?), TypeInfoPropertyName = "NullableNullableSavedFunctionIdFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.NullableSavedFunctionIdGlobalType?), TypeInfoPropertyName = "NullableNullableSavedFunctionIdGlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant1?, global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant2?, object>?), TypeInfoPropertyName = "NullableAnyOfProjectSettingsSpanFieldOrderItemLayoutVariant1ProjectSettingsSpanFieldOrderItemLayoutVariant2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant1?), TypeInfoPropertyName = "NullableProjectSettingsSpanFieldOrderItemLayoutVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant2?), TypeInfoPropertyName = "NullableProjectSettingsSpanFieldOrderItemLayoutVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.ProjectSettings, object>?), TypeInfoPropertyName = "NullableAllOfProjectSettingsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanType?), TypeInfoPropertyName = "NullableSpanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanAttributesPurpose?), TypeInfoPropertyName = "NullableSpanAttributesPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ObjectReferenceNullishObjectType?), TypeInfoPropertyName = "NullableObjectReferenceNullishObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectLogsEventLogId?), TypeInfoPropertyName = "NullableProjectLogsEventLogId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackResponseSchemaStatus?), TypeInfoPropertyName = "NullableFeedbackResponseSchemaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackProjectLogsItemSource?), TypeInfoPropertyName = "NullableFeedbackProjectLogsItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackExperimentItemSource?), TypeInfoPropertyName = "NullableFeedbackExperimentItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FeedbackDatasetItemSource?), TypeInfoPropertyName = "NullableFeedbackDatasetItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextType?), TypeInfoPropertyName = "NullableChatCompletionContentPartTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextCacheControlType?), TypeInfoPropertyName = "NullableChatCompletionContentPartTextCacheControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextCacheControlTtl?), TypeInfoPropertyName = "NullableChatCompletionContentPartTextCacheControlTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleType?), TypeInfoPropertyName = "NullableChatCompletionContentPartTextWithTitleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType?), TypeInfoPropertyName = "NullableChatCompletionContentPartTextWithTitleCacheControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlTtl?), TypeInfoPropertyName = "NullableChatCompletionContentPartTextWithTitleCacheControlTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?), TypeInfoPropertyName = "NullableChatCompletionContentPartImageWithTitleImageUrlDetailAuto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?), TypeInfoPropertyName = "NullableChatCompletionContentPartImageWithTitleImageUrlDetailLow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?), TypeInfoPropertyName = "NullableChatCompletionContentPartImageWithTitleImageUrlDetailHigh2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleType?), TypeInfoPropertyName = "NullableChatCompletionContentPartImageWithTitleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlType?), TypeInfoPropertyName = "NullableChatCompletionContentPartImageWithTitleCacheControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlTtl?), TypeInfoPropertyName = "NullableChatCompletionContentPartImageWithTitleCacheControlTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleType?), TypeInfoPropertyName = "NullableChatCompletionContentPartFileWithTitleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlType?), TypeInfoPropertyName = "NullableChatCompletionContentPartFileWithTitleCacheControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlTtl?), TypeInfoPropertyName = "NullableChatCompletionContentPartFileWithTitleCacheControlTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPart?), TypeInfoPropertyName = "NullableChatCompletionContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageToolCallType?), TypeInfoPropertyName = "NullableChatCompletionMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParam?), TypeInfoPropertyName = "NullableChatCompletionMessageParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>>?), TypeInfoPropertyName = "NullableAnyOfStringIListChatCompletionContentPartText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamSystemRole?), TypeInfoPropertyName = "NullableChatCompletionMessageParamSystemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPart>>?), TypeInfoPropertyName = "NullableAnyOfStringIListChatCompletionContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamUserRole?), TypeInfoPropertyName = "NullableChatCompletionMessageParamUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamAssistantRole?), TypeInfoPropertyName = "NullableChatCompletionMessageParamAssistantRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListChatCompletionContentPartTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamToolRole?), TypeInfoPropertyName = "NullableChatCompletionMessageParamToolRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamFunctionRole?), TypeInfoPropertyName = "NullableChatCompletionMessageParamFunctionRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamDeveloperRole?), TypeInfoPropertyName = "NullableChatCompletionMessageParamDeveloperRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionMessageParamFallbackRole?), TypeInfoPropertyName = "NullableChatCompletionMessageParamFallbackRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptBlockDataNullish?), TypeInfoPropertyName = "NullablePromptBlockDataNullish2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptBlockDataNullishChatType?), TypeInfoPropertyName = "NullablePromptBlockDataNullishChatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptBlockDataNullishCompletionType?), TypeInfoPropertyName = "NullablePromptBlockDataNullishCompletionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::System.Collections.Generic.Dictionary<string, object?>, string>?), TypeInfoPropertyName = "NullableAnyOfDictionaryStringObjectString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ResponseFormatNullish?), TypeInfoPropertyName = "NullableResponseFormatNullish2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ResponseFormatNullishJsonObjectType?), TypeInfoPropertyName = "NullableResponseFormatNullishJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ResponseFormatNullishJsonSchemaType?), TypeInfoPropertyName = "NullableResponseFormatNullishJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ResponseFormatNullishTextType?), TypeInfoPropertyName = "NullableResponseFormatNullishTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParams?), TypeInfoPropertyName = "NullableModelParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto?), TypeInfoPropertyName = "NullableModelParamsOpenAIModelParamsToolChoiceAuto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone?), TypeInfoPropertyName = "NullableModelParamsOpenAIModelParamsToolChoiceNone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired?), TypeInfoPropertyName = "NullableModelParamsOpenAIModelParamsToolChoiceRequired2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionType?), TypeInfoPropertyName = "NullableModelParamsOpenAIModelParamsToolChoiceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto?), TypeInfoPropertyName = "NullableModelParamsOpenAIModelParamsFunctionCallAuto2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone?), TypeInfoPropertyName = "NullableModelParamsOpenAIModelParamsFunctionCallNone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsReasoningEffort?), TypeInfoPropertyName = "NullableModelParamsOpenAIModelParamsReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ModelParamsOpenAIModelParamsVerbosity?), TypeInfoPropertyName = "NullableModelParamsOpenAIModelParamsVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptParserNullishType?), TypeInfoPropertyName = "NullablePromptParserNullishType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PreprocessorId?), TypeInfoPropertyName = "NullablePreprocessorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PreprocessorIdFunctionType?), TypeInfoPropertyName = "NullablePreprocessorIdFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PreprocessorIdPreprocessorGlobalType?), TypeInfoPropertyName = "NullablePreprocessorIdPreprocessorGlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PreprocessorIdPreprocessorGlobalFunctionType?), TypeInfoPropertyName = "NullablePreprocessorIdPreprocessorGlobalFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PreprocessorIdPreprocessorInlineType?), TypeInfoPropertyName = "NullablePreprocessorIdPreprocessorInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>?), TypeInfoPropertyName = "NullableAnyOfPromptDataNullishToolFunctionVariant2FunctionPromptDataNullishToolFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2FunctionType?), TypeInfoPropertyName = "NullablePromptDataNullishToolFunctionVariant2FunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2GlobalType?), TypeInfoPropertyName = "NullablePromptDataNullishToolFunctionVariant2GlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishTemplateFormat?), TypeInfoPropertyName = "NullablePromptDataNullishTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType?), TypeInfoPropertyName = "NullablePromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType?), TypeInfoPropertyName = "NullablePromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionTypeEnumNullish?), TypeInfoPropertyName = "NullableFunctionTypeEnumNullish2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptLogId?), TypeInfoPropertyName = "NullablePromptLogId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Permission?), TypeInfoPropertyName = "NullablePermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AutomationStatus?), TypeInfoPropertyName = "NullableAutomationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SpanScopeType?), TypeInfoPropertyName = "NullableSpanScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TraceScopeType?), TypeInfoPropertyName = "NullableTraceScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GroupScopeType?), TypeInfoPropertyName = "NullableGroupScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GroupScopePlacement?), TypeInfoPropertyName = "NullableGroupScopePlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.RetentionObjectType?), TypeInfoPropertyName = "NullableRetentionObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigEventType?), TypeInfoPropertyName = "NullableWindowedAutomationConfigEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigProductOrigin?), TypeInfoPropertyName = "NullableWindowedAutomationConfigProductOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigThresholdCalculationType?), TypeInfoPropertyName = "NullableWindowedAutomationConfigThresholdCalculationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigThresholdCalculationOutputType?), TypeInfoPropertyName = "NullableWindowedAutomationConfigThresholdCalculationOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType?), TypeInfoPropertyName = "NullableWindowedAutomationConfigThresholdPolicyConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator?), TypeInfoPropertyName = "NullableWindowedAutomationConfigThresholdPolicyConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyNoDataBehavior?), TypeInfoPropertyName = "NullableWindowedAutomationConfigThresholdPolicyNoDataBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1, global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2>?), TypeInfoPropertyName = "NullableOneOfWindowedAutomationConfigWindowScheduleVariant1WindowedAutomationConfigWindowScheduleVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1Type?), TypeInfoPropertyName = "NullableWindowedAutomationConfigWindowScheduleVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2Type?), TypeInfoPropertyName = "NullableWindowedAutomationConfigWindowScheduleVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigLoopHarness?), TypeInfoPropertyName = "NullableWindowedAutomationConfigLoopHarness2")]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.ProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig>), TypeInfoPropertyName = "TopicDigestAutomationConfig_a53a8472277d3cbb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>), TypeInfoPropertyName = "ProjectAutomationConfigVariant2ExportDefinitionVariant3_2a6132df942795d9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.CreateProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig>), TypeInfoPropertyName = "TopicDigestAutomationConfig_881b44345301a863")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2ExportDefinitionVariant3_378e18d0da0115e9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.PatchProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig, object>), TypeInfoPropertyName = "TopicDigestAutomationConfig_object_f49eab62885d1964")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.ProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig>?), TypeInfoPropertyName = "TopicDigestAutomationConfig_58d61efe1875894e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>?), TypeInfoPropertyName = "ProjectAutomationConfigVariant2ExportDefinitionVariant3_ec6424933b017d35")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.CreateProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig>?), TypeInfoPropertyName = "TopicDigestAutomationConfig_055fe4ec45a86863")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>?), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2ExportDefinitionVariant3_c447fd26e3994f56")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2>?), TypeInfoPropertyName = "CreateProjectAutomationConfigVariant2CredentialsVariant2_4d1ae1fb74e40163")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.PatchProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig, object>?), TypeInfoPropertyName = "TopicDigestAutomationConfig_object_45351e097d855605")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3>?), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2ExportDefinitionVariant3_406398cc1ac2a868")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2>?), TypeInfoPropertyName = "PatchProjectAutomationConfigVariant2CredentialsVariant2_8e5c5ea50cba239d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer, global::Braintrust.CodeBundleLocationExperimentPositionClassifier>?), TypeInfoPropertyName = "CodeBundleLocationExperimentPositionClassifier_c4d9fe7d3ca7c609")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function, global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global>?>?), TypeInfoPropertyName = "TopicMapDataSourceFacetFunctionVariant2Global_601624aac81dbccb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>?), TypeInfoPropertyName = "PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers_2c2424cd8ae0cdf5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>>), TypeInfoPropertyName = "TopicAutomationConfigFacetFunctionVariant2Global_0de25e7b7f3aebf4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigLoopReasoningEffort?), TypeInfoPropertyName = "NullableWindowedAutomationConfigLoopReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigActionVariant1, global::Braintrust.WindowedAutomationConfigActionVariant2>?), TypeInfoPropertyName = "NullableOneOfWindowedAutomationConfigActionVariant1WindowedAutomationConfigActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigActionVariant1Type?), TypeInfoPropertyName = "NullableWindowedAutomationConfigActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.WindowedAutomationConfigActionVariant2Type?), TypeInfoPropertyName = "NullableWindowedAutomationConfigActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationFacetModel?), TypeInfoPropertyName = "NullableTopicAutomationFacetModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>?), TypeInfoPropertyName = "NullableAnyOfTopicMapFunctionAutomationFunctionVariant2FunctionTopicMapFunctionAutomationFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2FunctionType?), TypeInfoPropertyName = "NullableTopicMapFunctionAutomationFunctionVariant2FunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2GlobalType?), TypeInfoPropertyName = "NullableTopicMapFunctionAutomationFunctionVariant2GlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScope?), TypeInfoPropertyName = "NullableTopicAutomationDataScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScopeVariant1Type?), TypeInfoPropertyName = "NullableTopicAutomationDataScopeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScopeVariant2Type?), TypeInfoPropertyName = "NullableTopicAutomationDataScopeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationDataScopeVariant3Type?), TypeInfoPropertyName = "NullableTopicAutomationDataScopeVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationConfigEventType?), TypeInfoPropertyName = "NullableTopicAutomationConfigEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?), TypeInfoPropertyName = "NullableAnyOfTopicAutomationConfigFacetFunctionVariant2FunctionTopicAutomationConfigFacetFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationConfigFacetFunctionVariant2FunctionType?), TypeInfoPropertyName = "NullableTopicAutomationConfigFacetFunctionVariant2FunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalType?), TypeInfoPropertyName = "NullableTopicAutomationConfigFacetFunctionVariant2GlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>?), TypeInfoPropertyName = "NullableAnyOfSpanScopeTraceScopeGroupScopeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::Braintrust.TopicAutomationConfigBackfillTimeRange, object>?), TypeInfoPropertyName = "NullableAnyOfStringTopicAutomationConfigBackfillTimeRangeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicDigestAutomationConfigEventType?), TypeInfoPropertyName = "NullableTopicDigestAutomationConfigEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicDigestAutomationConfigActionType?), TypeInfoPropertyName = "NullableTopicDigestAutomationConfigActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant1EventType?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant1EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2>?), TypeInfoPropertyName = "NullableOneOfProjectAutomationConfigVariant1ActionVariant1ProjectAutomationConfigVariant1ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1Type?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant1ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2Type?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant1ActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2EventType?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant2EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1Type?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant2ExportDefinitionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2Type?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant2ExportDefinitionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant2ExportDefinitionVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2Format?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant2Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2>?), TypeInfoPropertyName = "NullableOneOfProjectAutomationConfigVariant2CredentialsVariant1ProjectAutomationConfigVariant2CredentialsVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1Type?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant2CredentialsVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2Type?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant2CredentialsVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant3EventType?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant3EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant3ObjectType?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant3ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant3Format?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant3Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant4EventType?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant4EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant5EventType?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant5EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2>?), TypeInfoPropertyName = "NullableOneOfProjectAutomationConfigVariant5ActionVariant1ProjectAutomationConfigVariant5ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1Type?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant5ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2Type?), TypeInfoPropertyName = "NullableProjectAutomationConfigVariant5ActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant1EventType?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant1EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2>?), TypeInfoPropertyName = "NullableOneOfCreateProjectAutomationConfigVariant1ActionVariant1CreateProjectAutomationConfigVariant1ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1Type?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant1ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2Type?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant1ActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2EventType?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant2EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2Format?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant2Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1Type?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant2CredentialsVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2Type?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant2CredentialsVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant3EventType?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant3EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant3ObjectType?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant3ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant3Format?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant3Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant4EventType?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant4EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant5EventType?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant5EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2>?), TypeInfoPropertyName = "NullableOneOfCreateProjectAutomationConfigVariant5ActionVariant1CreateProjectAutomationConfigVariant5ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1Type?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant5ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2Type?), TypeInfoPropertyName = "NullableCreateProjectAutomationConfigVariant5ActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant1EventType?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant1EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2>?), TypeInfoPropertyName = "NullableOneOfPatchProjectAutomationConfigVariant1ActionVariant1PatchProjectAutomationConfigVariant1ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1Type?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant1ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2Type?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant1ActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2EventType?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant2EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2Format?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant2Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1Type?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant2CredentialsVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2Type?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant2CredentialsVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant3EventType?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant3EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant3ObjectType?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant3ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant3Format?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant3Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant4EventType?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant4EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant5EventType?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant5EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2>?), TypeInfoPropertyName = "NullableOneOfPatchProjectAutomationConfigVariant5ActionVariant1PatchProjectAutomationConfigVariant5ActionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1Type?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant5ActionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2Type?), TypeInfoPropertyName = "NullablePatchProjectAutomationConfigVariant5ActionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OrgAutomationConfigEventType?), TypeInfoPropertyName = "NullableOrgAutomationConfigEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateOrgAutomationConfigEventType?), TypeInfoPropertyName = "NullableCreateOrgAutomationConfigEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchOrgAutomationConfigEventType?), TypeInfoPropertyName = "NullablePatchOrgAutomationConfigEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreCategories?), TypeInfoPropertyName = "NullableProjectScoreCategories2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>?), TypeInfoPropertyName = "NullableAllOfSavedFunctionIdAnyOfOnlineScoreConfigScorerVariant2FunctionOnlineScoreConfigScorerVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?), TypeInfoPropertyName = "NullableAnyOfOnlineScoreConfigScorerVariant2FunctionOnlineScoreConfigScorerVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType?), TypeInfoPropertyName = "NullableOnlineScoreConfigScorerVariant2FunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType?), TypeInfoPropertyName = "NullableOnlineScoreConfigScorerVariant2GlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreConditionBehavior?), TypeInfoPropertyName = "NullableProjectScoreConditionBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ProjectScoreConfigObjectType?), TypeInfoPropertyName = "NullableProjectScoreConfigObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleRuntimeContextRuntime?), TypeInfoPropertyName = "NullableCodeBundleRuntimeContextRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperiment, global::Braintrust.CodeBundleLocationFunction, global::Braintrust.CodeBundleLocationVariant3>?), TypeInfoPropertyName = "NullableAnyOfCodeBundleLocationExperimentCodeBundleLocationFunctionCodeBundleLocationVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperimentType?), TypeInfoPropertyName = "NullableCodeBundleLocationExperimentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperimentPositionVariant1Type?), TypeInfoPropertyName = "NullableCodeBundleLocationExperimentPositionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperimentPositionScorerType?), TypeInfoPropertyName = "NullableCodeBundleLocationExperimentPositionScorerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationExperimentPositionClassifierType?), TypeInfoPropertyName = "NullableCodeBundleLocationExperimentPositionClassifierType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationFunctionType?), TypeInfoPropertyName = "NullableCodeBundleLocationFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationVariant3Type?), TypeInfoPropertyName = "NullableCodeBundleLocationVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1, global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2>?), TypeInfoPropertyName = "NullableOneOfCodeBundleLocationVariant3SandboxSpecVariant1CodeBundleLocationVariant3SandboxSpecVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1Provider?), TypeInfoPropertyName = "NullableCodeBundleLocationVariant3SandboxSpecVariant1Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2Provider?), TypeInfoPropertyName = "NullableCodeBundleLocationVariant3SandboxSpecVariant2Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptBlockData?), TypeInfoPropertyName = "NullablePromptBlockData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptBlockDataChatType?), TypeInfoPropertyName = "NullablePromptBlockDataChatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptBlockDataCompletionType?), TypeInfoPropertyName = "NullablePromptBlockDataCompletionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNode?), TypeInfoPropertyName = "NullableGraphNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant1Type?), TypeInfoPropertyName = "NullableGraphNodeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant2Type?), TypeInfoPropertyName = "NullableGraphNodeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant3Type?), TypeInfoPropertyName = "NullableGraphNodeVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant4Type?), TypeInfoPropertyName = "NullableGraphNodeVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant5Type?), TypeInfoPropertyName = "NullableGraphNodeVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant6Type?), TypeInfoPropertyName = "NullableGraphNodeVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant7Type?), TypeInfoPropertyName = "NullableGraphNodeVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphNodeVariant8Type?), TypeInfoPropertyName = "NullableGraphNodeVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphEdgePurpose?), TypeInfoPropertyName = "NullableGraphEdgePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GraphDataType?), TypeInfoPropertyName = "NullableGraphDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetPreprocessorId?), TypeInfoPropertyName = "NullableFacetPreprocessorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetPreprocessorIdFunctionType?), TypeInfoPropertyName = "NullableFacetPreprocessorIdFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetPreprocessorIdGlobalType?), TypeInfoPropertyName = "NullableFacetPreprocessorIdGlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetPreprocessorIdPreprocessorInlineType?), TypeInfoPropertyName = "NullableFacetPreprocessorIdPreprocessorInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FacetDataType?), TypeInfoPropertyName = "NullableFacetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapGenerationSettingsAlgorithm?), TypeInfoPropertyName = "NullableTopicMapGenerationSettingsAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapGenerationSettingsDimensionReduction?), TypeInfoPropertyName = "NullableTopicMapGenerationSettingsDimensionReduction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapDataType?), TypeInfoPropertyName = "NullableTopicMapDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function, global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global>?), TypeInfoPropertyName = "NullableAnyOfTopicMapDataSourceFacetFunctionVariant2FunctionTopicMapDataSourceFacetFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapDataSourceFacetFunctionVariant2FunctionType?), TypeInfoPropertyName = "NullableTopicMapDataSourceFacetFunctionVariant2FunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalType?), TypeInfoPropertyName = "NullableTopicMapDataSourceFacetFunctionVariant2GlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.TopicMapDataReconcileMode?), TypeInfoPropertyName = "NullableTopicMapDataReconcileMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.BatchedFacetDataType?), TypeInfoPropertyName = "NullableBatchedFacetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionData?), TypeInfoPropertyName = "NullableFunctionData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataPromptType?), TypeInfoPropertyName = "NullableFunctionDataPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataCodeType?), TypeInfoPropertyName = "NullableFunctionDataCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataCodeData2>?), TypeInfoPropertyName = "NullableAnyOfAllOfFunctionDataCodeDataCodeBundleFunctionDataCodeData22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>?), TypeInfoPropertyName = "NullableAllOfFunctionDataCodeDataCodeBundle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataCodeDataType?), TypeInfoPropertyName = "NullableFunctionDataCodeDataType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataCodeDataType2?), TypeInfoPropertyName = "NullableFunctionDataCodeDataType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataCodeDataRuntimeContextRuntime?), TypeInfoPropertyName = "NullableFunctionDataCodeDataRuntimeContextRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataRemoteEvalType?), TypeInfoPropertyName = "NullableFunctionDataRemoteEvalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataGlobalType?), TypeInfoPropertyName = "NullableFunctionDataGlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataParametersType?), TypeInfoPropertyName = "NullableFunctionDataParametersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataParametersSchemaType?), TypeInfoPropertyName = "NullableFunctionDataParametersSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>?), TypeInfoPropertyName = "NullableAllOfTopicMapDataObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionLogId?), TypeInfoPropertyName = "NullableFunctionLogId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullish?), TypeInfoPropertyName = "NullableFunctionDataNullish2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishPromptType?), TypeInfoPropertyName = "NullableFunctionDataNullishPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishCodeType?), TypeInfoPropertyName = "NullableFunctionDataNullishCodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataNullishCodeData2>?), TypeInfoPropertyName = "NullableAnyOfAllOfFunctionDataNullishCodeDataCodeBundleFunctionDataNullishCodeData22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>?), TypeInfoPropertyName = "NullableAllOfFunctionDataNullishCodeDataCodeBundle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishCodeDataType?), TypeInfoPropertyName = "NullableFunctionDataNullishCodeDataType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishCodeDataType2?), TypeInfoPropertyName = "NullableFunctionDataNullishCodeDataType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishCodeDataRuntimeContextRuntime?), TypeInfoPropertyName = "NullableFunctionDataNullishCodeDataRuntimeContextRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishRemoteEvalType?), TypeInfoPropertyName = "NullableFunctionDataNullishRemoteEvalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishGlobalType?), TypeInfoPropertyName = "NullableFunctionDataNullishGlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishParametersType?), TypeInfoPropertyName = "NullableFunctionDataNullishParametersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionDataNullishParametersSchemaType?), TypeInfoPropertyName = "NullableFunctionDataNullishParametersSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InvokeParent?), TypeInfoPropertyName = "NullableInvokeParent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.InvokeParentSpanParentStructObjectType?), TypeInfoPropertyName = "NullableInvokeParentSpanParentStructObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.StreamingMode?), TypeInfoPropertyName = "NullableStreamingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptions?), TypeInfoPropertyName = "NullableViewOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsMonitorViewOptionsViewType?), TypeInfoPropertyName = "NullableViewOptionsMonitorViewOptionsViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType?), TypeInfoPropertyName = "NullableViewOptionsMonitorViewOptionsOptionsSpanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType?), TypeInfoPropertyName = "NullableViewOptionsMonitorViewOptionsOptionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType?), TypeInfoPropertyName = "NullableViewOptionsTableViewOptionsExcludedMeasureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsYMetricType?), TypeInfoPropertyName = "NullableViewOptionsTableViewOptionsYMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsXAxisType?), TypeInfoPropertyName = "NullableViewOptionsTableViewOptionsXAxisType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType?), TypeInfoPropertyName = "NullableViewOptionsTableViewOptionsSymbolGroupingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType?), TypeInfoPropertyName = "NullableViewOptionsTableViewOptionsPointSizeMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter, object>?), TypeInfoPropertyName = "NullableAnyOfStringViewOptionsTableViewOptionsTimeRangeFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewOptionsTableViewOptionsQueryShape?), TypeInfoPropertyName = "NullableViewOptionsTableViewOptionsQueryShape2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ViewViewType?), TypeInfoPropertyName = "NullableViewViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.CreateViewViewType?), TypeInfoPropertyName = "NullableCreateViewViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchViewViewType?), TypeInfoPropertyName = "NullablePatchViewViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ImageRenderingMode?), TypeInfoPropertyName = "NullableImageRenderingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PatchOrganizationMembersOutputStatus?), TypeInfoPropertyName = "NullablePatchOrganizationMembersOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EnvVarObjectType2?), TypeInfoPropertyName = "NullableEnvVarObjectType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.EnvVarSecretCategory?), TypeInfoPropertyName = "NullableEnvVarSecretCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>?), TypeInfoPropertyName = "NullableAllOfSavedFunctionIdAnyOfPromptDataToolFunctionVariant2FunctionPromptDataToolFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?), TypeInfoPropertyName = "NullableAnyOfPromptDataToolFunctionVariant2FunctionPromptDataToolFunctionVariant2Global2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataToolFunctionVariant2FunctionType?), TypeInfoPropertyName = "NullablePromptDataToolFunctionVariant2FunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataToolFunctionVariant2GlobalType?), TypeInfoPropertyName = "NullablePromptDataToolFunctionVariant2GlobalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataTemplateFormat?), TypeInfoPropertyName = "NullablePromptDataTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType?), TypeInfoPropertyName = "NullablePromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType?), TypeInfoPropertyName = "NullablePromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionId?), TypeInfoPropertyName = "NullableFunctionId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionIdInlineCodeInlineContextRuntime?), TypeInfoPropertyName = "NullableFunctionIdInlineCodeInlineContextRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.FunctionTypeEnum?, object>?), TypeInfoPropertyName = "NullableAllOfFunctionTypeEnumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GitMetadataSettingsCollect?), TypeInfoPropertyName = "NullableGitMetadataSettingsCollect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GitMetadataSettingsField?), TypeInfoPropertyName = "NullableGitMetadataSettingsField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.RunEvalDataDatasetId, global::Braintrust.RunEvalDataProjectDatasetName, global::Braintrust.RunEvalDataDatasetRows, global::Braintrust.RunEvalDataExperimentName>?), TypeInfoPropertyName = "NullableAnyOfRunEvalDataDatasetIdRunEvalDataProjectDatasetNameRunEvalDataDatasetRowsRunEvalDataExperimentName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>?), TypeInfoPropertyName = "NullableAllOfFunctionIdObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.InvokeParent?, object>?), TypeInfoPropertyName = "NullableAllOfInvokeParentObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.RepoInfo, object>?), TypeInfoPropertyName = "NullableAllOfRepoInfoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PostEnvVarRequestObjectType?), TypeInfoPropertyName = "NullablePostEnvVarRequestObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.PutEnvVarRequestObjectType?), TypeInfoPropertyName = "NullablePutEnvVarRequestObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>?), TypeInfoPropertyName = "NullableAnyOfProjectScoreTypeIListAllOfProjectScoreTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>?), TypeInfoPropertyName = "NullableAllOfProjectScoreTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>?), TypeInfoPropertyName = "NullableAnyOfGuidIListGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectSettingsSpanFieldOrderItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectSettingsRemoteEvalSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.InsertProjectLogsEventArrayDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object?>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigActionVariant1, global::Braintrust.WindowedAutomationConfigActionVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.TopicMapFunctionAutomation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectScoreCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectScoreConfigObjectType>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ProjectAutomation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.OrgAutomation>))]
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
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

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
            options.Converters.Add(new global::Braintrust.JsonConverters.PreprocessorIdJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.TopicAutomationDataScopeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ProjectScoreCategoriesJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptBlockDataJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.GraphNodeJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.FacetPreprocessorIdJsonConverter());
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
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1, global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.WindowedAutomationConfigActionVariant1, global::Braintrust.WindowedAutomationConfigActionVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>?>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::Braintrust.TopicAutomationConfigBackfillTimeRange, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant1, global::Braintrust.ProjectAutomationConfigVariant2, global::Braintrust.ProjectAutomationConfigVariant3, global::Braintrust.ProjectAutomationConfigVariant4, global::Braintrust.ProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2, global::Braintrust.CreateProjectAutomationConfigVariant3, global::Braintrust.CreateProjectAutomationConfigVariant4, global::Braintrust.CreateProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2, global::Braintrust.PatchProjectAutomationConfigVariant3, global::Braintrust.PatchProjectAutomationConfigVariant4, global::Braintrust.PatchProjectAutomationConfigVariant5, global::Braintrust.WindowedAutomationConfig, global::Braintrust.TopicAutomationConfig, global::Braintrust.TopicDigestAutomationConfig, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2, global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.CodeBundleLocationExperiment, global::Braintrust.CodeBundleLocationFunction, global::Braintrust.CodeBundleLocationVariant3>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer, global::Braintrust.CodeBundleLocationExperimentPositionClassifier>());
            options.Converters.Add(new global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1, global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function, global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global>?>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function, global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global>());
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
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.RunEvalDataDatasetId, global::Braintrust.RunEvalDataProjectDatasetName, global::Braintrust.RunEvalDataDatasetRows, global::Braintrust.RunEvalDataExperimentName>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionId?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.InvokeParent?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.RepoInfo, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.ProjectScoreType?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::Braintrust.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Braintrust.ViewType)

                    || typeToConvert == typeof(global::Braintrust.ViewType?)

                    || typeToConvert == typeof(global::Braintrust.AclObjectType)

                    || typeToConvert == typeof(global::Braintrust.AclObjectType?)

                    || typeToConvert == typeof(global::Braintrust.AclListOrgObjectType)

                    || typeToConvert == typeof(global::Braintrust.AclListOrgObjectType?)

                    || typeToConvert == typeof(global::Braintrust.AclListPermission)

                    || typeToConvert == typeof(global::Braintrust.AclListPermission?)

                    || typeToConvert == typeof(global::Braintrust.AclListRestrictObjectType)

                    || typeToConvert == typeof(global::Braintrust.AclListRestrictObjectType?)

                    || typeToConvert == typeof(global::Braintrust.ProjectScoreType)

                    || typeToConvert == typeof(global::Braintrust.ProjectScoreType?)

                    || typeToConvert == typeof(global::Braintrust.EnvVarObjectType)

                    || typeToConvert == typeof(global::Braintrust.EnvVarObjectType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionTypeEnum)

                    || typeToConvert == typeof(global::Braintrust.FunctionTypeEnum?)

                    || typeToConvert == typeof(global::Braintrust.NullableSavedFunctionIdFunctionType)

                    || typeToConvert == typeof(global::Braintrust.NullableSavedFunctionIdFunctionType?)

                    || typeToConvert == typeof(global::Braintrust.NullableSavedFunctionIdGlobalType)

                    || typeToConvert == typeof(global::Braintrust.NullableSavedFunctionIdGlobalType?)

                    || typeToConvert == typeof(global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant1)

                    || typeToConvert == typeof(global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant1?)

                    || typeToConvert == typeof(global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant2)

                    || typeToConvert == typeof(global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant2?)

                    || typeToConvert == typeof(global::Braintrust.SpanType)

                    || typeToConvert == typeof(global::Braintrust.SpanType?)

                    || typeToConvert == typeof(global::Braintrust.SpanAttributesPurpose)

                    || typeToConvert == typeof(global::Braintrust.SpanAttributesPurpose?)

                    || typeToConvert == typeof(global::Braintrust.ObjectReferenceNullishObjectType)

                    || typeToConvert == typeof(global::Braintrust.ObjectReferenceNullishObjectType?)

                    || typeToConvert == typeof(global::Braintrust.SavedFunctionIdFunctionType)

                    || typeToConvert == typeof(global::Braintrust.SavedFunctionIdFunctionType?)

                    || typeToConvert == typeof(global::Braintrust.SavedFunctionIdGlobalType)

                    || typeToConvert == typeof(global::Braintrust.SavedFunctionIdGlobalType?)

                    || typeToConvert == typeof(global::Braintrust.ProjectLogsEventLogId)

                    || typeToConvert == typeof(global::Braintrust.ProjectLogsEventLogId?)

                    || typeToConvert == typeof(global::Braintrust.FeedbackResponseSchemaStatus)

                    || typeToConvert == typeof(global::Braintrust.FeedbackResponseSchemaStatus?)

                    || typeToConvert == typeof(global::Braintrust.FeedbackProjectLogsItemSource)

                    || typeToConvert == typeof(global::Braintrust.FeedbackProjectLogsItemSource?)

                    || typeToConvert == typeof(global::Braintrust.FeedbackExperimentItemSource)

                    || typeToConvert == typeof(global::Braintrust.FeedbackExperimentItemSource?)

                    || typeToConvert == typeof(global::Braintrust.FeedbackDatasetItemSource)

                    || typeToConvert == typeof(global::Braintrust.FeedbackDatasetItemSource?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextType)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextType?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextCacheControlType)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextCacheControlType?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextCacheControlTtl)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextCacheControlTtl?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleType)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleType?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlTtl)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlTtl?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleType)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleType?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlType)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlType?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlTtl)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlTtl?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleType)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleType?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlType)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlType?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlTtl)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlTtl?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionMessageToolCallType)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionMessageToolCallType?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamSystemRole)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamSystemRole?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamUserRole)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamUserRole?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamAssistantRole)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamAssistantRole?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamToolRole)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamToolRole?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamFunctionRole)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamFunctionRole?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamDeveloperRole)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamDeveloperRole?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamFallbackRole)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamFallbackRole?)

                    || typeToConvert == typeof(global::Braintrust.PromptBlockDataNullishChatType)

                    || typeToConvert == typeof(global::Braintrust.PromptBlockDataNullishChatType?)

                    || typeToConvert == typeof(global::Braintrust.PromptBlockDataNullishCompletionType)

                    || typeToConvert == typeof(global::Braintrust.PromptBlockDataNullishCompletionType?)

                    || typeToConvert == typeof(global::Braintrust.ResponseFormatNullishJsonObjectType)

                    || typeToConvert == typeof(global::Braintrust.ResponseFormatNullishJsonObjectType?)

                    || typeToConvert == typeof(global::Braintrust.ResponseFormatNullishJsonSchemaType)

                    || typeToConvert == typeof(global::Braintrust.ResponseFormatNullishJsonSchemaType?)

                    || typeToConvert == typeof(global::Braintrust.ResponseFormatNullishTextType)

                    || typeToConvert == typeof(global::Braintrust.ResponseFormatNullishTextType?)

                    || typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto)

                    || typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto?)

                    || typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone)

                    || typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone?)

                    || typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired)

                    || typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired?)

                    || typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionType)

                    || typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionType?)

                    || typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto)

                    || typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto?)

                    || typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone)

                    || typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone?)

                    || typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsReasoningEffort)

                    || typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsReasoningEffort?)

                    || typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsVerbosity)

                    || typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsVerbosity?)

                    || typeToConvert == typeof(global::Braintrust.PromptParserNullishType)

                    || typeToConvert == typeof(global::Braintrust.PromptParserNullishType?)

                    || typeToConvert == typeof(global::Braintrust.PreprocessorIdFunctionType)

                    || typeToConvert == typeof(global::Braintrust.PreprocessorIdFunctionType?)

                    || typeToConvert == typeof(global::Braintrust.PreprocessorIdPreprocessorGlobalType)

                    || typeToConvert == typeof(global::Braintrust.PreprocessorIdPreprocessorGlobalType?)

                    || typeToConvert == typeof(global::Braintrust.PreprocessorIdPreprocessorGlobalFunctionType)

                    || typeToConvert == typeof(global::Braintrust.PreprocessorIdPreprocessorGlobalFunctionType?)

                    || typeToConvert == typeof(global::Braintrust.PreprocessorIdPreprocessorInlineType)

                    || typeToConvert == typeof(global::Braintrust.PreprocessorIdPreprocessorInlineType?)

                    || typeToConvert == typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2FunctionType)

                    || typeToConvert == typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2FunctionType?)

                    || typeToConvert == typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2GlobalType)

                    || typeToConvert == typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2GlobalType?)

                    || typeToConvert == typeof(global::Braintrust.PromptDataNullishTemplateFormat)

                    || typeToConvert == typeof(global::Braintrust.PromptDataNullishTemplateFormat?)

                    || typeToConvert == typeof(global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType)

                    || typeToConvert == typeof(global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType?)

                    || typeToConvert == typeof(global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType)

                    || typeToConvert == typeof(global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionTypeEnumNullish)

                    || typeToConvert == typeof(global::Braintrust.FunctionTypeEnumNullish?)

                    || typeToConvert == typeof(global::Braintrust.PromptLogId)

                    || typeToConvert == typeof(global::Braintrust.PromptLogId?)

                    || typeToConvert == typeof(global::Braintrust.Permission)

                    || typeToConvert == typeof(global::Braintrust.Permission?)

                    || typeToConvert == typeof(global::Braintrust.AutomationStatus)

                    || typeToConvert == typeof(global::Braintrust.AutomationStatus?)

                    || typeToConvert == typeof(global::Braintrust.SpanScopeType)

                    || typeToConvert == typeof(global::Braintrust.SpanScopeType?)

                    || typeToConvert == typeof(global::Braintrust.TraceScopeType)

                    || typeToConvert == typeof(global::Braintrust.TraceScopeType?)

                    || typeToConvert == typeof(global::Braintrust.GroupScopeType)

                    || typeToConvert == typeof(global::Braintrust.GroupScopeType?)

                    || typeToConvert == typeof(global::Braintrust.GroupScopePlacement)

                    || typeToConvert == typeof(global::Braintrust.GroupScopePlacement?)

                    || typeToConvert == typeof(global::Braintrust.RetentionObjectType)

                    || typeToConvert == typeof(global::Braintrust.RetentionObjectType?)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigEventType)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigEventType?)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigProductOrigin)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigProductOrigin?)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdCalculationType)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdCalculationType?)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdCalculationOutputType)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdCalculationOutputType?)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType?)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator?)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyNoDataBehavior)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyNoDataBehavior?)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2Type)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2Type?)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigLoopHarness)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigLoopHarness?)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigLoopReasoningEffort)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigLoopReasoningEffort?)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigActionVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigActionVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigActionVariant2Type)

                    || typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigActionVariant2Type?)

                    || typeToConvert == typeof(global::Braintrust.TopicAutomationFacetModel)

                    || typeToConvert == typeof(global::Braintrust.TopicAutomationFacetModel?)

                    || typeToConvert == typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2FunctionType)

                    || typeToConvert == typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2FunctionType?)

                    || typeToConvert == typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2GlobalType)

                    || typeToConvert == typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2GlobalType?)

                    || typeToConvert == typeof(global::Braintrust.TopicAutomationDataScopeVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.TopicAutomationDataScopeVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.TopicAutomationDataScopeVariant2Type)

                    || typeToConvert == typeof(global::Braintrust.TopicAutomationDataScopeVariant2Type?)

                    || typeToConvert == typeof(global::Braintrust.TopicAutomationDataScopeVariant3Type)

                    || typeToConvert == typeof(global::Braintrust.TopicAutomationDataScopeVariant3Type?)

                    || typeToConvert == typeof(global::Braintrust.TopicAutomationConfigEventType)

                    || typeToConvert == typeof(global::Braintrust.TopicAutomationConfigEventType?)

                    || typeToConvert == typeof(global::Braintrust.TopicAutomationConfigFacetFunctionVariant2FunctionType)

                    || typeToConvert == typeof(global::Braintrust.TopicAutomationConfigFacetFunctionVariant2FunctionType?)

                    || typeToConvert == typeof(global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalType)

                    || typeToConvert == typeof(global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalType?)

                    || typeToConvert == typeof(global::Braintrust.TopicDigestAutomationConfigEventType)

                    || typeToConvert == typeof(global::Braintrust.TopicDigestAutomationConfigEventType?)

                    || typeToConvert == typeof(global::Braintrust.TopicDigestAutomationConfigActionType)

                    || typeToConvert == typeof(global::Braintrust.TopicDigestAutomationConfigActionType?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant1EventType)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant1EventType?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2Type)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2Type?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2EventType)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2EventType?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2Type)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2Type?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2Format)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2Format?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2Type)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2Type?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant3EventType)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant3EventType?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant3ObjectType)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant3ObjectType?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant3Format)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant3Format?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant4EventType)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant4EventType?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant5EventType)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant5EventType?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2Type)

                    || typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2Type?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant1EventType)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant1EventType?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2Type)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2Type?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2EventType)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2EventType?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2Format)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2Format?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2Type)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2Type?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant3EventType)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant3EventType?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant3ObjectType)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant3ObjectType?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant3Format)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant3Format?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant4EventType)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant4EventType?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant5EventType)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant5EventType?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2Type)

                    || typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2Type?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant1EventType)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant1EventType?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2Type)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2Type?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2EventType)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2EventType?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2Format)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2Format?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2Type)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2Type?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant3EventType)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant3EventType?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant3ObjectType)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant3ObjectType?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant3Format)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant3Format?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant4EventType)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant4EventType?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant5EventType)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant5EventType?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2Type)

                    || typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2Type?)

                    || typeToConvert == typeof(global::Braintrust.OrgAutomationConfigEventType)

                    || typeToConvert == typeof(global::Braintrust.OrgAutomationConfigEventType?)

                    || typeToConvert == typeof(global::Braintrust.CreateOrgAutomationConfigEventType)

                    || typeToConvert == typeof(global::Braintrust.CreateOrgAutomationConfigEventType?)

                    || typeToConvert == typeof(global::Braintrust.PatchOrgAutomationConfigEventType)

                    || typeToConvert == typeof(global::Braintrust.PatchOrgAutomationConfigEventType?)

                    || typeToConvert == typeof(global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType)

                    || typeToConvert == typeof(global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType?)

                    || typeToConvert == typeof(global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType)

                    || typeToConvert == typeof(global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType?)

                    || typeToConvert == typeof(global::Braintrust.ProjectScoreConditionBehavior)

                    || typeToConvert == typeof(global::Braintrust.ProjectScoreConditionBehavior?)

                    || typeToConvert == typeof(global::Braintrust.ProjectScoreConfigObjectType)

                    || typeToConvert == typeof(global::Braintrust.ProjectScoreConfigObjectType?)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleRuntimeContextRuntime)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleRuntimeContextRuntime?)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleLocationExperimentType)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleLocationExperimentType?)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleLocationExperimentPositionVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleLocationExperimentPositionVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleLocationExperimentPositionScorerType)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleLocationExperimentPositionScorerType?)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleLocationExperimentPositionClassifierType)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleLocationExperimentPositionClassifierType?)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleLocationFunctionType)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleLocationFunctionType?)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleLocationVariant3Type)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleLocationVariant3Type?)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1Provider)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1Provider?)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2Provider)

                    || typeToConvert == typeof(global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2Provider?)

                    || typeToConvert == typeof(global::Braintrust.PromptBlockDataChatType)

                    || typeToConvert == typeof(global::Braintrust.PromptBlockDataChatType?)

                    || typeToConvert == typeof(global::Braintrust.PromptBlockDataCompletionType)

                    || typeToConvert == typeof(global::Braintrust.PromptBlockDataCompletionType?)

                    || typeToConvert == typeof(global::Braintrust.GraphNodeVariant1Type)

                    || typeToConvert == typeof(global::Braintrust.GraphNodeVariant1Type?)

                    || typeToConvert == typeof(global::Braintrust.GraphNodeVariant2Type)

                    || typeToConvert == typeof(global::Braintrust.GraphNodeVariant2Type?)

                    || typeToConvert == typeof(global::Braintrust.GraphNodeVariant3Type)

                    || typeToConvert == typeof(global::Braintrust.GraphNodeVariant3Type?)

                    || typeToConvert == typeof(global::Braintrust.GraphNodeVariant4Type)

                    || typeToConvert == typeof(global::Braintrust.GraphNodeVariant4Type?)

                    || typeToConvert == typeof(global::Braintrust.GraphNodeVariant5Type)

                    || typeToConvert == typeof(global::Braintrust.GraphNodeVariant5Type?)

                    || typeToConvert == typeof(global::Braintrust.GraphNodeVariant6Type)

                    || typeToConvert == typeof(global::Braintrust.GraphNodeVariant6Type?)

                    || typeToConvert == typeof(global::Braintrust.GraphNodeVariant7Type)

                    || typeToConvert == typeof(global::Braintrust.GraphNodeVariant7Type?)

                    || typeToConvert == typeof(global::Braintrust.GraphNodeVariant8Type)

                    || typeToConvert == typeof(global::Braintrust.GraphNodeVariant8Type?)

                    || typeToConvert == typeof(global::Braintrust.GraphEdgePurpose)

                    || typeToConvert == typeof(global::Braintrust.GraphEdgePurpose?)

                    || typeToConvert == typeof(global::Braintrust.GraphDataType)

                    || typeToConvert == typeof(global::Braintrust.GraphDataType?)

                    || typeToConvert == typeof(global::Braintrust.FacetPreprocessorIdFunctionType)

                    || typeToConvert == typeof(global::Braintrust.FacetPreprocessorIdFunctionType?)

                    || typeToConvert == typeof(global::Braintrust.FacetPreprocessorIdGlobalType)

                    || typeToConvert == typeof(global::Braintrust.FacetPreprocessorIdGlobalType?)

                    || typeToConvert == typeof(global::Braintrust.FacetPreprocessorIdPreprocessorInlineType)

                    || typeToConvert == typeof(global::Braintrust.FacetPreprocessorIdPreprocessorInlineType?)

                    || typeToConvert == typeof(global::Braintrust.FacetDataType)

                    || typeToConvert == typeof(global::Braintrust.FacetDataType?)

                    || typeToConvert == typeof(global::Braintrust.TopicMapGenerationSettingsAlgorithm)

                    || typeToConvert == typeof(global::Braintrust.TopicMapGenerationSettingsAlgorithm?)

                    || typeToConvert == typeof(global::Braintrust.TopicMapGenerationSettingsDimensionReduction)

                    || typeToConvert == typeof(global::Braintrust.TopicMapGenerationSettingsDimensionReduction?)

                    || typeToConvert == typeof(global::Braintrust.TopicMapDataType)

                    || typeToConvert == typeof(global::Braintrust.TopicMapDataType?)

                    || typeToConvert == typeof(global::Braintrust.TopicMapDataSourceFacetFunctionVariant2FunctionType)

                    || typeToConvert == typeof(global::Braintrust.TopicMapDataSourceFacetFunctionVariant2FunctionType?)

                    || typeToConvert == typeof(global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalType)

                    || typeToConvert == typeof(global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalType?)

                    || typeToConvert == typeof(global::Braintrust.TopicMapDataReconcileMode)

                    || typeToConvert == typeof(global::Braintrust.TopicMapDataReconcileMode?)

                    || typeToConvert == typeof(global::Braintrust.BatchedFacetDataType)

                    || typeToConvert == typeof(global::Braintrust.BatchedFacetDataType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataPromptType)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataPromptType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataCodeType)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataCodeType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataCodeDataType)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataCodeDataType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataCodeDataType2)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataCodeDataType2?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataCodeDataRuntimeContextRuntime)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataCodeDataRuntimeContextRuntime?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataRemoteEvalType)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataRemoteEvalType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataGlobalType)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataGlobalType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataParametersType)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataParametersType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataParametersSchemaType)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataParametersSchemaType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionLogId)

                    || typeToConvert == typeof(global::Braintrust.FunctionLogId?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishPromptType)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishPromptType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishCodeType)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishCodeType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishCodeDataType)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishCodeDataType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishCodeDataType2)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishCodeDataType2?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishCodeDataRuntimeContextRuntime)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishCodeDataRuntimeContextRuntime?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishRemoteEvalType)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishRemoteEvalType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishGlobalType)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishGlobalType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishParametersType)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishParametersType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishParametersSchemaType)

                    || typeToConvert == typeof(global::Braintrust.FunctionDataNullishParametersSchemaType?)

                    || typeToConvert == typeof(global::Braintrust.InvokeParentSpanParentStructObjectType)

                    || typeToConvert == typeof(global::Braintrust.InvokeParentSpanParentStructObjectType?)

                    || typeToConvert == typeof(global::Braintrust.StreamingMode)

                    || typeToConvert == typeof(global::Braintrust.StreamingMode?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsViewType)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsViewType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsYMetricType)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsYMetricType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsXAxisType)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsXAxisType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType?)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsQueryShape)

                    || typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsQueryShape?)

                    || typeToConvert == typeof(global::Braintrust.ViewViewType)

                    || typeToConvert == typeof(global::Braintrust.ViewViewType?)

                    || typeToConvert == typeof(global::Braintrust.CreateViewViewType)

                    || typeToConvert == typeof(global::Braintrust.CreateViewViewType?)

                    || typeToConvert == typeof(global::Braintrust.PatchViewViewType)

                    || typeToConvert == typeof(global::Braintrust.PatchViewViewType?)

                    || typeToConvert == typeof(global::Braintrust.ImageRenderingMode)

                    || typeToConvert == typeof(global::Braintrust.ImageRenderingMode?)

                    || typeToConvert == typeof(global::Braintrust.PatchOrganizationMembersOutputStatus)

                    || typeToConvert == typeof(global::Braintrust.PatchOrganizationMembersOutputStatus?)

                    || typeToConvert == typeof(global::Braintrust.EnvVarObjectType2)

                    || typeToConvert == typeof(global::Braintrust.EnvVarObjectType2?)

                    || typeToConvert == typeof(global::Braintrust.EnvVarSecretCategory)

                    || typeToConvert == typeof(global::Braintrust.EnvVarSecretCategory?)

                    || typeToConvert == typeof(global::Braintrust.PromptDataToolFunctionVariant2FunctionType)

                    || typeToConvert == typeof(global::Braintrust.PromptDataToolFunctionVariant2FunctionType?)

                    || typeToConvert == typeof(global::Braintrust.PromptDataToolFunctionVariant2GlobalType)

                    || typeToConvert == typeof(global::Braintrust.PromptDataToolFunctionVariant2GlobalType?)

                    || typeToConvert == typeof(global::Braintrust.PromptDataTemplateFormat)

                    || typeToConvert == typeof(global::Braintrust.PromptDataTemplateFormat?)

                    || typeToConvert == typeof(global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType)

                    || typeToConvert == typeof(global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType?)

                    || typeToConvert == typeof(global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType)

                    || typeToConvert == typeof(global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType?)

                    || typeToConvert == typeof(global::Braintrust.FunctionIdInlineCodeInlineContextRuntime)

                    || typeToConvert == typeof(global::Braintrust.FunctionIdInlineCodeInlineContextRuntime?)

                    || typeToConvert == typeof(global::Braintrust.GitMetadataSettingsCollect)

                    || typeToConvert == typeof(global::Braintrust.GitMetadataSettingsCollect?)

                    || typeToConvert == typeof(global::Braintrust.GitMetadataSettingsField)

                    || typeToConvert == typeof(global::Braintrust.GitMetadataSettingsField?)

                    || typeToConvert == typeof(global::Braintrust.PostEnvVarRequestObjectType)

                    || typeToConvert == typeof(global::Braintrust.PostEnvVarRequestObjectType?)

                    || typeToConvert == typeof(global::Braintrust.PutEnvVarRequestObjectType)

                    || typeToConvert == typeof(global::Braintrust.PutEnvVarRequestObjectType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Braintrust.ViewType))
                {
                    return new global::Braintrust.JsonConverters.ViewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewType?))
                {
                    return new global::Braintrust.JsonConverters.ViewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.AclObjectType))
                {
                    return new global::Braintrust.JsonConverters.AclObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.AclObjectType?))
                {
                    return new global::Braintrust.JsonConverters.AclObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.AclListOrgObjectType))
                {
                    return new global::Braintrust.JsonConverters.AclListOrgObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.AclListOrgObjectType?))
                {
                    return new global::Braintrust.JsonConverters.AclListOrgObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.AclListPermission))
                {
                    return new global::Braintrust.JsonConverters.AclListPermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.AclListPermission?))
                {
                    return new global::Braintrust.JsonConverters.AclListPermissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.AclListRestrictObjectType))
                {
                    return new global::Braintrust.JsonConverters.AclListRestrictObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.AclListRestrictObjectType?))
                {
                    return new global::Braintrust.JsonConverters.AclListRestrictObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectScoreType))
                {
                    return new global::Braintrust.JsonConverters.ProjectScoreTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectScoreType?))
                {
                    return new global::Braintrust.JsonConverters.ProjectScoreTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.EnvVarObjectType))
                {
                    return new global::Braintrust.JsonConverters.EnvVarObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.EnvVarObjectType?))
                {
                    return new global::Braintrust.JsonConverters.EnvVarObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionTypeEnum))
                {
                    return new global::Braintrust.JsonConverters.FunctionTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionTypeEnum?))
                {
                    return new global::Braintrust.JsonConverters.FunctionTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.NullableSavedFunctionIdFunctionType))
                {
                    return new global::Braintrust.JsonConverters.NullableSavedFunctionIdFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.NullableSavedFunctionIdFunctionType?))
                {
                    return new global::Braintrust.JsonConverters.NullableSavedFunctionIdFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.NullableSavedFunctionIdGlobalType))
                {
                    return new global::Braintrust.JsonConverters.NullableSavedFunctionIdGlobalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.NullableSavedFunctionIdGlobalType?))
                {
                    return new global::Braintrust.JsonConverters.NullableSavedFunctionIdGlobalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant1))
                {
                    return new global::Braintrust.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant1?))
                {
                    return new global::Braintrust.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant2))
                {
                    return new global::Braintrust.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant2?))
                {
                    return new global::Braintrust.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SpanType))
                {
                    return new global::Braintrust.JsonConverters.SpanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SpanType?))
                {
                    return new global::Braintrust.JsonConverters.SpanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SpanAttributesPurpose))
                {
                    return new global::Braintrust.JsonConverters.SpanAttributesPurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SpanAttributesPurpose?))
                {
                    return new global::Braintrust.JsonConverters.SpanAttributesPurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ObjectReferenceNullishObjectType))
                {
                    return new global::Braintrust.JsonConverters.ObjectReferenceNullishObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ObjectReferenceNullishObjectType?))
                {
                    return new global::Braintrust.JsonConverters.ObjectReferenceNullishObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SavedFunctionIdFunctionType))
                {
                    return new global::Braintrust.JsonConverters.SavedFunctionIdFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SavedFunctionIdFunctionType?))
                {
                    return new global::Braintrust.JsonConverters.SavedFunctionIdFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SavedFunctionIdGlobalType))
                {
                    return new global::Braintrust.JsonConverters.SavedFunctionIdGlobalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SavedFunctionIdGlobalType?))
                {
                    return new global::Braintrust.JsonConverters.SavedFunctionIdGlobalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectLogsEventLogId))
                {
                    return new global::Braintrust.JsonConverters.ProjectLogsEventLogIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectLogsEventLogId?))
                {
                    return new global::Braintrust.JsonConverters.ProjectLogsEventLogIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FeedbackResponseSchemaStatus))
                {
                    return new global::Braintrust.JsonConverters.FeedbackResponseSchemaStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FeedbackResponseSchemaStatus?))
                {
                    return new global::Braintrust.JsonConverters.FeedbackResponseSchemaStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FeedbackProjectLogsItemSource))
                {
                    return new global::Braintrust.JsonConverters.FeedbackProjectLogsItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FeedbackProjectLogsItemSource?))
                {
                    return new global::Braintrust.JsonConverters.FeedbackProjectLogsItemSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FeedbackExperimentItemSource))
                {
                    return new global::Braintrust.JsonConverters.FeedbackExperimentItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FeedbackExperimentItemSource?))
                {
                    return new global::Braintrust.JsonConverters.FeedbackExperimentItemSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FeedbackDatasetItemSource))
                {
                    return new global::Braintrust.JsonConverters.FeedbackDatasetItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FeedbackDatasetItemSource?))
                {
                    return new global::Braintrust.JsonConverters.FeedbackDatasetItemSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextType))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextType?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextCacheControlType))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartTextCacheControlTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextCacheControlType?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartTextCacheControlTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextCacheControlTtl))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartTextCacheControlTtlJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextCacheControlTtl?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartTextCacheControlTtlNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleType))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleType?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleCacheControlTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleCacheControlTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlTtl))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleCacheControlTtlJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlTtl?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartTextWithTitleCacheControlTtlNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailAutoJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailAutoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailLowJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailLowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailHighJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailHighNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleType))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleType?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlType))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleCacheControlTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlType?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleCacheControlTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlTtl))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleCacheControlTtlJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlTtl?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleCacheControlTtlNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleType))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartFileWithTitleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleType?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartFileWithTitleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlType))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartFileWithTitleCacheControlTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlType?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartFileWithTitleCacheControlTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlTtl))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartFileWithTitleCacheControlTtlJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlTtl?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartFileWithTitleCacheControlTtlNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionMessageToolCallType))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionMessageToolCallType?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamSystemRole))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionMessageParamSystemRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamSystemRole?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionMessageParamSystemRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamUserRole))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionMessageParamUserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamUserRole?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionMessageParamUserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamAssistantRole))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionMessageParamAssistantRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamAssistantRole?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionMessageParamAssistantRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamToolRole))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionMessageParamToolRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamToolRole?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionMessageParamToolRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamFunctionRole))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionMessageParamFunctionRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamFunctionRole?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionMessageParamFunctionRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamDeveloperRole))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionMessageParamDeveloperRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamDeveloperRole?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionMessageParamDeveloperRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamFallbackRole))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionMessageParamFallbackRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionMessageParamFallbackRole?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionMessageParamFallbackRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptBlockDataNullishChatType))
                {
                    return new global::Braintrust.JsonConverters.PromptBlockDataNullishChatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptBlockDataNullishChatType?))
                {
                    return new global::Braintrust.JsonConverters.PromptBlockDataNullishChatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptBlockDataNullishCompletionType))
                {
                    return new global::Braintrust.JsonConverters.PromptBlockDataNullishCompletionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptBlockDataNullishCompletionType?))
                {
                    return new global::Braintrust.JsonConverters.PromptBlockDataNullishCompletionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ResponseFormatNullishJsonObjectType))
                {
                    return new global::Braintrust.JsonConverters.ResponseFormatNullishJsonObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ResponseFormatNullishJsonObjectType?))
                {
                    return new global::Braintrust.JsonConverters.ResponseFormatNullishJsonObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ResponseFormatNullishJsonSchemaType))
                {
                    return new global::Braintrust.JsonConverters.ResponseFormatNullishJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ResponseFormatNullishJsonSchemaType?))
                {
                    return new global::Braintrust.JsonConverters.ResponseFormatNullishJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ResponseFormatNullishTextType))
                {
                    return new global::Braintrust.JsonConverters.ResponseFormatNullishTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ResponseFormatNullishTextType?))
                {
                    return new global::Braintrust.JsonConverters.ResponseFormatNullishTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto))
                {
                    return new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceAutoJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto?))
                {
                    return new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceAutoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone))
                {
                    return new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceNoneJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone?))
                {
                    return new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceNoneNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired))
                {
                    return new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceRequiredJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired?))
                {
                    return new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceRequiredNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionType))
                {
                    return new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionType?))
                {
                    return new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto))
                {
                    return new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallAutoJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto?))
                {
                    return new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallAutoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone))
                {
                    return new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallNoneJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone?))
                {
                    return new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallNoneNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsReasoningEffort))
                {
                    return new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsReasoningEffort?))
                {
                    return new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsVerbosity))
                {
                    return new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsVerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ModelParamsOpenAIModelParamsVerbosity?))
                {
                    return new global::Braintrust.JsonConverters.ModelParamsOpenAIModelParamsVerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptParserNullishType))
                {
                    return new global::Braintrust.JsonConverters.PromptParserNullishTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptParserNullishType?))
                {
                    return new global::Braintrust.JsonConverters.PromptParserNullishTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PreprocessorIdFunctionType))
                {
                    return new global::Braintrust.JsonConverters.PreprocessorIdFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PreprocessorIdFunctionType?))
                {
                    return new global::Braintrust.JsonConverters.PreprocessorIdFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PreprocessorIdPreprocessorGlobalType))
                {
                    return new global::Braintrust.JsonConverters.PreprocessorIdPreprocessorGlobalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PreprocessorIdPreprocessorGlobalType?))
                {
                    return new global::Braintrust.JsonConverters.PreprocessorIdPreprocessorGlobalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PreprocessorIdPreprocessorGlobalFunctionType))
                {
                    return new global::Braintrust.JsonConverters.PreprocessorIdPreprocessorGlobalFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PreprocessorIdPreprocessorGlobalFunctionType?))
                {
                    return new global::Braintrust.JsonConverters.PreprocessorIdPreprocessorGlobalFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PreprocessorIdPreprocessorInlineType))
                {
                    return new global::Braintrust.JsonConverters.PreprocessorIdPreprocessorInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PreprocessorIdPreprocessorInlineType?))
                {
                    return new global::Braintrust.JsonConverters.PreprocessorIdPreprocessorInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2FunctionType))
                {
                    return new global::Braintrust.JsonConverters.PromptDataNullishToolFunctionVariant2FunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2FunctionType?))
                {
                    return new global::Braintrust.JsonConverters.PromptDataNullishToolFunctionVariant2FunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2GlobalType))
                {
                    return new global::Braintrust.JsonConverters.PromptDataNullishToolFunctionVariant2GlobalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataNullishToolFunctionVariant2GlobalType?))
                {
                    return new global::Braintrust.JsonConverters.PromptDataNullishToolFunctionVariant2GlobalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataNullishTemplateFormat))
                {
                    return new global::Braintrust.JsonConverters.PromptDataNullishTemplateFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataNullishTemplateFormat?))
                {
                    return new global::Braintrust.JsonConverters.PromptDataNullishTemplateFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType))
                {
                    return new global::Braintrust.JsonConverters.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType?))
                {
                    return new global::Braintrust.JsonConverters.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType))
                {
                    return new global::Braintrust.JsonConverters.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType?))
                {
                    return new global::Braintrust.JsonConverters.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionTypeEnumNullish))
                {
                    return new global::Braintrust.JsonConverters.FunctionTypeEnumNullishJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionTypeEnumNullish?))
                {
                    return new global::Braintrust.JsonConverters.FunctionTypeEnumNullishNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptLogId))
                {
                    return new global::Braintrust.JsonConverters.PromptLogIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptLogId?))
                {
                    return new global::Braintrust.JsonConverters.PromptLogIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.Permission))
                {
                    return new global::Braintrust.JsonConverters.PermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.Permission?))
                {
                    return new global::Braintrust.JsonConverters.PermissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.AutomationStatus))
                {
                    return new global::Braintrust.JsonConverters.AutomationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.AutomationStatus?))
                {
                    return new global::Braintrust.JsonConverters.AutomationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SpanScopeType))
                {
                    return new global::Braintrust.JsonConverters.SpanScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.SpanScopeType?))
                {
                    return new global::Braintrust.JsonConverters.SpanScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TraceScopeType))
                {
                    return new global::Braintrust.JsonConverters.TraceScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TraceScopeType?))
                {
                    return new global::Braintrust.JsonConverters.TraceScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GroupScopeType))
                {
                    return new global::Braintrust.JsonConverters.GroupScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GroupScopeType?))
                {
                    return new global::Braintrust.JsonConverters.GroupScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GroupScopePlacement))
                {
                    return new global::Braintrust.JsonConverters.GroupScopePlacementJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GroupScopePlacement?))
                {
                    return new global::Braintrust.JsonConverters.GroupScopePlacementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.RetentionObjectType))
                {
                    return new global::Braintrust.JsonConverters.RetentionObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.RetentionObjectType?))
                {
                    return new global::Braintrust.JsonConverters.RetentionObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigEventType))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigEventType?))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigProductOrigin))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigProductOriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigProductOrigin?))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigProductOriginNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdCalculationType))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigThresholdCalculationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdCalculationType?))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigThresholdCalculationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdCalculationOutputType))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigThresholdCalculationOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdCalculationOutputType?))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigThresholdCalculationOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigThresholdPolicyConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType?))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigThresholdPolicyConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigThresholdPolicyConditionOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator?))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigThresholdPolicyConditionOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyNoDataBehavior))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigThresholdPolicyNoDataBehaviorJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigThresholdPolicyNoDataBehavior?))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigThresholdPolicyNoDataBehaviorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigWindowScheduleVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigWindowScheduleVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2Type))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigWindowScheduleVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2Type?))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigWindowScheduleVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigLoopHarness))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigLoopHarnessJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigLoopHarness?))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigLoopHarnessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigLoopReasoningEffort))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigLoopReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigLoopReasoningEffort?))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigLoopReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigActionVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigActionVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigActionVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigActionVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigActionVariant2Type))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigActionVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.WindowedAutomationConfigActionVariant2Type?))
                {
                    return new global::Braintrust.JsonConverters.WindowedAutomationConfigActionVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicAutomationFacetModel))
                {
                    return new global::Braintrust.JsonConverters.TopicAutomationFacetModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicAutomationFacetModel?))
                {
                    return new global::Braintrust.JsonConverters.TopicAutomationFacetModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2FunctionType))
                {
                    return new global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2FunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2FunctionType?))
                {
                    return new global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2FunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2GlobalType))
                {
                    return new global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2GlobalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicMapFunctionAutomationFunctionVariant2GlobalType?))
                {
                    return new global::Braintrust.JsonConverters.TopicMapFunctionAutomationFunctionVariant2GlobalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicAutomationDataScopeVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicAutomationDataScopeVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicAutomationDataScopeVariant2Type))
                {
                    return new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicAutomationDataScopeVariant2Type?))
                {
                    return new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicAutomationDataScopeVariant3Type))
                {
                    return new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicAutomationDataScopeVariant3Type?))
                {
                    return new global::Braintrust.JsonConverters.TopicAutomationDataScopeVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicAutomationConfigEventType))
                {
                    return new global::Braintrust.JsonConverters.TopicAutomationConfigEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicAutomationConfigEventType?))
                {
                    return new global::Braintrust.JsonConverters.TopicAutomationConfigEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicAutomationConfigFacetFunctionVariant2FunctionType))
                {
                    return new global::Braintrust.JsonConverters.TopicAutomationConfigFacetFunctionVariant2FunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicAutomationConfigFacetFunctionVariant2FunctionType?))
                {
                    return new global::Braintrust.JsonConverters.TopicAutomationConfigFacetFunctionVariant2FunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalType))
                {
                    return new global::Braintrust.JsonConverters.TopicAutomationConfigFacetFunctionVariant2GlobalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalType?))
                {
                    return new global::Braintrust.JsonConverters.TopicAutomationConfigFacetFunctionVariant2GlobalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicDigestAutomationConfigEventType))
                {
                    return new global::Braintrust.JsonConverters.TopicDigestAutomationConfigEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicDigestAutomationConfigEventType?))
                {
                    return new global::Braintrust.JsonConverters.TopicDigestAutomationConfigEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicDigestAutomationConfigActionType))
                {
                    return new global::Braintrust.JsonConverters.TopicDigestAutomationConfigActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicDigestAutomationConfigActionType?))
                {
                    return new global::Braintrust.JsonConverters.TopicDigestAutomationConfigActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant1EventType))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant1EventType?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1ActionVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1ActionVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2Type))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1ActionVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2Type?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant1ActionVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2EventType))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2EventType?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2Type))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2Type?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2Format))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2FormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2Format?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2FormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2Type))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2Type?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant2CredentialsVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant3EventType))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant3EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant3EventType?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant3EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant3ObjectType))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant3ObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant3ObjectType?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant3ObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant3Format))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant3FormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant3Format?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant3FormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant4EventType))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant4EventType?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant4EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant5EventType))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant5EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant5EventType?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant5EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant5ActionVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant5ActionVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2Type))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant5ActionVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2Type?))
                {
                    return new global::Braintrust.JsonConverters.ProjectAutomationConfigVariant5ActionVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant1EventType))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant1EventType?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2Type))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2Type?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2EventType))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2EventType?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2Format))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2FormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2Format?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2FormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2Type))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2Type?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant3EventType))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant3EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant3EventType?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant3EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant3ObjectType))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant3ObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant3ObjectType?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant3ObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant3Format))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant3FormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant3Format?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant3FormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant4EventType))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant4EventType?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant4EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant5EventType))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant5EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant5EventType?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant5EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant5ActionVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant5ActionVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2Type))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant5ActionVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2Type?))
                {
                    return new global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant5ActionVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant1EventType))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant1EventType?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2Type))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2Type?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2EventType))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2EventType?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2Format))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2FormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2Format?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2FormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2Type))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2Type?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant3EventType))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant3EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant3EventType?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant3EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant3ObjectType))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant3ObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant3ObjectType?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant3ObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant3Format))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant3FormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant3Format?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant3FormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant4EventType))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant4EventType?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant4EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant5EventType))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant5EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant5EventType?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant5EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant5ActionVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant5ActionVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2Type))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant5ActionVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2Type?))
                {
                    return new global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant5ActionVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.OrgAutomationConfigEventType))
                {
                    return new global::Braintrust.JsonConverters.OrgAutomationConfigEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.OrgAutomationConfigEventType?))
                {
                    return new global::Braintrust.JsonConverters.OrgAutomationConfigEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateOrgAutomationConfigEventType))
                {
                    return new global::Braintrust.JsonConverters.CreateOrgAutomationConfigEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateOrgAutomationConfigEventType?))
                {
                    return new global::Braintrust.JsonConverters.CreateOrgAutomationConfigEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchOrgAutomationConfigEventType))
                {
                    return new global::Braintrust.JsonConverters.PatchOrgAutomationConfigEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchOrgAutomationConfigEventType?))
                {
                    return new global::Braintrust.JsonConverters.PatchOrgAutomationConfigEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType))
                {
                    return new global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2FunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType?))
                {
                    return new global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2FunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType))
                {
                    return new global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2GlobalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType?))
                {
                    return new global::Braintrust.JsonConverters.OnlineScoreConfigScorerVariant2GlobalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectScoreConditionBehavior))
                {
                    return new global::Braintrust.JsonConverters.ProjectScoreConditionBehaviorJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectScoreConditionBehavior?))
                {
                    return new global::Braintrust.JsonConverters.ProjectScoreConditionBehaviorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectScoreConfigObjectType))
                {
                    return new global::Braintrust.JsonConverters.ProjectScoreConfigObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ProjectScoreConfigObjectType?))
                {
                    return new global::Braintrust.JsonConverters.ProjectScoreConfigObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleRuntimeContextRuntime))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleRuntimeContextRuntimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleRuntimeContextRuntime?))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleRuntimeContextRuntimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleLocationExperimentType))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleLocationExperimentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleLocationExperimentType?))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleLocationExperimentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleLocationExperimentPositionVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleLocationExperimentPositionVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleLocationExperimentPositionScorerType))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionScorerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleLocationExperimentPositionScorerType?))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionScorerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleLocationExperimentPositionClassifierType))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionClassifierTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleLocationExperimentPositionClassifierType?))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionClassifierTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleLocationFunctionType))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleLocationFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleLocationFunctionType?))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleLocationFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleLocationVariant3Type))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleLocationVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleLocationVariant3Type?))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleLocationVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1Provider))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant1ProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1Provider?))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant1ProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2Provider))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant2ProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2Provider?))
                {
                    return new global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant2ProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptBlockDataChatType))
                {
                    return new global::Braintrust.JsonConverters.PromptBlockDataChatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptBlockDataChatType?))
                {
                    return new global::Braintrust.JsonConverters.PromptBlockDataChatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptBlockDataCompletionType))
                {
                    return new global::Braintrust.JsonConverters.PromptBlockDataCompletionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptBlockDataCompletionType?))
                {
                    return new global::Braintrust.JsonConverters.PromptBlockDataCompletionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphNodeVariant1Type))
                {
                    return new global::Braintrust.JsonConverters.GraphNodeVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphNodeVariant1Type?))
                {
                    return new global::Braintrust.JsonConverters.GraphNodeVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphNodeVariant2Type))
                {
                    return new global::Braintrust.JsonConverters.GraphNodeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphNodeVariant2Type?))
                {
                    return new global::Braintrust.JsonConverters.GraphNodeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphNodeVariant3Type))
                {
                    return new global::Braintrust.JsonConverters.GraphNodeVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphNodeVariant3Type?))
                {
                    return new global::Braintrust.JsonConverters.GraphNodeVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphNodeVariant4Type))
                {
                    return new global::Braintrust.JsonConverters.GraphNodeVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphNodeVariant4Type?))
                {
                    return new global::Braintrust.JsonConverters.GraphNodeVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphNodeVariant5Type))
                {
                    return new global::Braintrust.JsonConverters.GraphNodeVariant5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphNodeVariant5Type?))
                {
                    return new global::Braintrust.JsonConverters.GraphNodeVariant5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphNodeVariant6Type))
                {
                    return new global::Braintrust.JsonConverters.GraphNodeVariant6TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphNodeVariant6Type?))
                {
                    return new global::Braintrust.JsonConverters.GraphNodeVariant6TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphNodeVariant7Type))
                {
                    return new global::Braintrust.JsonConverters.GraphNodeVariant7TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphNodeVariant7Type?))
                {
                    return new global::Braintrust.JsonConverters.GraphNodeVariant7TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphNodeVariant8Type))
                {
                    return new global::Braintrust.JsonConverters.GraphNodeVariant8TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphNodeVariant8Type?))
                {
                    return new global::Braintrust.JsonConverters.GraphNodeVariant8TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphEdgePurpose))
                {
                    return new global::Braintrust.JsonConverters.GraphEdgePurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphEdgePurpose?))
                {
                    return new global::Braintrust.JsonConverters.GraphEdgePurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphDataType))
                {
                    return new global::Braintrust.JsonConverters.GraphDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GraphDataType?))
                {
                    return new global::Braintrust.JsonConverters.GraphDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FacetPreprocessorIdFunctionType))
                {
                    return new global::Braintrust.JsonConverters.FacetPreprocessorIdFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FacetPreprocessorIdFunctionType?))
                {
                    return new global::Braintrust.JsonConverters.FacetPreprocessorIdFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FacetPreprocessorIdGlobalType))
                {
                    return new global::Braintrust.JsonConverters.FacetPreprocessorIdGlobalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FacetPreprocessorIdGlobalType?))
                {
                    return new global::Braintrust.JsonConverters.FacetPreprocessorIdGlobalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FacetPreprocessorIdPreprocessorInlineType))
                {
                    return new global::Braintrust.JsonConverters.FacetPreprocessorIdPreprocessorInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FacetPreprocessorIdPreprocessorInlineType?))
                {
                    return new global::Braintrust.JsonConverters.FacetPreprocessorIdPreprocessorInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FacetDataType))
                {
                    return new global::Braintrust.JsonConverters.FacetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FacetDataType?))
                {
                    return new global::Braintrust.JsonConverters.FacetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicMapGenerationSettingsAlgorithm))
                {
                    return new global::Braintrust.JsonConverters.TopicMapGenerationSettingsAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicMapGenerationSettingsAlgorithm?))
                {
                    return new global::Braintrust.JsonConverters.TopicMapGenerationSettingsAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicMapGenerationSettingsDimensionReduction))
                {
                    return new global::Braintrust.JsonConverters.TopicMapGenerationSettingsDimensionReductionJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicMapGenerationSettingsDimensionReduction?))
                {
                    return new global::Braintrust.JsonConverters.TopicMapGenerationSettingsDimensionReductionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicMapDataType))
                {
                    return new global::Braintrust.JsonConverters.TopicMapDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicMapDataType?))
                {
                    return new global::Braintrust.JsonConverters.TopicMapDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicMapDataSourceFacetFunctionVariant2FunctionType))
                {
                    return new global::Braintrust.JsonConverters.TopicMapDataSourceFacetFunctionVariant2FunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicMapDataSourceFacetFunctionVariant2FunctionType?))
                {
                    return new global::Braintrust.JsonConverters.TopicMapDataSourceFacetFunctionVariant2FunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalType))
                {
                    return new global::Braintrust.JsonConverters.TopicMapDataSourceFacetFunctionVariant2GlobalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalType?))
                {
                    return new global::Braintrust.JsonConverters.TopicMapDataSourceFacetFunctionVariant2GlobalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicMapDataReconcileMode))
                {
                    return new global::Braintrust.JsonConverters.TopicMapDataReconcileModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.TopicMapDataReconcileMode?))
                {
                    return new global::Braintrust.JsonConverters.TopicMapDataReconcileModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.BatchedFacetDataType))
                {
                    return new global::Braintrust.JsonConverters.BatchedFacetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.BatchedFacetDataType?))
                {
                    return new global::Braintrust.JsonConverters.BatchedFacetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataPromptType))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataPromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataPromptType?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataPromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataCodeType))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataCodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataCodeType?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataCodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataCodeDataType))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataCodeDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataCodeDataType?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataCodeDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataCodeDataType2))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataCodeDataType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataCodeDataType2?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataCodeDataType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataCodeDataRuntimeContextRuntime))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataCodeDataRuntimeContextRuntimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataCodeDataRuntimeContextRuntime?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataCodeDataRuntimeContextRuntimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataRemoteEvalType))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataRemoteEvalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataRemoteEvalType?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataRemoteEvalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataGlobalType))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataGlobalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataGlobalType?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataGlobalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataParametersType))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataParametersTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataParametersType?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataParametersTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataParametersSchemaType))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataParametersSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataParametersSchemaType?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataParametersSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionLogId))
                {
                    return new global::Braintrust.JsonConverters.FunctionLogIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionLogId?))
                {
                    return new global::Braintrust.JsonConverters.FunctionLogIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishPromptType))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishPromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishPromptType?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishPromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishCodeType))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishCodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishCodeType?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishCodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishCodeDataType))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishCodeDataType?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishCodeDataType2))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishCodeDataType2?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishCodeDataRuntimeContextRuntime))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataRuntimeContextRuntimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishCodeDataRuntimeContextRuntime?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishCodeDataRuntimeContextRuntimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishRemoteEvalType))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishRemoteEvalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishRemoteEvalType?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishRemoteEvalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishGlobalType))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishGlobalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishGlobalType?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishGlobalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishParametersType))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishParametersTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishParametersType?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishParametersTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishParametersSchemaType))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishParametersSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionDataNullishParametersSchemaType?))
                {
                    return new global::Braintrust.JsonConverters.FunctionDataNullishParametersSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.InvokeParentSpanParentStructObjectType))
                {
                    return new global::Braintrust.JsonConverters.InvokeParentSpanParentStructObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.InvokeParentSpanParentStructObjectType?))
                {
                    return new global::Braintrust.JsonConverters.InvokeParentSpanParentStructObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.StreamingMode))
                {
                    return new global::Braintrust.JsonConverters.StreamingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.StreamingMode?))
                {
                    return new global::Braintrust.JsonConverters.StreamingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsViewType))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsViewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsViewType?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsViewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsSpanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsSpanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsOptionsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsExcludedMeasureTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsExcludedMeasureTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsYMetricType))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsYMetricTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsYMetricType?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsYMetricTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsXAxisType))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsXAxisTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsXAxisType?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsXAxisTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsSymbolGroupingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsSymbolGroupingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsPointSizeMetricTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsPointSizeMetricTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsQueryShape))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsQueryShapeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewOptionsTableViewOptionsQueryShape?))
                {
                    return new global::Braintrust.JsonConverters.ViewOptionsTableViewOptionsQueryShapeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewViewType))
                {
                    return new global::Braintrust.JsonConverters.ViewViewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ViewViewType?))
                {
                    return new global::Braintrust.JsonConverters.ViewViewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateViewViewType))
                {
                    return new global::Braintrust.JsonConverters.CreateViewViewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.CreateViewViewType?))
                {
                    return new global::Braintrust.JsonConverters.CreateViewViewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchViewViewType))
                {
                    return new global::Braintrust.JsonConverters.PatchViewViewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchViewViewType?))
                {
                    return new global::Braintrust.JsonConverters.PatchViewViewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ImageRenderingMode))
                {
                    return new global::Braintrust.JsonConverters.ImageRenderingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ImageRenderingMode?))
                {
                    return new global::Braintrust.JsonConverters.ImageRenderingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchOrganizationMembersOutputStatus))
                {
                    return new global::Braintrust.JsonConverters.PatchOrganizationMembersOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PatchOrganizationMembersOutputStatus?))
                {
                    return new global::Braintrust.JsonConverters.PatchOrganizationMembersOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.EnvVarObjectType2))
                {
                    return new global::Braintrust.JsonConverters.EnvVarObjectType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.EnvVarObjectType2?))
                {
                    return new global::Braintrust.JsonConverters.EnvVarObjectType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.EnvVarSecretCategory))
                {
                    return new global::Braintrust.JsonConverters.EnvVarSecretCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.EnvVarSecretCategory?))
                {
                    return new global::Braintrust.JsonConverters.EnvVarSecretCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataToolFunctionVariant2FunctionType))
                {
                    return new global::Braintrust.JsonConverters.PromptDataToolFunctionVariant2FunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataToolFunctionVariant2FunctionType?))
                {
                    return new global::Braintrust.JsonConverters.PromptDataToolFunctionVariant2FunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataToolFunctionVariant2GlobalType))
                {
                    return new global::Braintrust.JsonConverters.PromptDataToolFunctionVariant2GlobalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataToolFunctionVariant2GlobalType?))
                {
                    return new global::Braintrust.JsonConverters.PromptDataToolFunctionVariant2GlobalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataTemplateFormat))
                {
                    return new global::Braintrust.JsonConverters.PromptDataTemplateFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataTemplateFormat?))
                {
                    return new global::Braintrust.JsonConverters.PromptDataTemplateFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType))
                {
                    return new global::Braintrust.JsonConverters.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType?))
                {
                    return new global::Braintrust.JsonConverters.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType))
                {
                    return new global::Braintrust.JsonConverters.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType?))
                {
                    return new global::Braintrust.JsonConverters.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionIdInlineCodeInlineContextRuntime))
                {
                    return new global::Braintrust.JsonConverters.FunctionIdInlineCodeInlineContextRuntimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionIdInlineCodeInlineContextRuntime?))
                {
                    return new global::Braintrust.JsonConverters.FunctionIdInlineCodeInlineContextRuntimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GitMetadataSettingsCollect))
                {
                    return new global::Braintrust.JsonConverters.GitMetadataSettingsCollectJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GitMetadataSettingsCollect?))
                {
                    return new global::Braintrust.JsonConverters.GitMetadataSettingsCollectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GitMetadataSettingsField))
                {
                    return new global::Braintrust.JsonConverters.GitMetadataSettingsFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.GitMetadataSettingsField?))
                {
                    return new global::Braintrust.JsonConverters.GitMetadataSettingsFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PostEnvVarRequestObjectType))
                {
                    return new global::Braintrust.JsonConverters.PostEnvVarRequestObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PostEnvVarRequestObjectType?))
                {
                    return new global::Braintrust.JsonConverters.PostEnvVarRequestObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PutEnvVarRequestObjectType))
                {
                    return new global::Braintrust.JsonConverters.PutEnvVarRequestObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.PutEnvVarRequestObjectType?))
                {
                    return new global::Braintrust.JsonConverters.PutEnvVarRequestObjectTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[3];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}