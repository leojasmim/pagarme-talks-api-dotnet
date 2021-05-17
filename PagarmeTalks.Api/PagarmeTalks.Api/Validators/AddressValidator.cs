using FluentValidation;
using PagarmeTalks.Api.Models.Entities;

namespace PagarmeTalks.Api.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            CascadeMode = CascadeMode.Stop;

            RuleFor(a => a.Street).NotEmpty().WithMessage("{PropertyName} deve estar preenchida");
            RuleFor(a => a.Number).NotEmpty().WithMessage("{PropertyName} deve estar preenchida");
            RuleFor(a => a.City).NotEmpty().WithMessage("{PropertyName} deve estar preenchida");
            RuleFor(a => a.State).NotEmpty().WithMessage("{PropertyName} deve estar preenchida");
        }
    }
}
