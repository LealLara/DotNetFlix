using DotNetFlix.Domain.Interfaces.IRepository;

namespace DotNetFlix.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly string _folderPath;

        public MovieRepository()
        {
            _folderPath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot",
                "videos",
                "primary"
            );
        }
        /// <summary>
        /// Retorna o caminho completo no sistema de arquivos para um arquivo de vídeo com o nome especificado.
        /// </summary>
        /// <param name="fileName">O nome do arquivo de vídeo. Este valor não deve conter separadores de caminho.</param>
        /// <returns>Uma string contendo o caminho completo do arquivo de vídeo dentro da pasta configurada.</returns>
        public string GetVideoPath(string fileName)
        {
            return Path.Combine(_folderPath, fileName);
        }
        /// <summary>
        /// Retorna o caminho completo no sistema de arquivos para um arquivo de vídeo com o nome especificado.
        /// </summary>
        /// <param name="fileName">O nome do arquivo de vídeo. Este valor não deve conter separadores de caminho.</param>
        /// <returns>Uma string contendo o caminho completo do arquivo de vídeo dentro da pasta configurada.</returns>
        public List<string> GetAllVideos()
        {
            if (!Directory.Exists(_folderPath))
                throw new DirectoryNotFoundException();

            return Directory.GetFiles(_folderPath).ToList();
        }
    }
}