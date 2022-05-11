using bakimonarim.core.Utilities.Results;
using bakimonarim.entity.Identity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakimonarim.business.Abstracts
{
    public interface IFileService
    {
         Task<IResult> Add(IFormFile file, ApplicationUser user);

    }
}
