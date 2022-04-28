using bakimonarim.core.Utilities.Results;
using Microsoft.AspNetCore.Http;

namespace bakimonarim.core.Utilities.Helpers.File
{
    public interface IFileHelper
    {
        void RemoveOldFile(string directory);
        void CreateFile(string directory, IFormFile file);
        void CheckDirectoryExist(string directory);
        IResult CheckFileTypeValid(string type);
        IResult CheckFileExist(IFormFile file);
        IResult Upload(IFormFile file);
        IResult Update(IFormFile file, string imagePath);
        IResult Remove(string path);
    }

    
}
