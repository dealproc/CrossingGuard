namespace CrossingGuard.Web.Host.Core.Modules.Api.Provisioning {
    using Nancy;
    using Nancy.ModelBinding;
    public class DeviceRequestModule : NancyModule {
        public DeviceRequestModule() : base("/api/Application/{applicationId}/Hardware/Requests") {
            Get["/"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Post["/Approve"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Post["/Reject"] = _ => {
                // query and return all accounts.
                return "all products";
            };
        }
    }
}