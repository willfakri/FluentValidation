using FluentValidation;
using FluentValidationPOC.Entities;
using System;

namespace FluentValidationPOC.Validation
{
    class VendaValidator : AbstractValidator<Venda>
    {
        public VendaValidator()
        {
            RuleFor(x => x.Data)
                .NotNull().WithMessage("A data não pode ser nula.")
                .LessThanOrEqualTo(DateTime.Today).WithMessage("Não pode ser data futura.");
        }
    }
}
