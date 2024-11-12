using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussinessobject;
using Microsoft.Identity.Client;

namespace service
{
    public interface IUserAccountService
    {
        UserAccount? GetUserAccountByEmail(string email, string password); // Định nghĩa mới
        List<UserAccount> GetUserAccounts();
    }
}
