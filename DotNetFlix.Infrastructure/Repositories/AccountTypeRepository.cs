using DotNetFlix.Application.Interfaces.IRepository;
using DotNetFlix.Domain.Models.Pattern;

namespace DotNetFlix.Infrastructure.Repositories
{
    public class AccountTypeRepository : IAccountTypeRepository
    {
        public Task<IEnumerable<AccountTypeModel>> GetAccountTypes()
        {
            throw new NotImplementedException();
        }
    }
}