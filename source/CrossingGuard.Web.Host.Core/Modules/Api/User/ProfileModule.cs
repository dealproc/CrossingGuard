namespace CrossingGuard.Web.Host.Core.Modules.Api.User {
    using Nancy;
    using Nancy.ModelBinding;
    public class ProfileModule : NancyModule {
        public ProfileModule() : base("/api/Profiles") {
            Get["/"] = _ => {
                return HttpStatusCode.OK;
            };
            Get["/{username}"] = _ => {
                return HttpStatusCode.OK;
            };
            Post["/"] = _ => {
                return HttpStatusCode.OK;
            };
            Put["/"] = _ => {
                return HttpStatusCode.OK;
            };
            Delete["/{username}"] = _ => {
                return HttpStatusCode.OK;
            };
        }
    }
}
