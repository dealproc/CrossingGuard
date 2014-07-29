namespace CrossingGuard.Web.Host.Core.Modules.Api.Provisioning {
    using Nancy;
    using Nancy.ModelBinding;
    public class GroupMemberModule : NancyModule {
        public GroupMemberModule() : base("/api/Application/{applicationId}/GroupMembers") {
            Get["/{groupKey}"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Post["/Unassigned"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Post["/Assign"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            Post["/Unassign"] = _ => {
                // query and return all accounts.
                return "all products";
            };
        }
    }
}