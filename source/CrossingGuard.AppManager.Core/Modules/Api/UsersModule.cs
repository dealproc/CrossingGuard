namespace CrossingGuard.AppManager.Core.Modules.Api {
    using Nancy;
    using Nancy.ModelBinding;
    public class UsersModule : NancyModule {
        public UsersModule() : base("/api/Users") {
            Get["/"] = _ => {
                return HttpStatusCode.OK;
            };
            Get["/{guid}"] = _ => {
                return HttpStatusCode.OK;
            };
            Put["/"] = _ => {
                var model = this.Bind<Models.UserModel>();
                return HttpStatusCode.OK;
            };
            Post["/"] = _ => {
                var model = this.Bind<Models.UserModel>();
                return HttpStatusCode.OK;
            };
            Delete["/{guid}"] = _ => {
                return HttpStatusCode.OK;
            };
        }
    }
}