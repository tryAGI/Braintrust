
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ScoreObject? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<double?, bool?>? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object?>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.NamedScore? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ScoreResult? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.NamedScore>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Ids? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewType? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.UserGivenName? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.UserFamilyName? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.UserEmail? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclObjectType? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclListOrgObjectType? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclListPermission? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclListRestrictObjectType? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreType? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AISecretType? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.EnvVarObjectType? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionTypeEnum? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.NullableSavedFunctionIdFunction? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.NullableSavedFunctionIdGlobal? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettings? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectSettingsSpanFieldOrderItem>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsSpanFieldOrderItem? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant1?, global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant2?>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant1? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant2? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectSettingsRemoteEvalSource>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsRemoteEvalSource? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Project? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProject? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProject? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.ProjectSettings, object>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertEventsResponse? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanType? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanAttributes? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanAttributesPurpose? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanAttributesLogLevel? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ObjectReferenceNullish? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ObjectReferenceNullishObjectType? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEvent? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventMetadata? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventMetrics? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventContext? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertProjectLogsEventArrayDeleteItem>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventArrayDeleteItem? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object?>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventRequest? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertProjectLogsEvent>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedFunctionIdFunction? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedFunctionIdGlobal? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEvent? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventLogId? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventMetadata? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventMetrics? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventContext? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.ProjectLogsEventClassification>>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectLogsEventClassification>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventClassification? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FetchProjectLogsEventsResponse? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectLogsEvent>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FetchEventsRequest? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackResponseSchema? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackResponseSchemaStatus? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackProjectLogsItem? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackProjectLogsItemSource? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackProjectLogsEventRequest? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.FeedbackProjectLogsItem>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RepoInfo? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Experiment? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentInternalMetadata? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateExperiment? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateExperimentInternalMetadata? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchExperiment? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchExperimentInternalMetadata? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEvent? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventMetadata? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventMetrics? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventContext? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertExperimentEventArrayDeleteItem>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventArrayDeleteItem? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventRequest? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertExperimentEvent>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEvent? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEventMetadata? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEventMetrics? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEventContext? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.ExperimentEventClassification>>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ExperimentEventClassification>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEventClassification? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FetchExperimentEventsResponse? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ExperimentEvent>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackExperimentItem? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackExperimentItemSource? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackExperimentEventRequest? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.FeedbackExperimentItem>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ScoreSummary? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.MetricSummary? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SummarizeExperimentResponse? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.ScoreSummary>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.MetricSummary>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Dataset? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateDataset? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchDataset? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertDatasetEvent? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertDatasetEventMetadata? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertDatasetEventArrayDeleteItem>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertDatasetEventArrayDeleteItem? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertDatasetEventRequest? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertDatasetEvent>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetEvent? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetEventMetadata? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.DatasetEventClassification>>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.DatasetEventClassification>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetEventClassification? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FetchDatasetEventsResponse? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.DatasetEvent>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackDatasetItem? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackDatasetItemSource? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackDatasetEventRequest? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.FeedbackDatasetItem>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DataSummary? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SummarizeDatasetResponse? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartText? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextType? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextCacheControl? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextCacheControlType? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextCacheControlTtl? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitle? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleType? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControl? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlTtl? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitle? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrl? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleType? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControl? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlType? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlTtl? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitle? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudio? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudioFormat? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleType? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControl? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlType? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtl? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileFile? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitle? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleType? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControl? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlType? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlTtl? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPart? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageToolCall? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageToolCallFunction? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageToolCallType? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageReasoning? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParam? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamSystem? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamSystemRole? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamUser? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPart>>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPart>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamUserRole? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamAssistant? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamAssistantRole? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamAssistantFunctionCall? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageToolCall>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageReasoning>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamTool? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamToolRole? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFunction? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFunctionRole? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamDeveloper? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamDeveloperRole? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFallback? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFallbackRole? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullish? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishChat? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishChatType? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageParam>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishCompletion? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishCompletionType? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatJsonSchema? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::System.Collections.Generic.Dictionary<string, object?>, string>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullish? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonObject? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonObjectType? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonSchema? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonSchemaType? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishText? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishTextType? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParams? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParams? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionType? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionFunction? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallFunction? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsReasoningEffort? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsChatTemplateKwargs? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsVerbosity? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsAnthropicModelParams? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsGoogleModelParams? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsWindowAIModelParams? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsJsCompletionParams? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptOptionsNullish? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptParserNullish? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptParserNullishType? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorId? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdFunction? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdFunctionType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorGlobal? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorGlobalType? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorGlobalFunctionType? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorInline? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorInlineType? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullish? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2Function? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2FunctionType? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2Global? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2GlobalType? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishTemplateFormat? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishOrigin? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionTypeEnumNullish? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Prompt? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptLogId? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreatePrompt? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchPrompt? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Permission? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Role? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.RoleMemberPermission>? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RoleMemberPermission? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateRole? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.CreateRoleMemberPermission>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateRoleMemberPermission? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchRole? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchRoleAddMemberPermission>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchRoleAddMemberPermission? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchRoleRemoveMemberPermission>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchRoleRemoveMemberPermission? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Group? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateGroup? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchGroup? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectGroup? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectGroup? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectGroup? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Acl? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclItem? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclBatchUpdateResponse? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Acl>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclBatchUpdateRequest? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AclItem>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.User? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Agent? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateAgent? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchAgent? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AutomationStatus? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanScope? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanScopeType? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TraceScope? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TraceScopeType? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GroupScope? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GroupScopeType? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GroupScopePlacement? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RetentionObjectType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfig? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigEventType? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigProductOrigin? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThreshold? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculation? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationType? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationOutput? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationOutputType? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicy? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyCondition? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyNoDataBehavior? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindow? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1, global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1Type? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2Type? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoop? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopHarness? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopReasoningEffort? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigActionVariant1, global::Braintrust.WindowedAutomationConfigActionVariant2>>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigActionVariant1, global::Braintrust.WindowedAutomationConfigActionVariant2>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant1? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant1Type? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant2? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant2Type? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationFacetModel? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomation? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2FunctionType? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2GlobalType? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScope? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant1? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant1Type? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant2? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant2Type? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant3? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant3Type? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfig? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigEventType? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2FunctionType? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.TopicMapFunctionAutomation>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::Braintrust.TopicAutomationConfigBackfillTimeRange>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigBackfillTimeRange? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfig? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfigEventType? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfigAction? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfigActionType? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomation? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1EventType? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1Type? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2Type? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2EventType? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1Type? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2Type? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2Format? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2>? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1Type? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2Type? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3EventType? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3ObjectType? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3Format? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant4? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant4EventType? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5EventType? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1, global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1Type? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2Type? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationRuntimeBlock? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomation? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1EventType? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1Type? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2Type? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2EventType? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2Format? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1Type? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2Type? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3EventType? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3ObjectType? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3Format? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant4? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant4EventType? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5EventType? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2>? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1Type? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2Type? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomation? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1EventType? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2>? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1Type? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2Type? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2EventType? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2Format? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1Type? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2Type? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3EventType? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3ObjectType? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3Format? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant4? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant4EventType? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5EventType? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1, global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1Type? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2Type? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OrgAutomation? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OrgAutomationConfig? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OrgAutomationConfigEventType? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateOrgAutomation? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateOrgAutomationConfig? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateOrgAutomationConfigEventType? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrgAutomation? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrgAutomationConfig? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrgAutomationConfigEventType? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreCategory? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreCategories? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectScoreCategory>? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfig? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2Function? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2Global? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreCondition? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConditionWhen? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConditionBehavior? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConfig? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConfigVisibility? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectScoreConfigObjectType>? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConfigObjectType? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScore? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectScore? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectScore? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectTag? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectTag? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectTag? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanIFrame? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateSpanIFrame? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchSpanIFrame? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundle? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleRuntimeContext? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleRuntimeContextRuntime? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperiment, global::Braintrust.CodeBundleLocationFunction, global::Braintrust.CodeBundleLocationVariant3>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperiment? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentType? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionVariant1? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionVariant1Type? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionScorer? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionScorerType? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionClassifier? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionClassifierType? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationFunction? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationFunctionType? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3Type? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1, global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2>? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1Provider? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2Provider? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockData? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataChat? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataChatType? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataCompletion? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataCompletionType? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNode? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant1? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant1Position? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant1Type? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant2? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant2Position? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant2Type? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant3? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant3Position? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant3Type? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant4? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant4Position? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant4Type? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant5? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant5Position? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant5Type? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant6? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant6Position? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant6Type? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant7? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant7Position? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant7Type? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant8? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant8Position? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant8Type? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdge? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdgeSource? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdgeTarget? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdgePurpose? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphData? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphDataType? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.GraphNode>? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.GraphEdge>? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorId? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdFunction? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdFunctionType? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdGlobal? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdGlobalType? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdPreprocessorInline? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdPreprocessorInlineType? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetData? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetDataType? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapGenerationSettings? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapGenerationSettingsAlgorithm? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapGenerationSettingsDimensionReduction? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapData? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataType? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function, global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global>? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2FunctionType? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalType? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataReconcileMode? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetData? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetDataType? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataFacet>? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetDataFacet? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataTopicMap>>? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataTopicMap>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetDataTopicMap? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionData? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataPrompt? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataPromptType? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCode? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeType? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataCodeData2>? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeData? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataType? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeData2? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataType2? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataRuntimeContext? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataRuntimeContextRuntime? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataRemoteEval? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataRemoteEvalType? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataGlobal? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataGlobalType? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParameters? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParametersType? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParametersSchema? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParametersSchemaType? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, object?>>? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Function2? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionLogId? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionOrigin? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionFunctionSchema? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateFunction? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateFunctionOrigin? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateFunctionFunctionSchema? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullish? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishPrompt? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishPromptType? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCode? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeType? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataNullishCodeData2>? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeData? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataType? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeData2? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataType2? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataRuntimeContext? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataRuntimeContextRuntime? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishRemoteEval? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishRemoteEvalType? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishGlobal? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishGlobalType? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParameters? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParametersType? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParametersSchema? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParametersSchemaType? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchFunction? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParent? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParentSpanParentStruct? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParentSpanParentStructObjectType? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParentSpanParentStructRowIds? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.StreamingMode? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeApi? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.InvokeApiMcpAuth2>? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeApiMcpAuth2? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewDataSearch? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewData? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptions? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptions? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsViewType? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptions? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptions? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure>? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsYMetric? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsYMetricType? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsXAxis? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsXAxisType? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsSymbolGrouping? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetric? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation>? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter>? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsQueryShape? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.View? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewViewType? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateView? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateViewViewType? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchView? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchViewViewType? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DeleteView? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ImageRenderingMode? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Organization? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganization? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersOutput? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersOutputStatus? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchOrganizationMembersOutputAddedUser>? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersOutputAddedUser? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembers? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersInviteUsers? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount>? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersRemoveUsers? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ApiKey? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateServiceTokenOutput? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ServiceToken? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DeleteServiceToken? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AISecret? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateAISecret? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DeleteAISecret? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchAISecret? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.EnvVar? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.EnvVarObjectType2? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.EnvVarSecretCategory? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.MCPServer? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateMCPServer? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchMCPServer? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetSnapshot? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateDatasetSnapshot? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchDatasetSnapshot? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Environment? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateEnvironment? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchEnvironment? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertResponse? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.InsertEventsResponse>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertRequest? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestExperiment2>? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertRequestExperiment2? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestDataset2>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertRequestDataset2? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestProjectLogs2>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertRequestProjectLogs2? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptData? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>>? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataToolFunctionVariant2Function? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataToolFunctionVariant2FunctionType? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataToolFunctionVariant2Global? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataToolFunctionVariant2GlobalType? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataTemplateFormat? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataOrigin? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionId? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdFunctionId1? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdProjectSlug? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdGlobalFunction? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdPromptSessionId? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlineCode? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlineCodeInlineContext? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlineCodeInlineContextRuntime? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionTypeEnum?, object>? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlineFunction? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlinePrompt? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GitMetadataSettings? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GitMetadataSettingsCollect? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.GitMetadataSettingsField>? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GitMetadataSettingsField? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEval? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.RunEvalDataDatasetId, global::Braintrust.RunEvalDataProjectDatasetName, global::Braintrust.RunEvalDataDatasetRows, global::Braintrust.RunEvalDataExperimentName>? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalDataDatasetId? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalDataProjectDatasetName? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalDataDatasetRows? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalDataExperimentName? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>>? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.InvokeParent?, object>? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.RepoInfo, object>? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.RunEvalMcpAuth2>? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalMcpAuth2? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PostServiceTokenRequest? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PutServiceTokenRequest? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PostEnvVarRequest? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PostEnvVarRequestObjectType? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PutEnvVarRequest? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PutEnvVarRequestObjectType? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchEnvVarIdRequest? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProxycredentialsRequest? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProxycredentialsRequestLogging? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectResponse? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Project>? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetExperimentResponse? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Experiment>? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetDatasetResponse? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Dataset>? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetPromptResponse? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Prompt>? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetRoleResponse? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Role>? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetGroupResponse? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Group>? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectGroupResponse? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectGroup>? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetAclResponse? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetUserResponse? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.User>? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetAgentResponse? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Agent>? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectAutomationResponse? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectAutomation>? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetOrgAutomationResponse? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.OrgAutomation>? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectScoreResponse? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectScore>? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectTagResponse? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectTag>? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetSpanIframeResponse? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.SpanIFrame>? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetFunctionResponse? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Function2>? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetViewResponse? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.View>? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetOrganizationResponse? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Organization>? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetApiKeyResponse? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ApiKey>? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetServiceTokenResponse? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ServiceToken>? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetAiSecretResponse? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AISecret>? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetEnvVarResponse? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.EnvVar>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetMcpServerResponse? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.MCPServer>? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetDatasetSnapshotResponse? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.DatasetSnapshot>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ListEnvironmentsResponse? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Environment>? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProxycredentialsResponse? Type810 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.NamedScore>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectSettingsSpanFieldOrderItem>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectSettingsRemoteEvalSource>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertProjectLogsEventArrayDeleteItem>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object?>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertProjectLogsEvent>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.ProjectLogsEventClassification>>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectLogsEventClassification>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectLogsEvent>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.FeedbackProjectLogsItem>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertExperimentEventArrayDeleteItem>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertExperimentEvent>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.ExperimentEventClassification>>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ExperimentEventClassification>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ExperimentEvent>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.FeedbackExperimentItem>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertDatasetEventArrayDeleteItem>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertDatasetEvent>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.DatasetEventClassification>>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.DatasetEventClassification>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.DatasetEvent>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.FeedbackDatasetItem>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPartText>>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPartText>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPart>>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPart>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ChatCompletionMessageToolCall>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ChatCompletionMessageReasoning>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ChatCompletionMessageParam>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.RoleMemberPermission>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.CreateRoleMemberPermission>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PatchRoleAddMemberPermission>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PatchRoleRemoveMemberPermission>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Acl>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AclItem>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigActionVariant1, global::Braintrust.WindowedAutomationConfigActionVariant2>>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.TopicMapFunctionAutomation>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectScoreCategory>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectScoreConfigObjectType>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.BatchedFacetDataFacet>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.BatchedFacetDataTopicMap>>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.BatchedFacetDataTopicMap>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PatchOrganizationMembersOutputAddedUser>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.GitMetadataSettingsField>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::System.Guid?, global::System.Collections.Generic.List<global::System.Guid>>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Project>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Experiment>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Dataset>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Prompt>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Role>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Group>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectGroup>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.User>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Agent>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectAutomation>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.OrgAutomation>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectScore>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectTag>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.SpanIFrame>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Function2>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.View>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Organization>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ApiKey>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ServiceToken>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AISecret>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.EnvVar>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.MCPServer>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.DatasetSnapshot>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Environment>? ListType79 { get; set; }
    }
}