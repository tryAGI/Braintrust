
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

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
        public global::System.DateTime? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Ids? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewType? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.UserGivenName? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.UserFamilyName? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.UserEmail? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclObjectType? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclListOrgObjectType? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclListPermission? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclListRestrictObjectType? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreType? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AISecretType? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.EnvVarObjectType? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionTypeEnum? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.NullableSavedFunctionIdFunction? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.NullableSavedFunctionIdGlobal? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettings? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectSettingsSpanFieldOrderItem>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsSpanFieldOrderItem? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant1?, global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant2?>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant1? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsSpanFieldOrderItemLayoutVariant2? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectSettingsRemoteEvalSource>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsRemoteEvalSource? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Project? Type38 { get; set; }
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
        public global::Braintrust.DatasetRestorePreviewResponse? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetRestoreRequest? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetRestoreResponse? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartText? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextType? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextCacheControl? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextCacheControlType? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextCacheControlTtl? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitle? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleType? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControl? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlTtl? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitle? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrl? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleType? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControl? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlType? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlTtl? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitle? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudio? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudioFormat? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControl? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlType? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtl? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileFile? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitle? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleType? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControl? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlType? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlTtl? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPart? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageToolCall? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageToolCallFunction? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageToolCallType? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageReasoning? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParam? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamSystem? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamSystemRole? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamUser? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPart>>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPart>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamUserRole? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamAssistant? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamAssistantRole? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamAssistantFunctionCall? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageToolCall>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageReasoning>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamTool? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamToolRole? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFunction? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFunctionRole? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamDeveloper? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamDeveloperRole? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFallback? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFallbackRole? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullish? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishChat? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishChatType? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageParam>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishCompletion? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishCompletionType? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatJsonSchema? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::System.Collections.Generic.Dictionary<string, object?>, string>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullish? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonObject? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonObjectType? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonSchema? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonSchemaType? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishText? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishTextType? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParams? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParams? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionType? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionFunction? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallFunction? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsReasoningEffort? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsChatTemplateKwargs? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsVerbosity? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsAnthropicModelParams? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsGoogleModelParams? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsWindowAIModelParams? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsJsCompletionParams? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptOptionsNullish? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptParserNullish? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptParserNullishType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorId? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdFunction? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdFunctionType? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorGlobal? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorGlobalType? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorGlobalFunctionType? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorInline? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorInlineType? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullish? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2Function? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2FunctionType? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2Global? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2GlobalType? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishTemplateFormat? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishOrigin? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionTypeEnumNullish? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Prompt? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptLogId? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreatePrompt? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchPrompt? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Permission? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Role? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.RoleMemberPermission>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RoleMemberPermission? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateRole? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.CreateRoleMemberPermission>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateRoleMemberPermission? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchRole? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchRoleAddMemberPermission>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchRoleAddMemberPermission? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchRoleRemoveMemberPermission>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchRoleRemoveMemberPermission? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Group? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateGroup? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchGroup? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectGroup? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectGroup? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectGroup? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Acl? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclItem? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclBatchUpdateResponse? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Acl>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclBatchUpdateRequest? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AclItem>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.User? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Agent? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateAgent? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchAgent? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AutomationStatus? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanScope? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanScopeType? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TraceScope? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TraceScopeType? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GroupScope? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GroupScopeType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GroupScopePlacement? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RetentionObjectType? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfig? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigEventType? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigProductOrigin? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThreshold? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculation? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationType? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationOutput? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationOutputType? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicy? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyCondition? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyNoDataBehavior? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindow? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1, global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1Type? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2Type? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoop? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopHarness? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopReasoningEffort? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopTarget? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopTargetType? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::System.Guid?, global::Braintrust.WindowedAutomationConfigLoopTargetId?>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopTargetId? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant1? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant1Type? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant2? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant2Type? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant3? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant3Type? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant3Severity? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationFacetModel? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomation? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2FunctionType? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2GlobalType? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScope? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant1? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant1Type? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant2? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant2Type? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant3? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant3Type? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfig? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigEventType? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2FunctionType? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalType? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.TopicMapFunctionAutomation>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::Braintrust.TopicAutomationConfigBackfillTimeRange>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigBackfillTimeRange? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfig? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfigEventType? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfigAction? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfigActionType? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomation? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1EventType? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1Type? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2Type? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3Type? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3Severity? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2EventType? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1Type? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2Type? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2Format? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1Type? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2Type? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3EventType? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3ObjectType? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3Format? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant4? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant4EventType? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5EventType? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1Type? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2Type? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant3? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant3Type? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant3Severity? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationRuntimeBlock? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomation? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1EventType? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1Type? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2Type? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant3? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant3Type? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant3Severity? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2EventType? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2Format? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1Type? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2Type? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3EventType? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3ObjectType? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3Format? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant4? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant4EventType? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5EventType? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1Type? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2Type? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant3? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant3Type? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant3Severity? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomation? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1EventType? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1Type? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2Type? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant3? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant3Type? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant3Severity? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2EventType? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2Format? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1Type? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2Type? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3EventType? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3ObjectType? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3Format? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant4? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant4EventType? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5EventType? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1Type? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2Type? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3Type? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3Severity? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OrgAutomation? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OrgAutomationConfig? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OrgAutomationConfigEventType? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateOrgAutomation? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateOrgAutomationConfig? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateOrgAutomationConfigEventType? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrgAutomation? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrgAutomationConfig? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrgAutomationConfigEventType? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreCategory? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreCategories? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectScoreCategory>? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfig? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>>? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2Function? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2Global? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreCondition? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConditionWhen? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConditionBehavior? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConfig? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConfigVisibility? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectScoreConfigObjectType>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConfigObjectType? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScore? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectScore? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectScore? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectTag? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectTag? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectTag? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanIFrame? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateSpanIFrame? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchSpanIFrame? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundle? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleRuntimeContext? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleRuntimeContextRuntime? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperiment, global::Braintrust.CodeBundleLocationFunction, global::Braintrust.CodeBundleLocationVariant3>? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperiment? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentType? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionVariant1? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionVariant1Type? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionScorer? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionScorerType? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionClassifier? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionClassifierType? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationFunction? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationFunctionType? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3Type? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1, global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2>? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1Provider? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2Provider? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockData? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataChat? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataChatType? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataCompletion? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataCompletionType? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNode? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant1? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant1Position? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant1Type? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant2? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant2Position? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant2Type? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant3? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant3Position? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant3Type? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant4? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant4Position? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant4Type? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant5? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant5Position? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant5Type? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant6? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant6Position? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant6Type? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant7? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant7Position? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant7Type? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant8? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant8Position? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant8Type? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdge? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdgeSource? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdgeTarget? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdgePurpose? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphData? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphDataType? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.GraphNode>? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.GraphEdge>? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorId? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdFunction? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdFunctionType? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdGlobal? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdGlobalType? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdPreprocessorInline? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdPreprocessorInlineType? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetData? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetDataType? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapGenerationSettings? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapGenerationSettingsAlgorithm? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapGenerationSettingsDimensionReduction? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapData? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataType? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function, global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global>? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2FunctionType? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalType? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataReconcileMode? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetData? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetDataType? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataFacet>? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetDataFacet? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataTopicMap>>? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataTopicMap>? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetDataTopicMap? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionData? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataPrompt? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataPromptType? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCode? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeType? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataCodeData2>? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeData? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataType? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeData2? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataType2? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataRuntimeContext? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataRuntimeContextRuntime? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataRemoteEval? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataRemoteEvalType? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataGlobal? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataGlobalType? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParameters? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParametersType? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParametersSchema? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParametersSchemaType? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, object?>>? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulation? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationType? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.FunctionDataSimulationConfigVariant1, global::Braintrust.FunctionDataSimulationConfigVariant2>? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1Initiator? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1Modality? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1AgentVariant1? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1AgentVariant1Type? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1AgentVariant2? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1AgentVariant2Type? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1AgentVariant3? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1AgentVariant3Type? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant2? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant2Initiator? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant2Modality? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant1, global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant2>? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant1? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant1Type? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant2? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant2Type? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant2Permissions? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Function2? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionLogId? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionOrigin? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionFunctionSchema? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateFunction? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateFunctionOrigin? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateFunctionFunctionSchema? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullish? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishPrompt? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishPromptType? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCode? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeType? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataNullishCodeData2>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeData? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataType? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeData2? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataType2? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataRuntimeContext? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataRuntimeContextRuntime? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishRemoteEval? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishRemoteEvalType? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishGlobal? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishGlobalType? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParameters? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParametersType? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParametersSchema? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParametersSchemaType? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulation? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationType? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.FunctionDataNullishSimulationConfigVariant1, global::Braintrust.FunctionDataNullishSimulationConfigVariant2>? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1Initiator? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1Modality? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant1? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant1Type? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant2? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant2Type? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant3? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant3Type? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant2? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant2Initiator? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant2Modality? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant2AgentVariant1? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant2AgentVariant1Type? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant2AgentVariant2? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant2AgentVariant2Type? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant2AgentVariant2Permissions? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchFunction? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParent? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParentSpanParentStruct? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParentSpanParentStructObjectType? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParentSpanParentStructRowIds? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.StreamingMode? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeApi? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.InvokeApiMcpAuth2>? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeApiMcpAuth2? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewDataSearch? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewData? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptions? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptions? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsViewType? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptions? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptionsFilterScope? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptions? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsYMetric? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsYMetricType? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsXAxis? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsXAxisType? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsSymbolGrouping? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetric? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation>? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter>? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsQueryShape? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.View? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewViewType? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateView? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateViewViewType? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchView? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchViewViewType? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DeleteView? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ImageRenderingMode? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Organization? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganization? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersOutput? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersOutputStatus? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchOrganizationMembersOutputAddedUser>? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersOutputAddedUser? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembers? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersInviteUsers? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount>? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersRemoveUsers? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ApiKey? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateServiceTokenOutput? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ServiceToken? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DeleteServiceToken? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AISecret? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateAISecret? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DeleteAISecret? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchAISecret? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.EnvVar? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.EnvVarObjectType2? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.EnvVarSecretCategory? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.MCPServer? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateMCPServer? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchMCPServer? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetSnapshot? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateDatasetSnapshot? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchDatasetSnapshot? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SimulatedUserVoiceConfig? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SimulatedUser? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateSimulatedUser? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchSimulatedUser? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Environment? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateEnvironment? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchEnvironment? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertResponse? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.InsertEventsResponse>? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertRequest? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestExperiment2>? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertRequestExperiment2? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestDataset2>? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertRequestDataset2? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestProjectLogs2>? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertRequestProjectLogs2? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptData? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>>? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataToolFunctionVariant2Function? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataToolFunctionVariant2FunctionType? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataToolFunctionVariant2Global? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataToolFunctionVariant2GlobalType? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataTemplateFormat? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataOrigin? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionId? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdFunctionId1? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdProjectSlug? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdGlobalFunction? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdPromptSessionId? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlineCode? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlineCodeInlineContext? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlineCodeInlineContextRuntime? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionTypeEnum?, object>? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlineFunction? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlinePrompt? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GitMetadataSettings? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GitMetadataSettingsCollect? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.GitMetadataSettingsField>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GitMetadataSettingsField? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEval? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.RunEvalDataDatasetId, global::Braintrust.RunEvalDataProjectDatasetName, global::Braintrust.RunEvalDataDatasetRows, global::Braintrust.RunEvalDataExperimentName>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalDataDatasetId? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalDataProjectDatasetName? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalDataDatasetRows? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalDataExperimentName? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.InvokeParent?, object>? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.RepoInfo, object>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.RunEvalMcpAuth2>? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalMcpAuth2? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PostServiceTokenRequest? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PutServiceTokenRequest? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PostEnvVarRequest? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PostEnvVarRequestObjectType? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PutEnvVarRequest? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PutEnvVarRequestObjectType? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchEnvVarIdRequest? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProxycredentialsRequest? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProxycredentialsRequestLogging? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectResponse? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Project>? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetExperimentResponse? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Experiment>? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetDatasetResponse? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Dataset>? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetPromptResponse? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Prompt>? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetRoleResponse? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Role>? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetGroupResponse? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Group>? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectGroupResponse? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectGroup>? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetAclResponse? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetUserResponse? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.User>? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetAgentResponse? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Agent>? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectAutomationResponse? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectAutomation>? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetOrgAutomationResponse? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.OrgAutomation>? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectScoreResponse? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectScore>? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectTagResponse? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectTag>? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetSpanIframeResponse? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.SpanIFrame>? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetFunctionResponse? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Function2>? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetViewResponse? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.View>? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetOrganizationResponse? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Organization>? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetOrganizationApiKeysResponse? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ApiKey>? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetApiKeyResponse? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetServiceTokenResponse? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ServiceToken>? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetAiSecretResponse? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AISecret>? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetEnvVarResponse? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.EnvVar>? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetMcpServerResponse? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.MCPServer>? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetDatasetSnapshotResponse? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.DatasetSnapshot>? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ListSimulatedUsersResponse? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.SimulatedUser>? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ListEnvironmentsResponse? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Environment>? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProxycredentialsResponse? Type879 { get; set; }

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
        public global::System.Collections.Generic.List<global::Braintrust.TopicMapFunctionAutomation>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectScoreCategory>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectScoreConfigObjectType>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.BatchedFacetDataFacet>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.BatchedFacetDataTopicMap>>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.BatchedFacetDataTopicMap>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PatchOrganizationMembersOutputAddedUser>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.GitMetadataSettingsField>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::System.Guid?, global::System.Collections.Generic.List<global::System.Guid>>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Project>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Experiment>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Dataset>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Prompt>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Role>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Group>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectGroup>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.User>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Agent>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectAutomation>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.OrgAutomation>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectScore>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectTag>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.SpanIFrame>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Function2>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.View>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Organization>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ApiKey>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ServiceToken>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AISecret>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.EnvVar>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.MCPServer>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.DatasetSnapshot>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.SimulatedUser>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Environment>? ListType79 { get; set; }
    }
}