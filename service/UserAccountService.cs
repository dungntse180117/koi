﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussinessobject;
using repos;

namespace service
{
    public class UserAccountService : IUserAccountService
    {
        private IUserAccountRepo Service;

        public UserAccountService()
        {
            Service = new UserAccountRepo();
        }
        public UserAccount GetUserAccountByEmail(string email)
        {
            return Service.GetUserAccountByEmail(email);
        }

        public List<UserAccount> GetUserAccounts()
        {
            return Service.GetUserAccounts();
        }
    }
}
