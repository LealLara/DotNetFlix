using DotNetFlix.Application.Interfaces.IRepository;
using DotNetFlix.Application.Interfaces.Services;
using DotNetFlix.Domain.Interfaces.IRepository; 
using DotNetFlix.Domain.Models;

namespace DotNetFlix.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repository;

        public MovieService(IMovieRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// Abre um stream somente leitura para o arquivo de vídeo especificado.
        /// </summary>
        /// <param name="fileName">O nome do arquivo de vídeo a ser aberto. Não pode ser nulo ou vazio.</param>
        /// <returns>Um stream para leitura do conteúdo do arquivo de vídeo especificado.</returns>
        /// <exception cref="FileNotFoundException">Lançada quando um arquivo com o nome especificado não é encontrado.</exception>
        public Stream GetVideoStream(string fileName)
        {
            var path = _repository.GetVideoPath(fileName);

            if (!File.Exists(path))
                throw new FileNotFoundException("Arquivo não encontrado");

            return new FileStream(path, FileMode.Open, FileAccess.Read);
        }

        /// <summary>
        /// Obtém a lista de vídeos para exibição em formato de carrossel na aplicação,
        /// utilizando a URL base da requisição atual para compor os caminhos dos vídeos.
        /// </summary>
        /// <returns>
        /// Retorna uma lista de vídeos formatados para exibição em carrossel.
        /// </returns>
        public List<VideoModel> GetCarouselVideos(string baseUrl)
        {
            var files = _repository.GetAllVideos();

            return files.Select(file =>
            {
                var fileName = Path.GetFileName(file);

                return new VideoModel
                {
                    Name = fileName,
                    Url = $"{baseUrl}/api/movies/play/{Uri.EscapeDataString(fileName)}"
                };
            }).ToList();
        }
    }
}