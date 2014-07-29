namespace CrossingGuard.Web.Host.Core.Modules.Api.Account {
    using Nancy;
    using Nancy.ModelBinding;
    public class AccountModule : NancyModule {
        public AccountModule() : base("/api/Account") {
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
