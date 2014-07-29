namespace CrossingGuard.Web.Core.Models {
    class GroupRoleRemovalModel {
        public string GroupKey { get; set; }
        public RoleAssignmentModel[] Assignments { get; set; }

        public class RoleAssignmentModel {
            public string RoleGUID { get; set; }
            public string AccountGUID { get; set; }
        }
    }
}