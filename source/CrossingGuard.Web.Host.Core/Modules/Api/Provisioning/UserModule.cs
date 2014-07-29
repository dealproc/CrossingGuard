namespace CrossingGuard.Web.Host.Core.Modules.Api.Provisioning {
    using Nancy;
    using Nancy.ModelBinding;
    public class UserModule : NancyModule {
        public UserModule() : base("/api/Application/{applicationId}/Users") {
            Get["GetAllUsers", "/"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Get["GetUser", "/{guid}"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Post["SyncUsers", "/Sync"] = _ => {
                // query and return all accounts.
                return "all products";
            };
        }
    }
}
