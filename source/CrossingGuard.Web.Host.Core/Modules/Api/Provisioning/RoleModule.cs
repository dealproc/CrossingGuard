namespace CrossingGuard.Web.Host.Core.Modules.Api.Provisioning {
    using Nancy;
    using Nancy.ModelBinding;
    public class RoleModule : NancyModule {
        public RoleModule() : base("/api/Application/{applicationId}/Roles") {
            Get["GetRoles", "/"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Post["CreateRole", "/"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Delete["DeleteRole", "/{guid}"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Get["GetRole", "/{guid}"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Get["ForInclusion", "/{guid}/Options"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Post["AddPermissions", "/AddPermissions"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Post["RemovePermissions", "/RemovePermissions"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Post["AddIncludedRoles", "/AddIncludedRoles"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Post["RemoveIncludedRoles", "/RemoveIncludedRoles"] = _ => {
                // query and return all accounts.
                return "all products";
            };
        }
    }
}
