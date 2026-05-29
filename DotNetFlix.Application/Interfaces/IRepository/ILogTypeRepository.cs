using DotNetFlix.Domain.Models.Structure;

namespace DotNetFlix.Application.Interfaces.IRepository
{
    public interface ILogTypeRepository
    {
        public Task<IEnumerable<LogTypeModel>> GetLogTypes();
    }
}