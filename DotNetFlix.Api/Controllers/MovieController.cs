using DotNetFlix.Api.Models.Result;
using DotNetFlix.Domain.Interfaces.IServices;
using DotNetFlix.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetFlix.Api.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _service;
        public MovieController(IMovieService service)
        {
            _service = service;
        }

        /// <summary>
        /// Reproduz um vídeo a partir do nome do arquivo informado, retornando o stream do vídeo com suporte a processamento de intervalo (range),
        /// permitindo controle de reprodução como avançar e retroceder.
        /// </summary>
        /// <param name="fileName">Nome do arquivo de vídeo a ser reproduzido.</param>
        /// <returns>
        /// Retorna o stream do vídeo no formato MP4 caso encontrado; 
        /// caso contrário, retorna uma resposta 404 informando que o arquivo não foi localizado.
        /// </returns>
        [HttpGet("play/{fileName}")]
        public IActionResult Play(string fileName)
        {
            try
            {
                Stream? stream = _service.GetVideoStream(fileName);

                return File(stream, "video/mp4", enableRangeProcessing: true);
            }
            catch (FileNotFoundException)
            {
                return NotFound("Arquivo não encontrado");
            }
        }
        /// <summary>
        /// Obtém a lista de vídeos para exibição em formato de carrossel na aplicação,
        /// utilizando a URL base da requisição atual para compor os caminhos dos vídeos.
        /// </summary>
        /// <returns>
        /// Retorna uma lista de vídeos formatados para exibição em carrossel.
        /// </returns>
        [HttpGet("carousel")]
        public IActionResult GetCarouselVideos()
        {
            string? baseUrl = $"{Request.Scheme}://{Request.Host}";
            List<Video> videos = _service.GetCarouselVideos(baseUrl);

            return Ok(videos);
        }
    }
}