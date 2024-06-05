using BussinessObject.Model;

namespace Repositories
{
    public interface IAccountRepository
    {
        Account GetAccountByEmail(string email);
    }
}
