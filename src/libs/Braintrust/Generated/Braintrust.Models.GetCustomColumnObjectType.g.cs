
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of the object the custom column is scoped to, usually `project`
    /// </summary>
    public enum GetCustomColumnObjectType
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
        OrgAccount,
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
        ProjectGroupProjects,
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
    public static class GetCustomColumnObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCustomColumnObjectType value)
        {
            return value switch
            {
                GetCustomColumnObjectType.AiSecret => "ai_secret",
                GetCustomColumnObjectType.Dataset => "dataset",
                GetCustomColumnObjectType.Experiment => "experiment",
                GetCustomColumnObjectType.Group => "group",
                GetCustomColumnObjectType.OrgAccount => "org_account",
                GetCustomColumnObjectType.OrgAiSecret => "org_ai_secret",
                GetCustomColumnObjectType.OrgAuditLogs => "org_audit_logs",
                GetCustomColumnObjectType.OrgMember => "org_member",
                GetCustomColumnObjectType.OrgProject => "org_project",
                GetCustomColumnObjectType.Organization => "organization",
                GetCustomColumnObjectType.Project => "project",
                GetCustomColumnObjectType.ProjectGroup => "project_group",
                GetCustomColumnObjectType.ProjectGroupProjects => "project_group_projects",
                GetCustomColumnObjectType.ProjectLog => "project_log",
                GetCustomColumnObjectType.Prompt => "prompt",
                GetCustomColumnObjectType.PromptSession => "prompt_session",
                GetCustomColumnObjectType.Role => "role",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCustomColumnObjectType? ToEnum(string value)
        {
            return value switch
            {
                "ai_secret" => GetCustomColumnObjectType.AiSecret,
                "dataset" => GetCustomColumnObjectType.Dataset,
                "experiment" => GetCustomColumnObjectType.Experiment,
                "group" => GetCustomColumnObjectType.Group,
                "org_account" => GetCustomColumnObjectType.OrgAccount,
                "org_ai_secret" => GetCustomColumnObjectType.OrgAiSecret,
                "org_audit_logs" => GetCustomColumnObjectType.OrgAuditLogs,
                "org_member" => GetCustomColumnObjectType.OrgMember,
                "org_project" => GetCustomColumnObjectType.OrgProject,
                "organization" => GetCustomColumnObjectType.Organization,
                "project" => GetCustomColumnObjectType.Project,
                "project_group" => GetCustomColumnObjectType.ProjectGroup,
                "project_group_projects" => GetCustomColumnObjectType.ProjectGroupProjects,
                "project_log" => GetCustomColumnObjectType.ProjectLog,
                "prompt" => GetCustomColumnObjectType.Prompt,
                "prompt_session" => GetCustomColumnObjectType.PromptSession,
                "role" => GetCustomColumnObjectType.Role,
                _ => null,
            };
        }
    }
}