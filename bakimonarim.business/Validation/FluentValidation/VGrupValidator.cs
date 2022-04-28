using bakimonarim.entity;
using FluentValidation;

namespace bakimonarim.business.Validation.FluentValidation
{
    public class VGrupValidator : AbstractValidator<VGrup>
    {
        public VGrupValidator()
        {
            RuleFor(x=> x.GrupMarka).NotEmpty();
        }
    }
}
