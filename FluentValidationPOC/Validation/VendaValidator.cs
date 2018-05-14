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

            RuleFor(x => x.Tipo)
                .IsInEnum<Venda, TipoVenda>()
                .WithMessage("Tipo precisa ter Tipo Venda.");

            RuleFor(x => x.Itens)
                .NotNull()
                .WithMessage("Itens não pode ser nulo.")
                .Must(x => x != null ? x.Count > 0 : false)
                .WithMessage("Deve conter pelo menos 1 item");
        }
    }
}
