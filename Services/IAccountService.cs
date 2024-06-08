using BussinessObject.Model;

namespace Services
{
    public interface IAccountService
    {
        Account GetAccountByEmail(string email);
        List<Account> GetSystemAccounts();
        Account GetAccountById(int accountId);
        void CreateAccount(Account account);
        void UpdateAccount(Account account);
        void DeactivateSystemAccount(int accountId);
    }
}