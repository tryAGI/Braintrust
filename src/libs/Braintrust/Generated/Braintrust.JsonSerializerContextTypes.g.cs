
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
        public object? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.NamedScore? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ScoreResult? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.NamedScore>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type10 { get; set; }
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
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertMention? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant1? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant1Type? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant2? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant2Type? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant3? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant3Type? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant3Severity? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Project? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProject? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProject? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.ProjectSettings, global::Braintrust.PatchProjectSettings>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectSettings? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<string>>>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertEventsResponse? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanType? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanAttributes? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanAttributesPurpose? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanAttributesLogLevel? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ObjectReferenceNullish? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ObjectReferenceNullishObjectType? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEvent? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventMetadata? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventMetrics? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventContext? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertProjectLogsEventArrayDeleteItem>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventArrayDeleteItem? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventRequest? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertProjectLogsEvent>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedFunctionIdFunction? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedFunctionIdGlobal? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEvent? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventLogId? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventMetadata? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventMetrics? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventContext? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.ProjectLogsEventClassification>>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectLogsEventClassification>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventClassification? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FetchProjectLogsEventsResponse? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectLogsEvent>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FetchEventsRequest? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackResponseSchema? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackResponseSchemaStatus? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackProjectLogsItem? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackProjectLogsItemSource? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackProjectLogsEventRequest? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.FeedbackProjectLogsItem>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RepoInfo? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Experiment? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentInternalMetadata? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateExperiment? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateExperimentInternalMetadata? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchExperiment? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchExperimentInternalMetadata? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEvent? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventMetadata? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventMetrics? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventContext? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertExperimentEventArrayDeleteItem>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventArrayDeleteItem? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventRequest? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertExperimentEvent>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEvent? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEventMetadata? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEventMetrics? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEventContext? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.ExperimentEventClassification>>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ExperimentEventClassification>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEventClassification? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FetchExperimentEventsResponse? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ExperimentEvent>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackExperimentItem? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackExperimentItemSource? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackExperimentEventRequest? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.FeedbackExperimentItem>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ScoreSummary? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.MetricSummary? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SummarizeExperimentResponse? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.ScoreSummary>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.MetricSummary>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Dataset? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateDataset? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchDataset? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertDatasetEvent? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertDatasetEventMetadata? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertDatasetEventArrayDeleteItem>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertDatasetEventArrayDeleteItem? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertDatasetEventRequest? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertDatasetEvent>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetEvent? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetEventMetadata? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.DatasetEventClassification>>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.DatasetEventClassification>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetEventClassification? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FetchDatasetEventsResponse? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.DatasetEvent>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackDatasetItem? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackDatasetItemSource? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackDatasetEventRequest? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.FeedbackDatasetItem>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DataSummary? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SummarizeDatasetResponse? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetRestorePreviewResponse? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetRestoreRequest? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetRestoreResponse? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartText? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextType? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextCacheControl? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextCacheControlType? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextCacheControlTtl? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitle? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControl? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlTtl? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitle? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrl? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleType? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControl? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlType? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlTtl? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitle? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudio? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudioFormat? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleType? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControl? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlType? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtl? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileFile? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitle? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControl? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlTtl? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPart? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageToolCall? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageToolCallFunction? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageToolCallType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageReasoning? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParam? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamSystem? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamSystemRole? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamUser? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPart>>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPart>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamUserRole? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamAssistant? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamAssistantRole? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamAssistantFunctionCall? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageToolCall>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageReasoning>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamTool? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamToolRole? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFunction? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFunctionRole? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamDeveloper? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamDeveloperRole? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFallback? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFallbackRole? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullish? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishChat? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishChatType? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageParam>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishCompletion? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishCompletionType? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisions? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2Item>>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2Item>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2Item? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2ItemRole? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestion? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant1? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant1Type? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant2? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant2Type? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant2Choice>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant2Choice? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, bool?>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3Type? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3Level>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3Level? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatJsonSchema? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<object, string>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullish? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonObject? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonObjectType? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonSchema? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonSchemaType? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishText? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishTextType? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParams? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParams? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionType? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionFunction? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallFunction? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsReasoningEffort? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsChatTemplateKwargs? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsVerbosity? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsAnthropicModelParams? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsGoogleModelParams? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsWindowAIModelParams? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsJsCompletionParams? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptOptionsNullish? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptParserNullish? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptParserNullishType? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorId? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdFunction? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdFunctionType? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorGlobal? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorGlobalType? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorGlobalFunctionType? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorInline? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorInlineType? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullish? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2Function? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2FunctionType? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2Global? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2GlobalType? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishTemplateFormat? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishOrigin? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionTypeEnumNullish? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Prompt? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptLogId? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreatePrompt? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchPrompt? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Permission? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Role? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.RoleMemberPermission>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RoleMemberPermission? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateRole? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.CreateRoleMemberPermission>? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateRoleMemberPermission? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchRole? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchRoleAddMemberPermission>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchRoleAddMemberPermission? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchRoleRemoveMemberPermission>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchRoleRemoveMemberPermission? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Group? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateGroup? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchGroup? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectGroup? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectGroup? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectGroup? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Acl? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclItem? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclBatchUpdateResponse? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Acl>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclBatchUpdateRequest? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AclItem>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.User? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AutomationStatus? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanScope? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanScopeType? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TraceScope? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TraceScopeType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GroupScope? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GroupScopeType? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GroupScopePlacement? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RetentionObjectType? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfig? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigEventType? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigProductOrigin? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThreshold? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculation? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationType? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationOutput? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationOutputType? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicy? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyCondition? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyNoDataBehavior? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindow? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1, global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1Type? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2Type? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoop? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopDigest? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopDigestWritingStyle? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopHarness? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopReasoningEffort? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopTarget? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopTargetType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopTargetId? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant1? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant1Type? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant2? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant2Type? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant3? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant3Type? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant3Severity? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationFacetModel? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomation? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2FunctionType? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2GlobalType? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScope? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant1? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant1Type? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant2? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant2Type? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant3? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant3Type? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfig? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigEventType? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2FunctionType? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalType? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.TopicMapFunctionAutomation>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::Braintrust.TopicAutomationConfigBackfillTimeRange>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigBackfillTimeRange? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfig? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfigEventType? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfigAction? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfigActionType? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomation? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1EventType? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1Type? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2Type? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3Type? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3Severity? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2EventType? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1Type? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2Type? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2Format? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1Type? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2Type? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3EventType? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3ObjectType? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3Format? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant4? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant4EventType? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5EventType? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1Type? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2Type? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant3? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant3Type? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant3Severity? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationRuntimeBlock? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomation? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1EventType? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1Type? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2Type? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant3? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant3Type? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant3Severity? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2EventType? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2Format? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1Type? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2Type? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3EventType? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3ObjectType? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3Format? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant4? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant4EventType? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5EventType? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1Type? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2Type? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant3? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant3Type? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant3Severity? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomation? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1EventType? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1Type? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2Type? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant3? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant3Type? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant3Severity? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2EventType? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2Format? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1Type? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2Type? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3EventType? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3ObjectType? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3Format? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant4? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant4EventType? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5EventType? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1Type? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2Type? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3Type? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3Severity? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreCategory? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreCategories? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectScoreCategory>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfig? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigServiceTier? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>>? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2Function? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2Global? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreCondition? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConditionWhen? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConditionBehavior? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConfig? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConfigVisibility? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectScoreConfigObjectType>? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConfigObjectType? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScore? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectScore? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectScore? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectTag? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectTag? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectTag? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanIFrame? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateSpanIFrame? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchSpanIFrame? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundle? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleRuntimeContext? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleRuntimeContextRuntime? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperiment, global::Braintrust.CodeBundleLocationFunction, global::Braintrust.CodeBundleLocationVariant3>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperiment? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentType? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionVariant1? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionVariant1Type? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionScorer? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionScorerType? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionClassifier? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionClassifierType? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationFunction? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationFunctionType? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3Type? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1, global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2>? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1Provider? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2Provider? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdRef? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockData? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataChat? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataChatType? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataCompletion? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataCompletionType? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisions? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsType? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataDecisionsInputVariant2Item>>? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataDecisionsInputVariant2Item>? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsInputVariant2Item? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsInputVariant2ItemRole? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestion? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant1? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant1Type? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant2? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant2Type? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataDecisionsQuestionVariant2Choice>? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant2Choice? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant3? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant3Type? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataDecisionsQuestionVariant3Level>? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant3Level? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNode? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant1? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant1Position? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant1Type? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant2? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant2Position? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant2Type? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant3? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant3Position? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant3Type? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant4? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant4Position? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant4Type? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant5? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant5Position? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant5Type? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant6? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant6Position? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant6Type? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant7? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant7Position? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant7Type? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant8? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant8Position? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant8Type? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdge? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdgeSource? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdgeTarget? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdgePurpose? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphData? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphDataType? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.GraphNode>? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.GraphEdge>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorId? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdFunction? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdFunctionType? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdGlobal? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdGlobalType? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdPreprocessorInline? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdPreprocessorInlineType? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetData? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetDataType? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapGenerationSettings? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapGenerationSettingsAlgorithm? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapGenerationSettingsDimensionReduction? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapData? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataType? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function, global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global>? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2FunctionType? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalType? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataReconcileMode? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetData? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetDataType? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataFacet>? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetDataFacet? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataTopicMap>>? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataTopicMap>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetDataTopicMap? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionData? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataPrompt? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataPromptType? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCode? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeType? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataCodeData2>? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeData? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataType? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeData2? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataType2? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataRuntimeContext? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataRuntimeContextRuntime? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataRemoteEval? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataRemoteEvalType? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataGlobal? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataGlobalType? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParameters? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParametersType? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParametersSchema? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParametersSchemaType? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversation? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationType? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.FunctionDataConversationConfigVariant1, global::Braintrust.FunctionDataConversationConfigVariant2>? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1Initiator? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1Modality? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1AgentVariant1? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1AgentVariant1Type? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1AgentVariant2? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1AgentVariant2Type? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1AgentVariant3? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1AgentVariant3Type? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant2? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant2Initiator? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant2Modality? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.FunctionDataConversationConfigVariant2AgentVariant1, global::Braintrust.FunctionDataConversationConfigVariant2AgentVariant2>? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant2AgentVariant1? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant2AgentVariant1Type? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant2AgentVariant2? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant2AgentVariant2Type? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant2AgentVariant2Permissions? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Function? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionLogId? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionOrigin? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionFunctionSchema? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateFunction? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateFunctionOrigin? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateFunctionFunctionSchema? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullish? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishPrompt? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishPromptType? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCode? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeType? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataNullishCodeData2>? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeData? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataType? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeData2? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataType2? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataRuntimeContext? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataRuntimeContextRuntime? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishRemoteEval? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishRemoteEvalType? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishGlobal? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishGlobalType? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParameters? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParametersType? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParametersSchema? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParametersSchemaType? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversation? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationType? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.FunctionDataNullishConversationConfigVariant1, global::Braintrust.FunctionDataNullishConversationConfigVariant2>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1Initiator? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1Modality? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1AgentVariant1? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1AgentVariant1Type? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1AgentVariant2? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1AgentVariant2Type? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1AgentVariant3? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1AgentVariant3Type? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant2? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant2Initiator? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant2Modality? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant2AgentVariant1? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant2AgentVariant1Type? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant2AgentVariant2? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant2AgentVariant2Type? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant2AgentVariant2Permissions? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchFunction? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParent? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParentSpanParentStruct? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParentSpanParentStructObjectType? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParentSpanParentStructRowIds? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.StreamingMode? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeApi? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.InvokeApiMcpAuth2>? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeApiMcpAuth2? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewDataSearch? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewData? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptions? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptions? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsViewType? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptions? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptionsFilterScope? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptions? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure>? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsYMetric? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsYMetricType? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsXAxis? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsXAxisType? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsSymbolGrouping? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetric? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation>? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter>? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsQueryShape? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.View? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewViewType? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateView? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateViewViewType? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchView? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchViewViewType? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DeleteView? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ImageRenderingMode? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Organization? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganization? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersOutput? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersOutputStatus? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchOrganizationMembersOutputAddedUser>? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersOutputAddedUser? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembers? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersInviteUsers? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount>? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersRemoveUsers? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ApiKey? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateServiceTokenOutput? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ServiceToken? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DeleteServiceToken? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AISecret? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateAISecret? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DeleteAISecret? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchAISecret? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.EnvVar? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.EnvVarSecretCategory? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.MCPServer? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateMCPServer? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchMCPServer? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetSnapshot? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateDatasetSnapshot? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchDatasetSnapshot? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.IngestKey? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CustomColumnVariant? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CustomColumn? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.AclObjectType?, global::Braintrust.CustomColumnSubtype?>? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CustomColumnSubtype? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateCustomColumn? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.AclObjectType?, object>? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.AclObjectType?, global::Braintrust.CreateCustomColumnSubtype?>? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateCustomColumnSubtype? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.CustomColumnVariant?, object>? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchCustomColumn? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Environment? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateEnvironment? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchEnvironment? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertResponse? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.InsertEventsResponse>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertRequest? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestExperiment2>? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertRequestExperiment2? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestDataset2>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertRequestDataset2? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestProjectLogs2>? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertRequestProjectLogs2? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptData? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>>? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataToolFunctionVariant2Function? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataToolFunctionVariant2FunctionType? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataToolFunctionVariant2Global? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataToolFunctionVariant2GlobalType? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataTemplateFormat? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataOrigin? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionId? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdFunctionId1? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdProjectSlug? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdGlobalFunction? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdPromptSessionId? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlineCode? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlineCodeInlineContext? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlineCodeInlineContextRuntime? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionTypeEnum?, object>? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlineFunction? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlinePrompt? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GitMetadataSettings? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GitMetadataSettingsCollect? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.GitMetadataSettingsField>? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GitMetadataSettingsField? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEval? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.RunEvalDataDatasetId, global::Braintrust.RunEvalDataProjectDatasetName, global::Braintrust.RunEvalDataDatasetRows, global::Braintrust.RunEvalDataExperimentName>? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalDataDatasetId? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalDataProjectDatasetName? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalDataDatasetRows? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalDataExperimentName? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>>? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.InvokeParent?, object>? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.RepoInfo, object>? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.RunEvalMcpAuth2>? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalMcpAuth2? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PostServiceTokenRequest? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PutServiceTokenRequest? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PostEnvVarRequest? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PostEnvVarRequestObjectType? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PutEnvVarRequest? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PutEnvVarRequestObjectType? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchEnvVarIdRequest? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateIngestKeyRequest? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProxycredentialsRequest? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProxycredentialsRequestLogging? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetCustomColumnObjectType? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.AclObjectType?, global::Braintrust.GetCustomColumnSubtype2?>? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetCustomColumnSubtype2? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectResponse? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Project>? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetExperimentResponse? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Experiment>? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetDatasetResponse? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Dataset>? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetPromptResponse? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Prompt>? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetRoleResponse? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Role>? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetGroupResponse? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Group>? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectGroupResponse? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectGroup>? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetAclResponse? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetUserResponse? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.User>? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectAutomationResponse? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectAutomation>? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectScoreResponse? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectScore>? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectTagResponse? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectTag>? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetSpanIframeResponse? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.SpanIFrame>? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetFunctionResponse? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Function>? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetViewResponse? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.View>? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetOrganizationResponse? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Organization>? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetOrganizationApiKeysResponse? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ApiKey>? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetApiKeyResponse? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetServiceTokenResponse? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ServiceToken>? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetAiSecretResponse? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AISecret>? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetEnvVarResponse? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.EnvVar>? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetMcpServerResponse? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.MCPServer>? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetDatasetSnapshotResponse? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.DatasetSnapshot>? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.IngestKey, global::Braintrust.CreateIngestKeyResponse2>? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateIngestKeyResponse2? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ListIngestKeysResponse? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.IngestKey, global::Braintrust.ListIngestKeysResponseObject>>? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.IngestKey, global::Braintrust.ListIngestKeysResponseObject>? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ListIngestKeysResponseObject? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetCustomColumnResponse? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.CustomColumn>? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ListEnvironmentsResponse? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Environment>? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProxycredentialsResponse? Type927 { get; set; }

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
        public global::System.Collections.Generic.List<global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<string>>>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertProjectLogsEventArrayDeleteItem>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertProjectLogsEvent>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.ProjectLogsEventClassification>>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectLogsEventClassification>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectLogsEvent>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.FeedbackProjectLogsItem>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertExperimentEventArrayDeleteItem>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertExperimentEvent>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.ExperimentEventClassification>>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ExperimentEventClassification>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ExperimentEvent>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.FeedbackExperimentItem>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertDatasetEventArrayDeleteItem>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertDatasetEvent>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.DatasetEventClassification>>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.DatasetEventClassification>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.DatasetEvent>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.FeedbackDatasetItem>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPartText>>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPartText>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPart>>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPart>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ChatCompletionMessageToolCall>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ChatCompletionMessageReasoning>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ChatCompletionMessageParam>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2Item>>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2Item>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant2Choice>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3Level>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.RoleMemberPermission>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.CreateRoleMemberPermission>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PatchRoleAddMemberPermission>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PatchRoleRemoveMemberPermission>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Acl>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AclItem>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.TopicMapFunctionAutomation>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectScoreCategory>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectScoreConfigObjectType>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<global::Braintrust.PromptBlockDataDecisionsInputVariant2Item>>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PromptBlockDataDecisionsInputVariant2Item>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PromptBlockDataDecisionsQuestionVariant2Choice>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PromptBlockDataDecisionsQuestionVariant3Level>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.BatchedFacetDataFacet>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.BatchedFacetDataTopicMap>>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.BatchedFacetDataTopicMap>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PatchOrganizationMembersOutputAddedUser>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.GitMetadataSettingsField>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::System.Guid?, global::System.Collections.Generic.List<global::System.Guid>>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Project>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Experiment>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Dataset>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Prompt>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Role>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Group>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectGroup>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.User>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectAutomation>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectScore>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectTag>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.SpanIFrame>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Function>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.View>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Organization>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ApiKey>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ServiceToken>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AISecret>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.EnvVar>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.MCPServer>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.DatasetSnapshot>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.IngestKey, global::Braintrust.ListIngestKeysResponseObject>>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.CustomColumn>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Environment>? ListType88 { get; set; }
    }
}