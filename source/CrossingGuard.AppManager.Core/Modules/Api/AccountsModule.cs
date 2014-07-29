namespace CrossingGuard.AppManager.Core.Modules.Api {
    using Nancy;
    using Nancy.ModelBinding;
    using System;
    public class AccountsModule : NancyModule {
        public AccountsModule()
            : base("/Api/Accounts") {
            Get["GetAllAccounts", "/"] = _ => {
                // query and return all accounts.
                return "all products";
            };
            // How do we support paging scenarios?
            Get["GetAccount", "/{guid}"] = _ => {
                // query and return a single account.
                return HttpStatusCode.OK;
            };
            Put["CreateAccount", "/"] = _ => {
                var model = this.Bind<Models.AccountModel>();
                return HttpStatusCode.OK;
            };
            Post["UpdateAccount", "/"] = _ => {
                var model = this.Bind<Models.AccountModel>();
                return HttpStatusCode.OK;
            };
            Delete["/{guid}"] = _ => {
                Console.WriteLine(_.guid);
                return HttpStatusCode.OK;
            };
        }
    }
    //public class AccountsMetadataMoudle : MetadataModule<AccountsModule> {
    //    public AccountsMetadataMoudle() {
    //        Describe["GetAllAccounts"] = desc => {
    //            
    //        };
    //    }
    //}
}
