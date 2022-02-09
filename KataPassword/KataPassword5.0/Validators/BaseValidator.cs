namespace KataPassword.Validators
{
    public class BaseValidator : IValidator
    {
        public ValidationResult Validate(string password)
        {
            return new ValidationResult();
        }

    }
}
