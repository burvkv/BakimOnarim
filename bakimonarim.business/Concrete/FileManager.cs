using bakimonarim.business.Abstracts;
using bakimonarim.core.Utilities.Helpers.File;
using bakimonarim.core.Utilities.Results;
using bakimonarim.entity.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakimonarim.business.Concrete
{
    public class FileManager : IFileService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IFileHelper _fileHelper;

        public FileManager(UserManager<ApplicationUser> userManager, IFileHelper fileHelper)
        {
            _userManager = userManager;
            _fileHelper = fileHelper;
           
        }

        public async Task<IResult> Add(IFormFile file, ApplicationUser user)
        {
            if (!String.IsNullOrEmpty(user.ImagePath))
            {
                _fileHelper.Remove(user.ImagePath);
            }
            var imageResult = _fileHelper.Upload(file);
            if (!imageResult.Success)
            {
                return new ErrorResult("Resim Yüklenemedi.");
            }
            
            user.ImagePath = imageResult.Message;
            await _userManager.UpdateAsync(user);
            return new SuccessResult("Resim yükleme başarılı!");
        }

      
    }
}
