namespace CrossingGuard.Web.Host.Core.Modules.Api.SoftwarePackage {
    using Nancy;
    using Nancy.ModelBinding;
    public class SoftwarePackageAccountModule : NancyModule {
        public SoftwarePackageAccountModule() : base("/api/SoftwarePackages/{packageId}/Accounts") {
            Get["GetAll", "/"] = _ => {
                return HttpStatusCode.OK;
            };
            Get["/{id}"] = _ => {
                return HttpStatusCode.OK;
            };
            Put["/"] = _ => {
                return HttpStatusCode.OK;
            };
            Post["/"] = _ => {
                return HttpStatusCode.OK;
            };
            Delete["/{id}"] = _ => {
                return HttpStatusCode.OK;
            };
        }
    }
}