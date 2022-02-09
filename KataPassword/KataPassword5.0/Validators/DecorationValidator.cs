namespace KataPassword.Validators
{
    public sealed class DecorationValidator : IValidator
    {
        private PasswordRule Rule { get; init; }
        private readonly IValidator inner;

        public DecorationValidator(PasswordRule rule, IValidator innerValidator)
        {
            inner = innerValidator;
            Rule = rule;
        }

        public ValidationResult Validate(string password)
        {
            var myValidation = inner.Validate(password);
            if (!Rule.Check(password))
            {
                myValidation.IsValid = false;
                myValidation.ErrorDescription.Add(Rule.ErrorMessage);
            }
            return myValidation;
        }

    }
}
