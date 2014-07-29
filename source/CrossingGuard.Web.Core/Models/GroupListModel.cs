using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossingGuard.Web.Core.Models {
    public class GroupListModel {
        public string Name { get; set; }
        public string GroupKey { get; set; }
        public string Description { get; set; }
        public long RoleCount { get; set; }
        public long UserCount { get; set; }
        public bool ProtectFromDeletion { get; set; }
    }
}
