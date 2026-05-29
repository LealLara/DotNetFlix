using DotNetFlix.Application.Interfaces.IRepository;
using DotNetFlix.Application.Interfaces.Services.Pattern;
using DotNetFlix.Domain.Models;
using DotNetFlix.Domain.Models.Structure;

namespace DotNetFlix.Application.Services.Pattern
{
    public class PatternAccessService : IPatternAccessService
    {
        //AccountType
        private readonly ILogCriticityRepository _logCriticityRepository;
        private readonly ILogTypeRepository _logTypeRepository;
        private readonly IContactRoleRepository _contactRoleRepository;
        private readonly IAccountTypeRepository _accountTypeRepository;
        private readonly IDocumentTypeRepository _documentTypeRepository;

        public PatternAccessService(IAccountTypeRepository accountTypeRepository,   
             ILogTypeRepository logTypeRepository, ILogCriticityRepository logCriticityRepository, IContactRoleRepository contactRoleRepository, IDocumentTypeRepository documentTypeRepository)
        {
            _accountTypeRepository = accountTypeRepository;
            _logTypeRepository = logTypeRepository;
            _logCriticityRepository = logCriticityRepository;
            _contactRoleRepository = contactRoleRepository;
            _documentTypeRepository = documentTypeRepository;
        }
        public async Task<ResultDataModel> CreatePatternRegister()
        {
            if (_accountTypeRepository.GetAccountTypes() == null)
            {

                //logRepository.CreateLog();
                return await Task.FromResult(new ResultDataModel(false, "Account type repository is not initialized", new List<object>()));
            }
            else
            {
                CreateCriticity();
                CreateLogType();
                CreateContactRole();
                CreateAccountTypes();
                CreateDocumentType();


                var accountTypes = _accountTypeRepository.CreateAccountTypes();
                if (accountTypes == null || !accountTypes.Any())
                {
                    return await Task.FromResult(new ResultDataModel(false, "No account types found", new List<object>()));
                }
            }






            //logTypeRepository.CreateLogTypes();


            //logRepository.CreateLog();


            return await Task.FromResult(new ResultDataModel(true, "Pattern register created successfully", new List<object>()));
        }

        private static async Task<bool> CreateLogType()
        {
            LogTypeModel logType = new();
            logType.CreatePatternLogTypeEntityList();
            var data = await _logTypeRepository.AddLogCriticityList(logType);
            return true;
        }

        private static async Task<bool> CreateCriticity()
        {
            LogCriticityModel criticity = new();
             
            return await _logCriticityRepository.AddLogCriticityList(criticity.CreatePatternLogCriticityEntityList());

        }
    }
}