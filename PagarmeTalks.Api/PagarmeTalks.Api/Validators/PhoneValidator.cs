using FluentValidation;
using PagarmeTalks.Api.Models.Entities;

namespace PagarmeTalks.Api.Validators
{
    public class PhoneValidator : AbstractValidator<Phone>
    {
        public PhoneValidator()
        {
            CascadeMode = CascadeMode.Stop;
            RuleFor(p => p.AreaCode).NotEmpty().WithMessage("{PropertyName} deve ser preenchida.");
        }
    }
}
