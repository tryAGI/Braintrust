
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
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant1? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant1Type? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant2? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant2Type? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant3? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant3Type? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant3Severity? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Project? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProject? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProject? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.ProjectSettings, global::Braintrust.PatchProjectSettings>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectSettings? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<string>>>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertEventsResponse? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanType? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanAttributes? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanAttributesPurpose? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanAttributesLogLevel? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ObjectReferenceNullish? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ObjectReferenceNullishObjectType? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEvent? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventMetadata? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventMetrics? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventContext? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertProjectLogsEventArrayDeleteItem>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventArrayDeleteItem? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventRequest? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertProjectLogsEvent>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedFunctionIdFunction? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedFunctionIdGlobal? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEvent? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventLogId? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventMetadata? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventMetrics? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventContext? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.ProjectLogsEventClassification>>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectLogsEventClassification>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventClassification? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FetchProjectLogsEventsResponse? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectLogsEvent>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FetchEventsRequest? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackResponseSchema? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackResponseSchemaStatus? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackProjectLogsItem? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackProjectLogsItemSource? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackProjectLogsEventRequest? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.FeedbackProjectLogsItem>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RepoInfo? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Experiment? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentInternalMetadata? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateExperiment? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateExperimentInternalMetadata? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchExperiment? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchExperimentInternalMetadata? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEvent? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventMetadata? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventMetrics? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventContext? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertExperimentEventArrayDeleteItem>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventArrayDeleteItem? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventRequest? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertExperimentEvent>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEvent? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEventMetadata? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEventMetrics? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEventContext? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.ExperimentEventClassification>>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ExperimentEventClassification>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEventClassification? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FetchExperimentEventsResponse? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ExperimentEvent>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackExperimentItem? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackExperimentItemSource? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackExperimentEventRequest? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.FeedbackExperimentItem>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ScoreSummary? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.MetricSummary? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SummarizeExperimentResponse? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.ScoreSummary>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.MetricSummary>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Dataset? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateDataset? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchDataset? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertDatasetEvent? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertDatasetEventMetadata? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertDatasetEventArrayDeleteItem>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertDatasetEventArrayDeleteItem? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertDatasetEventRequest? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertDatasetEvent>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetEvent? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetEventMetadata? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.DatasetEventClassification>>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.DatasetEventClassification>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetEventClassification? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FetchDatasetEventsResponse? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.DatasetEvent>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackDatasetItem? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackDatasetItemSource? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackDatasetEventRequest? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.FeedbackDatasetItem>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DataSummary? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SummarizeDatasetResponse? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetRestorePreviewResponse? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetRestoreRequest? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetRestoreResponse? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartText? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextType? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextCacheControl? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextCacheControlType? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextCacheControlTtl? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitle? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleType? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControl? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlTtl? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitle? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrl? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleType? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControl? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlType? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlTtl? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitle? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudio? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudioFormat? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleType? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControl? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlType? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtl? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileFile? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitle? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleType? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControl? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlType? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlTtl? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPart? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageToolCall? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageToolCallFunction? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageToolCallType? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageReasoning? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParam? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamSystem? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamSystemRole? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamUser? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPart>>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPart>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamUserRole? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamAssistant? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamAssistantRole? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamAssistantFunctionCall? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageToolCall>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageReasoning>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamTool? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamToolRole? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFunction? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFunctionRole? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamDeveloper? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamDeveloperRole? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFallback? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFallbackRole? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullish? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishChat? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishChatType? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageParam>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishCompletion? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishCompletionType? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisions? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsType? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2Item>>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2Item>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2Item? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2ItemRole? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestion? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant1? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant1Type? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant2? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant2Type? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant2Choice>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant2Choice? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, bool?>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3Type? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3Level>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3Level? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatJsonSchema? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<object, string>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullish? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonObject? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonObjectType? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonSchema? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonSchemaType? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishText? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishTextType? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParams? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParams? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionType? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionFunction? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallFunction? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsReasoningEffort? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsChatTemplateKwargs? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsVerbosity? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsAnthropicModelParams? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsGoogleModelParams? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsWindowAIModelParams? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsJsCompletionParams? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptOptionsNullish? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptParserNullish? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptParserNullishType? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorId? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdFunction? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdFunctionType? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorGlobal? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorGlobalType? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorGlobalFunctionType? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorInline? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorInlineType? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullish? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2Function? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2FunctionType? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2Global? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2GlobalType? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishTemplateFormat? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishOrigin? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionTypeEnumNullish? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Prompt? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptLogId? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreatePrompt? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchPrompt? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Permission? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Role? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.RoleMemberPermission>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RoleMemberPermission? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateRole? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.CreateRoleMemberPermission>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateRoleMemberPermission? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchRole? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchRoleAddMemberPermission>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchRoleAddMemberPermission? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchRoleRemoveMemberPermission>? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchRoleRemoveMemberPermission? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Group? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateGroup? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchGroup? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectGroup? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectGroup? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectGroup? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Acl? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclItem? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclBatchUpdateResponse? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Acl>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclBatchUpdateRequest? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AclItem>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.User? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AutomationStatus? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanScope? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanScopeType? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TraceScope? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TraceScopeType? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GroupScope? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GroupScopeType? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GroupScopePlacement? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RetentionObjectType? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfig? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigEventType? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigProductOrigin? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThreshold? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculation? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationType? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationOutput? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationOutputType? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicy? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyCondition? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyNoDataBehavior? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindow? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1, global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1Type? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2Type? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoop? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopDigest? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopDigestWritingStyle? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopHarness? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopReasoningEffort? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopTarget? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopTargetType? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopTargetId? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant1? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant1Type? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant2? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant2Type? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant3? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant3Type? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant3Severity? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationFacetModel? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomation? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2FunctionType? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2GlobalType? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScope? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant1? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant1Type? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant2? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant2Type? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant3? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant3Type? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfig? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigEventType? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2FunctionType? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalType? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.TopicMapFunctionAutomation>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::Braintrust.TopicAutomationConfigBackfillTimeRange>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigBackfillTimeRange? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfig? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfigEventType? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfigAction? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfigActionType? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomation? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1EventType? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1Type? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2Type? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3Type? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3Severity? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2EventType? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1Type? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2Type? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2Format? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1Type? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2Type? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3EventType? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3ObjectType? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3Format? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant4? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant4EventType? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5EventType? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1Type? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2Type? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant3? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant3Type? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant3Severity? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationRuntimeBlock? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomation? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1EventType? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1Type? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2Type? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant3? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant3Type? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant3Severity? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2EventType? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2Format? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1Type? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2Type? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3EventType? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3ObjectType? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3Format? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant4? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant4EventType? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5EventType? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1Type? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2Type? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant3? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant3Type? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant3Severity? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomation? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1EventType? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1Type? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2Type? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant3? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant3Type? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant3Severity? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2EventType? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2Format? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1Type? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2Type? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3EventType? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3ObjectType? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3Format? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant4? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant4EventType? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5EventType? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1Type? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2Type? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3Type? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3Severity? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreCategory? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreCategories? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectScoreCategory>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfig? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigServiceTier? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>>? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2Function? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2Global? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreCondition? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConditionWhen? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConditionBehavior? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConfig? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConfigVisibility? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectScoreConfigObjectType>? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConfigObjectType? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScore? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectScore? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectScore? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectTag? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectTag? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectTag? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanIFrame? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateSpanIFrame? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchSpanIFrame? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundle? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleRuntimeContext? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleRuntimeContextRuntime? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperiment, global::Braintrust.CodeBundleLocationFunction, global::Braintrust.CodeBundleLocationVariant3>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperiment? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentType? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionVariant1? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionVariant1Type? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionScorer? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionScorerType? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionClassifier? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionClassifierType? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationFunction? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationFunctionType? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3Type? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1, global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2>? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1Provider? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2Provider? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdRef? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockData? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataChat? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataChatType? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataCompletion? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataCompletionType? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisions? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsType? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataDecisionsInputVariant2Item>>? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataDecisionsInputVariant2Item>? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsInputVariant2Item? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsInputVariant2ItemRole? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestion? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant1? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant1Type? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant2? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant2Type? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataDecisionsQuestionVariant2Choice>? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant2Choice? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant3? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant3Type? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataDecisionsQuestionVariant3Level>? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant3Level? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNode? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant1? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant1Position? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant1Type? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant2? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant2Position? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant2Type? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant3? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant3Position? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant3Type? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant4? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant4Position? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant4Type? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant5? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant5Position? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant5Type? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant6? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant6Position? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant6Type? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant7? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant7Position? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant7Type? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant8? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant8Position? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant8Type? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdge? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdgeSource? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdgeTarget? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdgePurpose? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphData? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphDataType? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.GraphNode>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.GraphEdge>? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorId? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdFunction? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdFunctionType? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdGlobal? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdGlobalType? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdPreprocessorInline? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdPreprocessorInlineType? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetData? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetDataType? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapGenerationSettings? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapGenerationSettingsAlgorithm? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapGenerationSettingsDimensionReduction? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapData? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataType? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function, global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global>? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2FunctionType? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalType? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataReconcileMode? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetData? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetDataType? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataFacet>? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetDataFacet? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataTopicMap>>? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataTopicMap>? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetDataTopicMap? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionData? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataPrompt? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataPromptType? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCode? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeType? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataCodeData2>? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeData? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataType? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeData2? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataType2? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataRuntimeContext? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataRuntimeContextRuntime? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataRemoteEval? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataRemoteEvalType? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataGlobal? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataGlobalType? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParameters? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParametersType? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParametersSchema? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParametersSchemaType? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulation? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationType? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.FunctionDataSimulationConfigVariant1, global::Braintrust.FunctionDataSimulationConfigVariant2>? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1Initiator? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1Modality? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1AgentVariant1? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1AgentVariant1Type? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1AgentVariant2? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1AgentVariant2Type? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1AgentVariant3? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant1AgentVariant3Type? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant2? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant2Initiator? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant2Modality? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant1, global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant2>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant1? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant1Type? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant2? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant2Type? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataSimulationConfigVariant2AgentVariant2Permissions? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Function2? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionLogId? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionOrigin? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionFunctionSchema? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateFunction? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateFunctionOrigin? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateFunctionFunctionSchema? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullish? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishPrompt? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishPromptType? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCode? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeType? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataNullishCodeData2>? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeData? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataType? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeData2? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataType2? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataRuntimeContext? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataRuntimeContextRuntime? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishRemoteEval? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishRemoteEvalType? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishGlobal? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishGlobalType? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParameters? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParametersType? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParametersSchema? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParametersSchemaType? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulation? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationType? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.FunctionDataNullishSimulationConfigVariant1, global::Braintrust.FunctionDataNullishSimulationConfigVariant2>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1Initiator? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1Modality? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant1? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant1Type? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant2? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant2Type? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant3? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant3Type? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant2? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant2Initiator? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant2Modality? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant2AgentVariant1? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant2AgentVariant1Type? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant2AgentVariant2? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant2AgentVariant2Type? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant2AgentVariant2Permissions? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchFunction? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParent? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParentSpanParentStruct? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParentSpanParentStructObjectType? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParentSpanParentStructRowIds? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.StreamingMode? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeApi? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.InvokeApiMcpAuth2>? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeApiMcpAuth2? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewDataSearch? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewData? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptions? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptions? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsViewType? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptions? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptionsFilterScope? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptions? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure>? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsYMetric? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsYMetricType? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsXAxis? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsXAxisType? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsSymbolGrouping? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetric? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation>? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter>? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsQueryShape? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.View? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewViewType? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateView? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateViewViewType? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchView? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchViewViewType? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DeleteView? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ImageRenderingMode? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Organization? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganization? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersOutput? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersOutputStatus? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchOrganizationMembersOutputAddedUser>? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersOutputAddedUser? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembers? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersInviteUsers? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount>? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersRemoveUsers? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ApiKey? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateServiceTokenOutput? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ServiceToken? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DeleteServiceToken? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AISecret? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateAISecret? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DeleteAISecret? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchAISecret? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.EnvVar? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.EnvVarObjectType2? Type784 { get; set; }
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
        public global::System.Collections.Generic.IList<global::Braintrust.Function2>? Type899 { get; set; }
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
        public global::System.Collections.Generic.List<global::Braintrust.Function2>? ListType77 { get; set; }
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