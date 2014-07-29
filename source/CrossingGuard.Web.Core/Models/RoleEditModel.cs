namespace CrossingGuard.Web.Core.Models {
    public class RoleEditModel {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the roles included in this role.
        /// </summary>
        /// <value>The included roles.</value>
        public string[] IncludedRoles { get; set; }
        /// <summary>
        /// Gets or sets the role permissions.
        /// </summary>
        /// <value>The permissions.</value>
        public string[] Permissions { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance has all permissions.
        /// </summary>
        /// <value><c>true</c> if this instance has all permissions; otherwise, <c>false</c>.</value>
        public bool HasAllPermissions { get; set; }
        public string GUID { get; set; }
    }
}