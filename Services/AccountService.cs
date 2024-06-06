using BussinessObject.Model;
using Microsoft.EntityFrameworkCore;
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

        public static void CreateAccount(Account account)
        {
            try
            {
                using var context = new FugoodExchangeContext();
                context.Accounts.Add(account);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void UpdateAccount(Account account)
        {
            try
            {
                using var context = new FugoodExchangeContext();
                context.Entry<Account>(account).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static List<Account> GetSystemAccounts()
        {
            var listSystemAccounts = new List<Account>();
            try
            {
                using var db = new FugoodExchangeContext();
                listSystemAccounts = db.Accounts.ToList();
            }
            catch (Exception e)
            {

            }
            return listSystemAccounts;
        }

        public static Account GetAccountById(short accountId)
        {
            using var db = new FugoodExchangeContext();
            return db.Accounts.FirstOrDefault(c => c.AccountId == accountId);
        }
    }
}
