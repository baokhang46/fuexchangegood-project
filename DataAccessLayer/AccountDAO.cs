﻿using BussinessObject.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class AccountDAO
    {
        public static Account GetAccountByEmail(string email)
        {
            using var db = new FugoodExchangeContext();
            return db.Accounts.FirstOrDefault(x => x.Email.Equals(email));
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

        public static Account GetAccountById(int accountId)
        {
            using var db = new FugoodExchangeContext();
            return db.Accounts.FirstOrDefault(c => c.AccountId.Equals(accountId));
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

        public static void DeleteSystemAccount(Account account)
        {
            try
            {
                using var context = new FugoodExchangeContext();
                var a = context.Accounts.SingleOrDefault(c => c.AccountId == c.AccountId);
                context.Categories.Remove(a);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
