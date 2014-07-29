namespace CrossingGuard.Web.Core.Models {
    public class GroupEditModel {
        public string Name { get; set; }
        public string GroupKey { get; set; }
        public string Description { get; set; }
        public string[] ParentGroupKeys { get; set; }
    }
}