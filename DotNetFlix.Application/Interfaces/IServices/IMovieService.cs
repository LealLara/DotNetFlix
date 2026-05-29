using DotNetFlix.Domain.Models;

namespace DotNetFlix.Application.Interfaces.Services
{
    public interface IMovieService
    { 
        Stream GetVideoStream(string fileName);

        /// <summary>
        /// Obtém a lista de vídeos para exibição em formato de carrossel na aplicação,
        /// utilizando a URL base da requisição atual para compor os caminhos dos vídeos.
        /// </summary>
        /// <returns>
        /// Retorna uma lista de vídeos formatados para exibição em carrossel.
        /// </returns>
        List<VideoModel> GetCarouselVideos(string baseUrl);
    }
}