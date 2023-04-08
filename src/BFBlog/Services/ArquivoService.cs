using BFBlog.Interfaces;

namespace BFBlog.Services
{
    public class ArquivoService : IArquivoService
    {
        private readonly IWebHostEnvironment _env;

        private readonly string[] arrExtensoesPermitidas = new string[] { ".jpg", ".jpeg", ".png", ".pdf", ".bitmap" };
        private readonly string[] arrExtensoesPermitidasImagens = new string[] { ".jpg", ".jpeg", ".png", ".bitmap" };

        public ArquivoService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task<string?> UploadArquivo(IFormFile file)
        {
            if (file == null) return null;

            var extensao = Path.GetExtension(file.FileName);

            if (!arrExtensoesPermitidas.Contains(extensao))
                throw new Exception($"A extensão {extensao} não é permitida.");

            var folderPath = Path.Combine(_env.WebRootPath, @"files");
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(folderPath, fileName);

            Directory.CreateDirectory(folderPath);

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                await file.CopyToAsync(fs);
            }

            return fileName;
        }

        public async Task<string?> UploadAvatar(IFormFile file, string identity)
        {
            if (file == null) return null;

            var extensao = Path.GetExtension(file.FileName);

            if (!arrExtensoesPermitidas.Contains(extensao))
                throw new Exception($"A extensão {extensao} não é permitida.");

            var folderPath = Path.Combine(_env.WebRootPath, $"avatar/");
            var fileName = identity + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(folderPath, fileName);

            Directory.CreateDirectory(folderPath);

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                await file.CopyToAsync(fs);
            }

            return fileName;
        }
    }
}
