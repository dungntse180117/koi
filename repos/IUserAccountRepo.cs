using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussinessobject;

namespace repos
{
    public interface IUserAccountRepo
    {
        UserAccount? GetUserAccountByEmail(string email, string password);

        public List<UserAccount> GetUserAccounts();
    }
}
