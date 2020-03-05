using DBServerClient.DataAccess;
using DBServerClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Threading.Tasks;

namespace DBServerClient.Logic
{
    static class LoginRegisterHelper
    {
        public static IDataAccess dataAccess = new DataAccess_PSQL();

        public static Frame mainFrame = null;
        public static async Task<bool> LoginAuthenticateAsync(Organisation org) 
        {
            int auth = await dataAccess.LoginOrgainsationAsync(org);
            return (auth == 0)? false: true;
        }

        public static async Task RegisterAuthenticateAsync(Organisation org)
        {
            await dataAccess.RegisterOrgainsationAsync(org);
        }
    }
}
