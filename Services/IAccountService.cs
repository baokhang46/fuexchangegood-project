using BussinessObject.Model;

namespace Services
{
    public interface IAccountService
    {
        Account GetAccountByEmail(string email);
    }
}
