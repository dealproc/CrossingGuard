namespace CrossingGuard.Web.Core.Modules.Api {
    using Nancy;
    using Nancy.ModelBinding;
    public class RolesModule : NancyModule {
        public RolesModule() : base("/api/Roles") {
            Get["/{guid}"] = _ => {
                return HttpStatusCode.OK;
            };
            Get["/{guid}/options"] = _ => {
                return HttpStatusCode.OK;
            };
            Get["/"] = _ => {
                return HttpStatusCode.OK;
            };
            Put["/"] = _ => {
                var model = this.Bind<Models.RoleEditModel>();
                return HttpStatusCode.OK;
            };
            Post["/"] = _ => {
                var model = this.Bind<Models.RoleEditModel>();
                return HttpStatusCode.OK;
            };
            Delete["/{guid}"] = _ => {
                return HttpStatusCode.OK;
            };
            Get["/AddPermission"] = _ => {
                var model = this.Bind<Models.RolePermissionEditModel>();
                return HttpStatusCode.OK;
            };
            Get["/RemovePermission"] = _ => {
                var model = this.Bind<Models.RolePermissionEditModel>();
                return HttpStatusCode.OK;
            };
            Get["/AddIncludedRole"] = _ => {
                var model = this.Bind<Models.IncludedRoleEditModel>();
                return HttpStatusCode.OK;
            };
            Get["/RemoveIncludedRole"] = _ => {
                var model = this.Bind<Models.IncludedRoleEditModel>();
                return HttpStatusCode.OK;
            };
        }
    }
}