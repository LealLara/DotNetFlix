using DotNetFlix.Application.Interfaces.IRepository;
using DotNetFlix.Domain.Models.Structure;

namespace DotNetFlix.Infrastructure.Repositories
{
    public class LogTypeRepository : ILogTypeRepository
    {
        public Task<IEnumerable<LogTypeModel>> GetLogTypes()
        {
            throw new NotImplementedException();
        }
    }
}