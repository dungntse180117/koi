using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Bussinessobject;

namespace dao
{
    public class UserAccountDAO
    {
        private KoifishDbContext context;
        private static UserAccountDAO instance;

        public UserAccountDAO()
        {
            context = new KoifishDbContext();
        }

        public static UserAccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserAccountDAO();

                }
                return instance;
            }
        }

        public UserAccount GetUserAccountByEmail(String email)
        {
            return context.UserAccounts.SingleOrDefault(m => m.Email.Equals(email));
        }

        public List<UserAccount> GetUserAccounts()
        {
            return context.UserAccounts.ToList();
        }
    }
}
