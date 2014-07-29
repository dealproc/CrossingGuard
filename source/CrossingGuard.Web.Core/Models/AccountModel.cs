namespace CrossingGuard.Web.Core.Models {
    public class AccountModel {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value><c>true</c> if this instance is active; otherwise, <c>false</c>.</value>
        public bool IsActive { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is locked out.
        /// </summary>
        /// <value><c>true</c> if this instance is locked out; otherwise, <c>false</c>.</value>
        public bool IsLockedOut { get; set; }
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>The unique identifier.</value>
        public string GUID { get; set; }
        public string DatabaseName { get; set; }
        public string Hostname { get; set; }
        public int NumberOfDevices { get; set; }
    }
}