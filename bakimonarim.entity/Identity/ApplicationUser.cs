using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bakimonarim.entity.Identity
{
    public class ApplicationUser:IdentityUser
    {
        public string? ImagePath { get; set; }
    }
}
