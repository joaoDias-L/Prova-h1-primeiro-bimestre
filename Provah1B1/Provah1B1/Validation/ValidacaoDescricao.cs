using System.ComponentModel.DataAnnotations;

namespace Provah1B1.Validation
{
    public class ValidacaoDescricao : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null)
            {
                return new ValidationResult("Não pode ser nulo!");
            }

            string carta = (string)value;

            return carta.Length <= 500 ? ValidationResult.Success : new ValidationResult(ErrorMessage);
        }

    }
}
