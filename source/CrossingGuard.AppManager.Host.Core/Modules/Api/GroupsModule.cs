namespace CrossingGuard.AppManager.Host.Core.Modules.Api {
    using Nancy;
    using Nancy.ModelBinding;
    public class GroupsModule : NancyModule {
        public GroupsModule() : base("/api/Groups") {
            Get["/"] = _ => {
                return HttpStatusCode.OK;
            };
            Get["/{groupKey}"] = _ => {
                return HttpStatusCode.OK;
            };
            Get["/TopLevel"] = _ => {
                return HttpStatusCode.OK;
            };
            Get["/{groupKey}/TopLevel"] = _ => {
                return HttpStatusCode.OK;
            };
            Post["/"] = _ => {
                var model = this.Bind<Models.GroupEditModel>();
                return HttpStatusCode.OK;
            };
            Delete["/{groupKey}"] = _ => {
                return HttpStatusCode.OK;
            };
        }
    }
}