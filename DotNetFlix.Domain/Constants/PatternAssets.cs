namespace DotNetFlix.Domain.Constants
{
    public static class PatternAssets
    {
        #region PatternApplicationData
      
        #region Log

        #region PatternLogCriticity
        public const string FirstPatternLogCriticity = "Alta";
        public const string SecondPatternLogCriticity = "Média";
        public const string ThirdPatternLogCriticity = "Baixa";

        public const string FirstPatternLogCriticityDescription = "Prioridade alta para logs de criticidade.";
        public const string SecondPatternLogCriticityDescription = "Prioridade média para logs de criticidade.";
        public const string ThirdPatternLogCriticityDescription = "Prioridade baixa para logs de criticidade.";

        #endregion

        #region PatternLogType
        public const string FirstPatternLogType = "Registro criado.";
        public const string SecondPatternLogType = "Registro atualizado.";
        public const string ThirdPatternLogType = "Registro excluído.";
        public const string FourthPatternLogType = "Falha interna. Consulte o log.";
        public const string FifthPatternLogType = "Falha na validação dos dados informados.";
        public const string SixthPatternLogType = "Acesso Negado.";
        public const string SeventhPatternLogType = "Inválido.";
        public const string EighthPatternLogType = "Sucesso.";


        public const string FirstPatternLogTypeDescription = "Log de criação de registro.";
        public const string SecondPatternLogTypeDescription = "Log de atualização de registro.";
        public const string ThirdPatternLogTypeDescription = "Log de exclusão de registro.";
        public const string FourthPatternLogTypeDescription = "Log de falha interna.";
        public const string FifthPatternLogTypeDescription = "Log de falha na validação dos dados.";
        public const string SixthPatternLogTypeDescription = "Log de acesso negado.";
        public const string SeventhPatternLogTypeDescription = "Log de dado inválido.";
        public const string EighthPatternLogTypeDescription = "Log de sucesso da operação.";

        #endregion

        #endregion

        #region PatternDocumentType
        public const string FirstPatternDocumenType = "CPF";
        public const string SecondPatternDocumenType = "CNPJ";
        public const string ThirdPatternDocumenType = "RG";
        public const string FourthPatternDocumenType = "CNH";
        public const string FifthPatternDocumenType = "Certificado";
        #endregion

        #region PatternContactRole
        public const string FirstPatternContactRole = "Pessoal";
        public const string SecondPatternContactRole = "Trabalho";
        public const string ThirdPatternContactRole = "Comercial";
        public const string FourthPatternContactRole = "Residencial";
        public const string FifthPatternContactRole = "Referência";
        public const string SixthPatternContactRole = "Serviço";
        public const string SeventhPatternContactRole = "Whatsapp";
        public const string EighthPatternContactRole = "Celular";
        public const string NinthPatternContactRole = "Fixo";
        #endregion

        #region PatternAccountType
        public const string FirstPatternAccountType = "Criança";
        public const string SecondPatternAccountType = "Família";
        public const string ThirdPatternAccountType = "Individual";

        #endregion
         
        #endregion

        #region PatternUserData
         
        public const string FirstPatternNickName = "janeLOL";

        public const string FirstPatternUserName = "Jane smith";

        public const string PatternPassword = "P@ssw0rd!";

        public const string PatternCPFDocument = "123 456 789 00";
        public const string PatternRGDocument = "123 456 789 00";
        public const string PatternCNPJDocument = "12 345 678 0001 00";

        public const string FirstPatternPhone = "9 9999-9999";
        public const string SecondPatternPhone = "9 8888-888";
        public const string FirstPatternEmail = "contact@domain.com";
        public const string SecondPatternEmail = "contact_test@domain.com";
         
        #endregion
    }
}