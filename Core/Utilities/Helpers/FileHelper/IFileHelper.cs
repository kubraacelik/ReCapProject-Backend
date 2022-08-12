using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Helpers.FileHelper
{
    public interface IFileHelper
    {
        string Upload(IFormFile file, string root);//Yükleme (Fotoğrafın nereye kaydedileceğini ve dosyayı  veriyorsun.)
        void Delete(string filePath);//Dosya yolunu silme
        string Update(IFormFile file, string filePath, string root);//dosyayı veriyorsun dosya yolu dosyanın kaydedileceği yerde güncelleniyor

    }
}
