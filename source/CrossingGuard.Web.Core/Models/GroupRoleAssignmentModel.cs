namespace CrossingGuard.Web.Core.Models {
    public class GroupRoleAssignmentModel {
        public string GroupKey { get; set; }
        public string RoleGUID { get; set; }
        public bool ReplaceExistingAssignments { get; set; }
        public string[] AccountGUIDs { get; set; }
    }
}