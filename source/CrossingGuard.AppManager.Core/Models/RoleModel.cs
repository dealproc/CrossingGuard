namespace CrossingGuard.AppManager.Core.Models {
    using System.Collections.Generic;
    /// <summary>
    /// Class RoleModel.
    /// </summary>
    public class RoleModel {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the included role i ds.
        /// </summary>
        /// <value>The included role i ds.</value>
        public IncludedRoleModel[] IncludedRoles { get; set; }
        /// <summary>
        /// Gets or sets the permission i ds.
        /// </summary>
        /// <value>The permission i ds.</value>
        public PermissionModel[] Permissions { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance has all permissions.
        /// </summary>
        /// <value><c>true</c> if this instance has all permissions; otherwise, <c>false</c>.</value>
        public bool HasAllPermissions { get; set; }
        public string GUID { get; set; }
    }
}