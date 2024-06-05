using BussinessObject.Model;

namespace DataAccessLayer
{
    public class AccountDAO
    {
        public static Account GetAccountByEmail(string email)
        {
            using var db = new FugoodExchangeContext();
            return db.Accounts.FirstOrDefault(x => x.Email.Equals(email));
        }
    }
}
