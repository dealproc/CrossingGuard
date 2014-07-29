namespace CrossingGuard.Web.Host.Core.Modules.Api.SoftwarePackage {
    using Nancy;
    using Nancy.ModelBinding;
    public class SoftwarePackageModule : NancyModule {
        public SoftwarePackageModule() : base("/api/SoftwarePackages") {
            Get["/"] = _ => {
                return HttpStatusCode.OK;
            };
            Get["/{id}"] = _ => {
                return HttpStatusCode.OK;
            };
            Post["/"] = _ => {
                return HttpStatusCode.OK;
            };
            Put["/"] = _ => {
                return HttpStatusCode.OK;
            };
            Delete["/{id}"] = _ => {
                return HttpStatusCode.OK;
            };
        }
    }
}
