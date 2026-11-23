
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
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant1HeaderVariant1? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant1HeaderVariant2? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant2? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant2Type? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant3? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant3Type? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertDestinationVariant3Severity? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternAlertMinSeverity? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectSettingsPatternSource>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectSettingsPatternSource? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Project? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProject? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProject? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.ProjectSettings, global::Braintrust.PatchProjectSettings>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectSettings? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<string>>>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertEventsResponse? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanType? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanAttributes? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanAttributesPurpose? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanAttributesLogLevel? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ObjectReferenceNullish? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ObjectReferenceNullishObjectType? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEvent? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventMetadata? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventMetrics? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventContext? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertProjectLogsEventArrayDeleteItem>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventArrayDeleteItem? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertProjectLogsEventRequest? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertProjectLogsEvent>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedFunctionIdFunction? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedFunctionIdGlobal? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEvent? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventLogId? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventMetadata? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventMetrics? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventContext? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.ProjectLogsEventClassification>>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectLogsEventClassification>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectLogsEventClassification? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FetchProjectLogsEventsResponse? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectLogsEvent>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FetchEventsRequest? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackResponseSchema? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackResponseSchemaStatus? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackProjectLogsItem? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackProjectLogsItemSource? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackProjectLogsEventRequest? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.FeedbackProjectLogsItem>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RepoInfo? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Experiment? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentInternalMetadata? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateExperiment? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateExperimentInternalMetadata? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchExperiment? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchExperimentInternalMetadata? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEvent? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventMetadata? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventMetrics? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventContext? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertExperimentEventArrayDeleteItem>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventArrayDeleteItem? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertExperimentEventRequest? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertExperimentEvent>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEvent? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEventMetadata? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEventMetrics? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEventContext? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.ExperimentEventClassification>>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ExperimentEventClassification>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ExperimentEventClassification? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FetchExperimentEventsResponse? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ExperimentEvent>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackExperimentItem? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackExperimentItemSource? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackExperimentEventRequest? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.FeedbackExperimentItem>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ScoreSummary? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.MetricSummary? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SummarizeExperimentResponse? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.ScoreSummary>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.MetricSummary>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Dataset? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateDataset? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchDataset? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertDatasetEvent? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertDatasetEventMetadata? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertDatasetEventArrayDeleteItem>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertDatasetEventArrayDeleteItem? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InsertDatasetEventRequest? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.InsertDatasetEvent>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetEvent? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetEventMetadata? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.DatasetEventClassification>>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.DatasetEventClassification>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetEventClassification? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FetchDatasetEventsResponse? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.DatasetEvent>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackDatasetItem? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackDatasetItemSource? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FeedbackDatasetEventRequest? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.FeedbackDatasetItem>? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DataSummary? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SummarizeDatasetResponse? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetRestorePreviewResponse? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetRestoreRequest? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetRestoreResponse? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartText? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextCacheControl? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextCacheControlType? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextCacheControlTtl? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitle? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleType? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControl? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlTtl? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitle? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrl? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailLow? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleType? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControl? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlType? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlTtl? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitle? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudio? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudioFormat? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleType? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControl? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlType? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtl? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileFile? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitle? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleType? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControl? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlTtl? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionContentPart? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageToolCall? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageToolCallFunction? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageToolCallType? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageReasoning? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParam? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamSystem? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPartText>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamSystemRole? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamUser? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPart>>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionContentPart>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamUserRole? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamAssistant? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamAssistantRole? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamAssistantFunctionCall? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageToolCall>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageReasoning>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamTool? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamToolRole? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFunction? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFunctionRole? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamDeveloper? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamDeveloperRole? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFallback? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ChatCompletionMessageParamFallbackRole? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullish? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishChat? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishChatType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageParam>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishCompletion? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishCompletionType? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisions? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsType? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2Item>>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2Item>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2Item? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2ItemRole? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestion? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant1? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant1Type? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant2? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant2Type? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant2Choice>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant2Choice? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, bool?>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3Type? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3Level>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3Level? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatJsonSchema? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<object, string>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullish? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonObject? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonObjectType? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonSchema? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishJsonSchemaType? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishText? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ResponseFormatNullishTextType? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParams? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParams? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceNone? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceRequired? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunction? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceFunctionFunction? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallAuto? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallNone? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsFunctionCallFunction? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsReasoningEffort? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsChatTemplateKwargs? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsOpenAIModelParamsVerbosity? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsAnthropicModelParams? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsGoogleModelParams? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsWindowAIModelParams? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ModelParamsJsCompletionParams? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptOptionsNullish? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptParserNullish? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptParserNullishType? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorId? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdFunction? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdFunctionType? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorGlobal? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorGlobalType? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorGlobalFunctionType? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorInline? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PreprocessorIdPreprocessorInlineType? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullish? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2Function? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2FunctionType? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2Global? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishToolFunctionVariant2GlobalType? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishTemplateFormat? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataNullishOrigin? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionTypeEnumNullish? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Prompt? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptLogId? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreatePrompt? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchPrompt? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Permission? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Role? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.RoleMemberPermission>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RoleMemberPermission? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateRole? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.CreateRoleMemberPermission>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateRoleMemberPermission? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchRole? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchRoleAddMemberPermission>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchRoleAddMemberPermission? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchRoleRemoveMemberPermission>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchRoleRemoveMemberPermission? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Group? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateGroup? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchGroup? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectGroup? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectGroup? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectGroup? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Acl? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclItem? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclBatchUpdateResponse? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Acl>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AclBatchUpdateRequest? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AclItem>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.User? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AutomationStatus? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanScope? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanScopeType? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TraceScope? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TraceScopeType? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GroupScope? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GroupScopeType? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GroupScopePlacement? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RetentionObjectType? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedPreprocessorId? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedPreprocessorIdFunction? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedPreprocessorIdFunctionType? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedPreprocessorIdPreprocessorGlobal? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedPreprocessorIdPreprocessorGlobalType? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SavedPreprocessorIdPreprocessorGlobalFunctionType? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfig? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigEventType? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigProductOrigin? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThreshold? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculation? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationType? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationOutput? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationOutputType? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicy? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyCondition? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyNoDataBehavior? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindow? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1, global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2>? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1Type? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2Type? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoop? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopDigest? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopDigestWritingStyle? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopHarness? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopReasoningEffort? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopTarget? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopTargetType? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigLoopTargetId? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigPatterns? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant1? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant1Type? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.WindowedAutomationConfigActionVariant1HeaderVariant1, global::Braintrust.WindowedAutomationConfigActionVariant1HeaderVariant2>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant1HeaderVariant1? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant1HeaderVariant2? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant2? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant2Type? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant3? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant3Type? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.WindowedAutomationConfigActionVariant3Severity? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationFacetModel? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomation? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function, global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global>? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Function? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2FunctionType? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2Global? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapFunctionAutomationFunctionVariant2GlobalType? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScope? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant1? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant1Type? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant2? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant2Type? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant3? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationDataScopeVariant3Type? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfig? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigEventType? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2FunctionType? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalType? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.TopicMapFunctionAutomation>? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope>? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::Braintrust.TopicAutomationConfigBackfillTimeRange>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicAutomationConfigBackfillTimeRange? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfig? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfigEventType? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfigAction? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicDigestAutomationConfigActionType? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomation? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1EventType? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1Type? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1HeaderVariant1? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant1HeaderVariant2? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant2Type? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3Type? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3Severity? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2EventType? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant1Type? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant2Type? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2Format? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1, global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2>? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant1Type? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant2CredentialsVariant2Type? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3EventType? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3ObjectType? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant3Format? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant4? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant4EventType? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5EventType? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1Type? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1HeaderVariant1? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant1HeaderVariant2? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant2Type? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant3? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant3Type? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant3Severity? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectAutomationRuntimeBlock? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomation? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1EventType? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1Type? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1HeaderVariant1? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1HeaderVariant2? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2Type? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant3? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant3Type? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant3Severity? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2EventType? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2Format? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant1Type? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant2CredentialsVariant2Type? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3EventType? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3ObjectType? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant3Format? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant4? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant4EventType? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5EventType? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1Type? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1HeaderVariant1? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant1HeaderVariant2? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant2Type? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant3? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant3Type? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectAutomationConfigVariant5ActionVariant3Severity? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomation? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1EventType? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1Type? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1HeaderVariant1? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant1HeaderVariant2? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant2Type? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant3? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant3Type? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant1ActionVariant3Severity? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2EventType? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2Format? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant1Type? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant2CredentialsVariant2Type? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3EventType? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3ObjectType? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant3Format? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant4? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant4EventType? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5EventType? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1Type? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1HeaderVariant1? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1HeaderVariant2? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant2Type? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3Type? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3Severity? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreCategory? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreCategories? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectScoreCategory>? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfig? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigServiceTier? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2Function? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2FunctionType? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2Global? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OnlineScoreConfigScorerVariant2GlobalType? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreCondition? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConditionWhen? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConditionBehavior? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConfig? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConfigVisibility? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectScoreConfigObjectType>? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScoreConfigObjectType? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectScore? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectScore? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectScore? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProjectTag? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateProjectTag? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchProjectTag? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.SpanIFrame? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateSpanIFrame? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchSpanIFrame? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundle? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleRuntimeContext? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleRuntimeContextRuntime? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperiment, global::Braintrust.CodeBundleLocationFunction, global::Braintrust.CodeBundleLocationVariant3>? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperiment? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentType? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionVariant1? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionVariant1Type? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionScorer? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionScorerType? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionClassifier? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationExperimentPositionClassifierType? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationFunction? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationFunctionType? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3Type? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1, global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2>? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1Provider? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant2Provider? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdRef? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockData? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataChat? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataChatType? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataCompletion? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataCompletionType? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisions? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsType? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataDecisionsInputVariant2Item>>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataDecisionsInputVariant2Item>? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsInputVariant2Item? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsInputVariant2ItemRole? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestion? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant1? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant1Type? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant2? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant2Type? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataDecisionsQuestionVariant2Choice>? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant2Choice? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant3? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant3Type? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataDecisionsQuestionVariant3Level>? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptBlockDataDecisionsQuestionVariant3Level? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNode? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant1? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant1Position? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant1Type? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant2? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant2Position? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant2Type? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant3? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant3Position? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant3Type? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant4? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant4Position? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant4Type? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant5? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant5Position? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant5Type? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant6? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant6Position? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant6Type? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant7? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant7Position? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant7Type? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant8? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant8Position? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphNodeVariant8Type? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdge? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdgeSource? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdgeTarget? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphEdgePurpose? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphData? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GraphDataType? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.GraphNode>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.GraphEdge>? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorId? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdFunction? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdFunctionType? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdGlobal? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdGlobalType? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdPreprocessorInline? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetPreprocessorIdPreprocessorInlineType? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetData? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FacetDataType? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapGenerationSettings? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapGenerationSettingsAlgorithm? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapGenerationSettingsDimensionReduction? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapData? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataType? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function, global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global>? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2FunctionType? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalType? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.TopicMapDataReconcileMode? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetData? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetDataType? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataFacet>? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetDataFacet? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataTopicMap>>? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataTopicMap>? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.BatchedFacetDataTopicMap? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionData? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataPrompt? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataPromptType? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCode? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeType? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataCodeData2>? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionDataCodeData, global::Braintrust.CodeBundle>? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeData? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataType? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeData2? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataType2? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataRuntimeContext? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataCodeDataRuntimeContextRuntime? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataRemoteEval? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataRemoteEvalType? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataGlobal? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataGlobalType? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParameters? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParametersType? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParametersSchema? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataParametersSchemaType? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.TopicMapData, object>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversation? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationType? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.FunctionDataConversationConfigVariant1, global::Braintrust.FunctionDataConversationConfigVariant2>? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1Initiator? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1Modality? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1AgentVariant1? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1AgentVariant1Type? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1AgentVariant2? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1AgentVariant2Type? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1AgentVariant3? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant1AgentVariant3Type? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant2? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant2Initiator? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant2Modality? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.OneOf<global::Braintrust.FunctionDataConversationConfigVariant2AgentVariant1, global::Braintrust.FunctionDataConversationConfigVariant2AgentVariant2>? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant2AgentVariant1? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant2AgentVariant1Type? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant2AgentVariant2? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant2AgentVariant2Type? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataConversationConfigVariant2AgentVariant2Permissions? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Function? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionLogId? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionOrigin? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionFunctionSchema? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateFunction? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateFunctionOrigin? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateFunctionFunctionSchema? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullish? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishPrompt? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishPromptType? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCode? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeType? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>?, global::Braintrust.FunctionDataNullishCodeData2>? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionDataNullishCodeData, global::Braintrust.CodeBundle>? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeData? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataType? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeData2? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataType2? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataRuntimeContext? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishCodeDataRuntimeContextRuntime? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishRemoteEval? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishRemoteEvalType? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishGlobal? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishGlobalType? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParameters? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParametersType? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParametersSchema? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishParametersSchemaType? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversation? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationType? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.FunctionDataNullishConversationConfigVariant1, global::Braintrust.FunctionDataNullishConversationConfigVariant2>? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1Initiator? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1Modality? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1AgentVariant1? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1AgentVariant1Type? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1AgentVariant2? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1AgentVariant2Type? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1AgentVariant3? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant1AgentVariant3Type? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant2? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant2Initiator? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant2Modality? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant2AgentVariant1? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant2AgentVariant1Type? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant2AgentVariant2? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant2AgentVariant2Type? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionDataNullishConversationConfigVariant2AgentVariant2Permissions? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchFunction? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParent? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParentSpanParentStruct? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParentSpanParentStructObjectType? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeParentSpanParentStructRowIds? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.StreamingMode? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeApi? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.InvokeApiMcpAuth2>? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.InvokeApiMcpAuth2? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewDataSearch? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewData? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptions? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptions? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsViewType? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptions? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptionsFilterScope? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptionsSpanType? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsMonitorViewOptionsOptionsType? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptions? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure>? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasureType? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsYMetric? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsYMetricType? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsXAxis? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsXAxisType? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsSymbolGrouping? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsSymbolGroupingType? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetric? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsPointSizeMetricType? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation>? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter>? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsTimeRangeFilter? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewOptionsTableViewOptionsQueryShape? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.View? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ViewViewType? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateView? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateViewViewType? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchView? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchViewViewType? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DeleteView? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ImageRenderingMode? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Organization? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganization? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersOutput? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersOutputStatus? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchOrganizationMembersOutputAddedUser>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersOutputAddedUser? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembers? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersInviteUsers? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchOrganizationMembersRemoveUsers? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ApiKey? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateServiceTokenOutput? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ServiceToken? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DeleteServiceToken? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AISecret? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateAISecret? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DeleteAISecret? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchAISecret? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.EnvVar? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.EnvVarSecretCategory? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.MCPServer? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateMCPServer? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchMCPServer? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.DatasetSnapshot? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateDatasetSnapshot? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchDatasetSnapshot? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.IngestKey? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CustomColumnVariant? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CustomColumn? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.AclObjectType?, global::Braintrust.CustomColumnSubtype?>? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CustomColumnSubtype? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateCustomColumn? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.AclObjectType?, object>? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.AclObjectType?, global::Braintrust.CreateCustomColumnSubtype?>? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateCustomColumnSubtype? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.CustomColumnVariant?, object>? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchCustomColumn? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.Environment? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateEnvironment? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchEnvironment? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertResponse? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.InsertEventsResponse>? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertRequest? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestExperiment2>? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertRequestExperiment2? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestDataset2>? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertRequestDataset2? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.CrossObjectInsertRequestProjectLogs2>? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CrossObjectInsertRequestProjectLogs2? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptData? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>>? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataToolFunctionVariant2Function? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataToolFunctionVariant2FunctionType? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataToolFunctionVariant2Global? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataToolFunctionVariant2GlobalType? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataTemplateFormat? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersType? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PromptDataOrigin? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionId? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdFunctionId1? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdProjectSlug? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdGlobalFunction? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdPromptSessionId? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlineCode? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlineCodeInlineContext? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlineCodeInlineContextRuntime? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionTypeEnum?, object>? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlineFunction? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.FunctionIdInlinePrompt? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GitMetadataSettings? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GitMetadataSettingsCollect? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.GitMetadataSettingsField>? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GitMetadataSettingsField? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEval? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.RunEvalDataDatasetId, global::Braintrust.RunEvalDataProjectDatasetName, global::Braintrust.RunEvalDataDatasetRows, global::Braintrust.RunEvalDataExperimentName>? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalDataDatasetId? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalDataProjectDatasetName? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalDataDatasetRows? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalDataExperimentName? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>>? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.InvokeParent?, object>? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.RepoInfo, object>? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Braintrust.RunEvalMcpAuth2>? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.RunEvalMcpAuth2? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PostServiceTokenRequest? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PutServiceTokenRequest? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PostEnvVarRequest? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PostEnvVarRequestObjectType? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PutEnvVarRequest? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PutEnvVarRequestObjectType? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.PatchEnvVarIdRequest? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateIngestKeyRequest? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProxycredentialsRequest? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProxycredentialsRequestLogging? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetCustomColumnObjectType? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.AclObjectType?, global::Braintrust.GetCustomColumnSubtype2?>? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetCustomColumnSubtype2? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectResponse? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Project>? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetExperimentResponse? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Experiment>? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetDatasetResponse? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Dataset>? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetPromptResponse? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Prompt>? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetRoleResponse? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Role>? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetGroupResponse? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Group>? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectGroupResponse? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectGroup>? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetAclResponse? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetUserResponse? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.User>? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectAutomationResponse? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectAutomation>? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectScoreResponse? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectScore>? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetProjectTagResponse? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectTag>? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetSpanIframeResponse? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.SpanIFrame>? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetFunctionResponse? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Function>? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetViewResponse? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.View>? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetOrganizationResponse? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Organization>? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetOrganizationApiKeysResponse? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ApiKey>? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetApiKeyResponse? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetServiceTokenResponse? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.ServiceToken>? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetAiSecretResponse? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AISecret>? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetEnvVarResponse? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.EnvVar>? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetMcpServerResponse? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.MCPServer>? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetDatasetSnapshotResponse? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.DatasetSnapshot>? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.IngestKey, global::Braintrust.CreateIngestKeyResponse2>? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.CreateIngestKeyResponse2? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ListIngestKeysResponse? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.IngestKey, global::Braintrust.ListIngestKeysResponseObject>>? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AllOf<global::Braintrust.IngestKey, global::Braintrust.ListIngestKeysResponseObject>? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ListIngestKeysResponseObject? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.GetCustomColumnResponse? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.CustomColumn>? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ListEnvironmentsResponse? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Braintrust.Environment>? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.ProxycredentialsResponse? Type954 { get; set; }

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
        public global::System.Collections.Generic.List<global::Braintrust.ProjectSettingsPatternSource>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<string>>>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertProjectLogsEventArrayDeleteItem>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertProjectLogsEvent>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.ProjectLogsEventClassification>>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectLogsEventClassification>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectLogsEvent>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.FeedbackProjectLogsItem>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertExperimentEventArrayDeleteItem>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertExperimentEvent>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.ExperimentEventClassification>>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ExperimentEventClassification>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ExperimentEvent>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.FeedbackExperimentItem>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertDatasetEventArrayDeleteItem>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.InsertDatasetEvent>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.DatasetEventClassification>>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.DatasetEventClassification>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.DatasetEvent>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.FeedbackDatasetItem>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPartText>>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPartText>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPart>>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ChatCompletionContentPart>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ChatCompletionMessageToolCall>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ChatCompletionMessageReasoning>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ChatCompletionMessageParam>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2Item>>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2Item>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant2Choice>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3Level>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.RoleMemberPermission>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.CreateRoleMemberPermission>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PatchRoleAddMemberPermission>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PatchRoleRemoveMemberPermission>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Acl>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AclItem>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.TopicMapFunctionAutomation>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectScoreCategory>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.OnlineScoreConfigScorerVariant2Function, global::Braintrust.OnlineScoreConfigScorerVariant2Global>?>>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectScoreConfigObjectType>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<string, global::System.Collections.Generic.List<global::Braintrust.PromptBlockDataDecisionsInputVariant2Item>>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PromptBlockDataDecisionsInputVariant2Item>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PromptBlockDataDecisionsQuestionVariant2Choice>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PromptBlockDataDecisionsQuestionVariant3Level>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.BatchedFacetDataFacet>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Braintrust.BatchedFacetDataTopicMap>>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.BatchedFacetDataTopicMap>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ViewOptionsTableViewOptionsExcludedMeasure>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ViewOptionsTableViewOptionsChartAnnotation>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PatchOrganizationMembersOutputAddedUser>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.PatchOrganizationMembersInviteUsersServiceAccount>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataToolFunctionVariant2Function, global::Braintrust.PromptDataToolFunctionVariant2Global>?>>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.GitMetadataSettingsField>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::Braintrust.ProjectScoreType?, global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.ProjectScoreType?, object>>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Braintrust.AnyOf<global::System.Guid?, global::System.Collections.Generic.List<global::System.Guid>>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Project>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Experiment>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Dataset>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Prompt>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Role>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Group>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectGroup>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.User>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectAutomation>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectScore>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ProjectTag>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.SpanIFrame>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Function>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.View>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Organization>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ApiKey>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.ServiceToken>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AISecret>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.EnvVar>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.MCPServer>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.DatasetSnapshot>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.AllOf<global::Braintrust.IngestKey, global::Braintrust.ListIngestKeysResponseObject>>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.CustomColumn>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Braintrust.Environment>? ListType89 { get; set; }
    }
}