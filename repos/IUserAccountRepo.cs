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
        public UserAccount GetUserAccountByEmail(string email);

        public List<UserAccount> GetUserAccounts();
    }
}
