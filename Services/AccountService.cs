using BussinessObject.Model;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AccountService
    {
        private readonly IAccountRepository _accountRepository;
        public Account GetAccountByEmail(string email)
        {
            return _accountRepository.GetAccountByEmail(email);
        }
    }
}
