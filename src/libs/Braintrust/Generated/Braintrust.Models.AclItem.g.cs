
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// An ACL grants a certain permission or role to a certain user or group on an object.<br/>
    /// ACLs are inherited across the object hierarchy. So for example, if a user has read permissions on a project, they will also have read permissions on any experiment, dataset, etc. created within that project.<br/>
    /// To restrict a grant to a particular sub-object, you may specify `restrict_object_type` in the ACL, as part of a direct permission grant or as part of a role.
    /// </summary>
    public sealed partial class AclItem
    {
        /// <summary>
        /// The object type that the ACL applies to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AclObjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.AclObjectType ObjectType { get; set; }

        /// <summary>
        /// The id of the object the ACL applies to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ObjectId { get; set; }

        /// <summary>
        /// Id of the user the ACL applies to. Exactly one of `user_id` and `group_id` will be provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Id of the group the ACL applies to. Exactly one of `user_id` and `group_id` will be provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public global::System.Guid? GroupId { get; set; }

        /// <summary>
        /// Permission the ACL grants. Exactly one of `permission` and `role_id` will be provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        public global::Braintrust.Permission? Permission { get; set; }

        /// <summary>
        /// When setting a permission directly, optionally restricts the permission grant to just the specified object type. Cannot be set alongside a `role_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrict_object_type")]
        public global::Braintrust.AclObjectType? RestrictObjectType { get; set; }

        /// <summary>
        /// Id of the role the ACL grants. Exactly one of `permission` and `role_id` will be provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public global::System.Guid? RoleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AclItem" /> class.
        /// </summary>
        /// <param name="objectType">
        /// The object type that the ACL applies to
        /// </param>
        /// <param name="objectId">
        /// The id of the object the ACL applies to
        /// </param>
        /// <param name="userId">
        /// Id of the user the ACL applies to. Exactly one of `user_id` and `group_id` will be provided
        /// </param>
        /// <param name="groupId">
        /// Id of the group the ACL applies to. Exactly one of `user_id` and `group_id` will be provided
        /// </param>
        /// <param name="permission">
        /// Permission the ACL grants. Exactly one of `permission` and `role_id` will be provided
        /// </param>
        /// <param name="restrictObjectType">
        /// When setting a permission directly, optionally restricts the permission grant to just the specified object type. Cannot be set alongside a `role_id`.
        /// </param>
        /// <param name="roleId">
        /// Id of the role the ACL grants. Exactly one of `permission` and `role_id` will be provided
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AclItem(
            global::Braintrust.AclObjectType objectType,
            global::System.Guid objectId,
            global::System.Guid? userId,
            global::System.Guid? groupId,
            global::Braintrust.Permission? permission,
            global::Braintrust.AclObjectType? restrictObjectType,
            global::System.Guid? roleId)
        {
            this.ObjectType = objectType;
            this.ObjectId = objectId;
            this.UserId = userId;
            this.GroupId = groupId;
            this.Permission = permission;
            this.RestrictObjectType = restrictObjectType;
            this.RoleId = roleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AclItem" /> class.
        /// </summary>
        public AclItem()
        {
        }

    }
}