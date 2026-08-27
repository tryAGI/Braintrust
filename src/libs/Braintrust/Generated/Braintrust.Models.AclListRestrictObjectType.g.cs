
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The object type that the ACL applies to
    /// </summary>
    public enum AclListRestrictObjectType
    {
        /// <summary>
        ///
        /// </summary>
        AiSecret,
        /// <summary>
        ///
        /// </summary>
        Dataset,
        /// <summary>
        ///
        /// </summary>
        Experiment,
        /// <summary>
        ///
        /// </summary>
        Group,
        /// <summary>
        ///
        /// </summary>
        OrgAiSecret,
        /// <summary>
        ///
        /// </summary>
        OrgAuditLogs,
        /// <summary>
        ///
        /// </summary>
        OrgMember,
        /// <summary>
        ///
        /// </summary>
        OrgProject,
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        Project,
        /// <summary>
        ///
        /// </summary>
        ProjectGroup,
        /// <summary>
        ///
        /// </summary>
        ProjectLog,
        /// <summary>
        ///
        /// </summary>
        Prompt,
        /// <summary>
        ///
        /// </summary>
        PromptSession,
        /// <summary>
        ///
        /// </summary>
        Role,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AclListRestrictObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AclListRestrictObjectType value)
        {
            return value switch
            {
                AclListRestrictObjectType.AiSecret => "ai_secret",
                AclListRestrictObjectType.Dataset => "dataset",
                AclListRestrictObjectType.Experiment => "experiment",
                AclListRestrictObjectType.Group => "group",
                AclListRestrictObjectType.OrgAiSecret => "org_ai_secret",
                AclListRestrictObjectType.OrgAuditLogs => "org_audit_logs",
                AclListRestrictObjectType.OrgMember => "org_member",
                AclListRestrictObjectType.OrgProject => "org_project",
                AclListRestrictObjectType.Organization => "organization",
                AclListRestrictObjectType.Project => "project",
                AclListRestrictObjectType.ProjectGroup => "project_group",
                AclListRestrictObjectType.ProjectLog => "project_log",
                AclListRestrictObjectType.Prompt => "prompt",
                AclListRestrictObjectType.PromptSession => "prompt_session",
                AclListRestrictObjectType.Role => "role",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AclListRestrictObjectType? ToEnum(string value)
        {
            return value switch
            {
                "ai_secret" => AclListRestrictObjectType.AiSecret,
                "dataset" => AclListRestrictObjectType.Dataset,
                "experiment" => AclListRestrictObjectType.Experiment,
                "group" => AclListRestrictObjectType.Group,
                "org_ai_secret" => AclListRestrictObjectType.OrgAiSecret,
                "org_audit_logs" => AclListRestrictObjectType.OrgAuditLogs,
                "org_member" => AclListRestrictObjectType.OrgMember,
                "org_project" => AclListRestrictObjectType.OrgProject,
                "organization" => AclListRestrictObjectType.Organization,
                "project" => AclListRestrictObjectType.Project,
                "project_group" => AclListRestrictObjectType.ProjectGroup,
                "project_log" => AclListRestrictObjectType.ProjectLog,
                "prompt" => AclListRestrictObjectType.Prompt,
                "prompt_session" => AclListRestrictObjectType.PromptSession,
                "role" => AclListRestrictObjectType.Role,
                _ => null,
            };
        }
    }
}