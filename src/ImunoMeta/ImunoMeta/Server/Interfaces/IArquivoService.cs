namespace ImunoMeta.Server.Interfaces
{
    public interface IArquivoService
    {
        Task<string?> UploadArquivo(IFormFile file);
        Task<string?> UploadAvatar(IFormFile file, string identity);
    }
}
