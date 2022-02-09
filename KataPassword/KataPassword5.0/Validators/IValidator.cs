namespace KataPassword.Validators
{
    public interface IValidator
    {
        ValidationResult Validate(string password);
    }
}
