using bakimonarim.entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakimonarim.business.Validation.FluentValidation
{
    public class VarlikValidator : AbstractValidator<Varlik>
    {
        public VarlikValidator()
        {
            RuleFor(x => x.VarlikKodu).NotEmpty();
            RuleFor(x => x.VarlikAdi).NotEmpty();
        }
    }
}
