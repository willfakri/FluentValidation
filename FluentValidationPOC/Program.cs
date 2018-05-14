using FluentValidation.Results;
using FluentValidationPOC.Entities;
using FluentValidationPOC.Validation;
using System;
using System.Linq;

namespace FluentValidationPOC
{
    class Program
    {
        static void Main(string[] args)
        {

            var venda = new Venda()
            {
                Data = DateTime.Today,
                Tipo = TipoVenda.Brinde
            };

            var validator = new VendaValidator();

            ValidationResult result = validator.Validate(venda);

            if (result.IsValid)
            {
                Console.WriteLine("Sucesso!");
            }
            else
            {
                result.Errors.ToList().ForEach(e => Console.WriteLine($"{e.PropertyName} : {e.ErrorMessage}"));
            }

            Console.ReadKey();
        }
    }
}
