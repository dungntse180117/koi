using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussinessobject;
using dao;

namespace repos
{
    public class UserAccountRepo : IUserAccountRepo
    {
        public UserAccount GetUserAccountByEmail(string email) => UserAccountDAO.Instance.GetUserAccountByEmail(email);
        

        public List<UserAccount> GetUserAccounts() => UserAccountDAO.Instance.GetUserAccounts();
        
    }
}
