namespace CrossingGuard.Web.Host.Core.Modules.Api.Provisioning {
    using Nancy;
    using Nancy.ModelBinding;
    public class DeviceModule : NancyModule {
        public DeviceModule() : base("/api/Application/{applicationId}/Devices") {
            Get["/{guid}"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Get["/"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Put["/"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Post["/"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Delete["/"] = _ => {
                // query and return all accounts.
                return "all products";
            };
        }
    }
}