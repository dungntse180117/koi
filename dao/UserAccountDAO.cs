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
        private static UserAccountDAO instance = new UserAccountDAO();

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

        public UserAccount? GetUserAccountByEmail(string email, string password)
        {
            string normalizedEmail = email.ToLower();

            return context.UserAccounts
                .SingleOrDefault(m => m.Email.ToLower() == normalizedEmail && m.Password == password);
        }

        public List<UserAccount> GetUserAccounts()
        {
            return context.UserAccounts.ToList();
        }
    }
}
