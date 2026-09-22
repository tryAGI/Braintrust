
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?>), TypeInfoPropertyName = "ChatCompletionContentPartImageWithTitleImageUrlDetailHigh_e8d70c92af1da1bc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction>), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsToolChoiceFunction_10f78e443eec5956")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallFunction>), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsFunctionCallFunction_fae5e4272e975e60")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>), TypeInfoPropertyName = "PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers_011c031415cbd2fb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?, global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?>?), TypeInfoPropertyName = "ChatCompletionContentPartImageWithTitleImageUrlDetailHigh_3533da88d7ecf2d5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired?, global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction>?), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsToolChoiceFunction_185a87e2aac60e39")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone?, global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallFunction>?), TypeInfoPropertyName = "ModelParamsOpenAIModelParamsFunctionCallFunction_b998c4cffab2d96d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>?>?), TypeInfoPropertyName = "PromptDataNullishToolFunctionVariant2Global_9bd0fd9ab612ae14")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.OneOf<global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>?), TypeInfoPropertyName = "PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers_d50854d224e89aa6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Ids), TypeInfoPropertyName = "Ids2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionTypeEnum), TypeInfoPropertyName = "FunctionTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionId), TypeInfoPropertyName = "SavedFunctionId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdFunctionType), TypeInfoPropertyName = "SavedFunctionIdFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdGlobal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdGlobalType), TypeInfoPropertyName = "SavedFunctionIdGlobalType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudioFormat), TypeInfoPropertyName = "ChatCompletionContentPartInputAudioWithTitleInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleType), TypeInfoPropertyName = "ChatCompletionContentPartInputAudioWithTitleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlType), TypeInfoPropertyName = "ChatCompletionContentPartInputAudioWithTitleCacheControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtl), TypeInfoPropertyName = "ChatCompletionContentPartInputAudioWithTitleCacheControlTtl2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.GetPromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Braintrust.Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.Ids?), TypeInfoPropertyName = "NullableIds2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.FunctionTypeEnum?), TypeInfoPropertyName = "NullableFunctionTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionId?), TypeInfoPropertyName = "NullableSavedFunctionId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdFunctionType?), TypeInfoPropertyName = "NullableSavedFunctionIdFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.SavedFunctionIdGlobalType?), TypeInfoPropertyName = "NullableSavedFunctionIdGlobalType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudioFormat?), TypeInfoPropertyName = "NullableChatCompletionContentPartInputAudioWithTitleInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleType?), TypeInfoPropertyName = "NullableChatCompletionContentPartInputAudioWithTitleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlType?), TypeInfoPropertyName = "NullableChatCompletionContentPartInputAudioWithTitleCacheControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtl?), TypeInfoPropertyName = "NullableChatCompletionContentPartInputAudioWithTitleCacheControlTtl2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPartText>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPartText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPartText>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ChatCompletionMessageReasoning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.ChatCompletionMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Braintrust.Prompt>))]
    internal sealed partial class PromptsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PromptsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PromptsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Braintrust.JsonConverters.IdsJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.SavedFunctionIdJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionContentPartJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ChatCompletionMessageParamJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PromptBlockDataNullishJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ResponseFormatNullishJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.ModelParamsJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.PreprocessorIdJsonConverter());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<double?, bool?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<double?, bool?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<double?, bool?>());
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
            options.Converters.Add(new global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.FunctionTypeEnum?, object>());
            options.Converters.Add(new global::Braintrust.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::Braintrust.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Braintrust.FunctionTypeEnum)

                    || typeToConvert == typeof(global::Braintrust.FunctionTypeEnum?)

                    || typeToConvert == typeof(global::Braintrust.SavedFunctionIdFunctionType)

                    || typeToConvert == typeof(global::Braintrust.SavedFunctionIdFunctionType?)

                    || typeToConvert == typeof(global::Braintrust.SavedFunctionIdGlobalType)

                    || typeToConvert == typeof(global::Braintrust.SavedFunctionIdGlobalType?)

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

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudioFormat)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudioFormat?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleType)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleType?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlType)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlType?)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtl)

                    || typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtl?)

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

                    || typeToConvert == typeof(global::Braintrust.PromptLogId?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Braintrust.FunctionTypeEnum))
                {
                    return new global::Braintrust.JsonConverters.FunctionTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.FunctionTypeEnum?))
                {
                    return new global::Braintrust.JsonConverters.FunctionTypeEnumNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudioFormat))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartInputAudioWithTitleInputAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudioFormat?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartInputAudioWithTitleInputAudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleType))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartInputAudioWithTitleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleType?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartInputAudioWithTitleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlType))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartInputAudioWithTitleCacheControlTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlType?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartInputAudioWithTitleCacheControlTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtl))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartInputAudioWithTitleCacheControlTtlJsonConverter();
                }

                if (typeToConvert == typeof(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtl?))
                {
                    return new global::Braintrust.JsonConverters.ChatCompletionContentPartInputAudioWithTitleCacheControlTtlNullableJsonConverter();
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
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new PromptsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}