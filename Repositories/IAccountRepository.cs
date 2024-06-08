using BussinessObject.Model;

namespace Repositories
{
    public interface IAccountRepository
    {
        Account GetAccountByEmail(string email);
        List<Account> GetSystemAccounts();
        Account GetAccountById(int accountId);
        void CreateAccount(Account account);
        void UpdateAccount(Account account);
        void DeactivateSystemAccount(int accountId);
    }
}