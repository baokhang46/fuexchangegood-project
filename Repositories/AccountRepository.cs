using BussinessObject.Model;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AccountRepository
    {
        public Account GetAccountByEmail(string email)
            => AccountDAO.GetAccountByEmail(email);
    }
}
