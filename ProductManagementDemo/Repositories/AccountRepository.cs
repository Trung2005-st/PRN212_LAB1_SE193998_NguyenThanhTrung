using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public AccountMember GetAccountById(string accountID)
        {
           return AccountDAO.GetAccountById(accountID);
        }
    }
}
