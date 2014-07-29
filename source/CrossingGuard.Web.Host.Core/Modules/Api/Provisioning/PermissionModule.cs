namespace CrossingGuard.Web.Host.Core.Modules.Api.Provisioning {
    using Nancy;
    using Nancy.ModelBinding;
    public class PermissionModule : NancyModule {
        public PermissionModule() : base("/api/Application/{applicationId}/Permissions") {
            Get["/"] = _ => {
                return HttpStatusCode.OK;
            };
        }
    }
}
