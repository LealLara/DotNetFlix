namespace DotNetFlix.Domain.Interfaces.IRepository
{
    public interface IMovieRepository
    {
        /// <summary>
        /// Retorna o caminho completo no sistema de arquivos para um arquivo de vídeo com o nome especificado.
        /// </summary>
        /// <param name="fileName">O nome do arquivo de vídeo. Este valor não deve conter separadores de caminho.</param>
        /// <returns>Uma string contendo o caminho completo do arquivo de vídeo dentro da pasta configurada.</returns>
        string GetVideoPath(string fileName);
        /// <summary>
        /// Retorna o caminho completo no sistema de arquivos para um arquivo de vídeo com o nome especificado.
        /// </summary>
        /// <param name="fileName">O nome do arquivo de vídeo. Este valor não deve conter separadores de caminho.</param>
        /// <returns>Uma string contendo o caminho completo do arquivo de vídeo dentro da pasta configurada.</returns>
        List<string> GetAllVideos();
    }
}