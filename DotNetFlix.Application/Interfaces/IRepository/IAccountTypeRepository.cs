using DotNetFlix.Domain.Models.Pattern;

namespace DotNetFlix.Application.Interfaces.IRepository
{
    public interface IAccountTypeRepository
    {
        public Task<IEnumerable<AccountTypeModel>> GetAccountTypes();
    }
}