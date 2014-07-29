namespace CrossingGuard.AppManager.Host.Core.Modules.Api {
    using Nancy;
    using Nancy.ModelBinding;
    public class GroupMembersModule : NancyModule {
        public GroupMembersModule() : base("/api/GroupMembers") {
            Get["/{guid}"] = _ => {
                return HttpStatusCode.OK;
            };
            Post["/Unassigned"] = _ => {
                var model = this.Bind<Models.GroupUserSearchModel>();
                return HttpStatusCode.OK;
            };
            Post["Assign Users to Group", "/Assign"] = _ => {
                var model = this.Bind<Models.GroupUserAssignmentModel>();
                return HttpStatusCode.OK;
            };
            Post["Unassign Users from Group", "/Unassign"] = _ => {
                var model = this.Bind<Models.GroupUserAssignmentModel>();
                return HttpStatusCode.OK;
            };
        }
    }
}