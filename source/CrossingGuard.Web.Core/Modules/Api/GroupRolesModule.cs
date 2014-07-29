namespace CrossingGuard.Web.Core.Modules.Api {
    using Nancy;
    using Nancy.ModelBinding;
    public class GroupRolesModule : NancyModule {
        public GroupRolesModule() : base("/api/GroupRoles") {
            Get["/{groupKey}"] = _ => {
                return HttpStatusCode.OK;
            };
            Post["/Assign"] = _ => {
                var model = this.Bind<Models.GroupRoleAssignmentModel>();
                return HttpStatusCode.OK;
            };
            Post["/Unassign"] = _ => {
                var model = this.Bind<Models.GroupRoleRemovalModel>();
                return HttpStatusCode.OK;
            };
        }
    }
}