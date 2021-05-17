using FluentValidation;
using PagarmeTalks.Api.Models.Entities;

namespace PagarmeTalks.Api.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            CascadeMode = CascadeMode.Stop;

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("A propriedade {PropertyName} deve estar preenchida.")
                .Length(2,20).WithMessage("{PropertyName} deve ter entre {MinLength} e {MaxLength} caracteres");
            
            RuleFor(c => c.Email)
                .NotEmpty().EmailAddress().WithMessage("{PropertyName} deve conter um email válido")
                .MaximumLength(20).WithMessage("{PropertyName} deve conter no máximo {MaxLength} caracteres");
            
            RuleFor(c => c.DocumentType)
                .NotEmpty().Must(IsValidDocumentType).WithMessage("{PropertyName} deve ser cpf ou cnpj");

            RuleFor(c => c.Document)
                .Length(11).WithMessage("{PropertyName} deve conter {MaxLength} caracteres")
                .When(c => c.DocumentType.ToLower().Equals("cpf"), ApplyConditionTo.CurrentValidator)
                .Length(14).WithMessage("{PropertyName} deve conter {MaxLength} caracteres")
                .When(c => c.DocumentType.ToLower().Equals("cnpj"), ApplyConditionTo.CurrentValidator);
            
            RuleFor(c => c.Address).SetValidator(new AddressValidator());
            RuleForEach(c => c.Phones).SetValidator(new PhoneValidator());
        }

        private bool IsValidDocumentType(string doctype)
        {
            return doctype.ToLower().Equals("cpf") || doctype.ToLower().Equals("cnpj");
        }
    }
}
