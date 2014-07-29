namespace CrossingGuard.Web.Host.Core.Modules.Api.User {
    using Nancy;
    using Nancy.ModelBinding;
    public class UserModule : NancyModule {
        public UserModule() : base("/api/Users") {
            Get["GetAll", "/"] = _ => {
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