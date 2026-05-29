using DotNetFlix.Application.Interfaces.IRepository;
using DotNetFlix.Domain.Entities.Access;
using DotNetFlix.Domain.Entities.LogData;
using DotNetFlix.Domain.Models.Structure;
using DotNetFlix.Infrastructure.Data.Context; 

namespace DotNetFlix.Infrastructure.Repositories
{
    public class LogCriticityRepository : ILogCriticityRepository
    {
        private readonly AppDbContext _context;

        public LogCriticityRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<LogCriticityModel>> GetLogCriticity()
        {
            IQueryable<LogCriticityEntity> logCriticities = _context.LogCriticities;

            return ModelFactory.CreateLogCriticityModel(logCriticities);
        }
        public async Task<bool> AddLogCriticityList(List<LogCriticityEntity> logCriticities)
        {
            _context.LogCriticities.AddRange(logCriticities);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<LogCriticityModel>> GetLogCriticityByFilters(LogCriticityModel filters)
        {
            IQueryable<LogCriticityEntity> logCriticities = _context.LogCriticities.Where(x => x.LogCriticityId == filters.LogCriticityId && (filters.LogCriticity == null || filters.LogCriticity.Contains(x.LogCriticity)) && (filters.LogCriticityDescription == null || filters.LogCriticityDescription.Contains(x.LogCriticityDescription)));

            return ModelFactory.CreateLogCriticityModel(logCriticities);
        }
    }
}