namespace CrossingGuard.AppManager.Host.Core.Modules.Api {
    using Nancy;
    using Nancy.ModelBinding;
    public class PermissionsModule : NancyModule {
        public PermissionsModule() : base("/api/Permissions") {
            Get["/"] = _ => {
                return HttpStatusCode.OK;
            };
            Get["/{guid}"] = _ => {
                return HttpStatusCode.OK;
            };
        }
    }
}