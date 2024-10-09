using System.ComponentModel.DataAnnotations;

namespace Provah1B1.Validation
{
    public class ValidacaoNome : ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null)
            {
                return new ValidationResult("Não pode ser nulo");
            }

            string nome = (string)value;

            return nome.Length >= 3 && nome.Length <= 225 ? ValidationResult.Success : new ValidationResult(ErrorMessage);
        }
    }
}
