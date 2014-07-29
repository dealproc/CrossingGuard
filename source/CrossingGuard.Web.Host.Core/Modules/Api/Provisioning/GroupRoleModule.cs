namespace CrossingGuard.Web.Host.Core.Modules.Api.Provisioning {
    using Nancy;
    using Nancy.ModelBinding;
    public class GroupRoleModule : NancyModule {
        public GroupRoleModule() : base("/api/Application/{applicationId}/GroupRoles") {
            Get["/{groupKey}"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Post["/Assign"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Post["/Unassign"] = _ => {
                // query and return all accounts.
                return "all products";
            };
        }
    }
}
