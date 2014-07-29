namespace CrossingGuard.Web.Host.Core.Modules.Api.Provisioning {
    using Nancy;
    using Nancy.ModelBinding;
    public class GroupModule : NancyModule {
        public GroupModule() : base("/api/Application/{applicationId}/Groups") {
            Get["GetAllGroups", "/"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Get["GetTopLevelForGroup", "/{groupKey}/TopLevel"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Get["TopLevelGroups", "/TopLevel"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Get["GetGroup", "/{groupKey}"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Post["SaveGroup", "/"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Delete["DeleteGroup", "/{groupKey}"] = _ => {
                // query and return all accounts.
                return "all products";
            };
        }
    }
}