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
        public UserAccount GetUserAccountByEmail(String email);

        public List<UserAccount> GetUserAccounts();
    }
}
