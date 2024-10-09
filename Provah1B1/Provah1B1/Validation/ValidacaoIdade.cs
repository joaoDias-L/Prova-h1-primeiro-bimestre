using System.ComponentModel.DataAnnotations;

namespace Provah1B1.Validation
{
    public class ValidacaoIdade : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null)
            {
                return new ValidationResult("Não pode ser nulo");
            }

            int idade = (int)value;

            return idade <= 15 ? ValidationResult.Success : new ValidationResult(ErrorMessage);
        }
    }
}
