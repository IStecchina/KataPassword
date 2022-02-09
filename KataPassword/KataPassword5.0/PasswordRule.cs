using System;

namespace KataPassword
{
    public class PasswordRule
    {
        public Predicate<string> Check { get; init; }
        public string ErrorMessage { get; init; }
        public PasswordRule(Predicate<string> check, string errMsg)
        {
            Check = check;
            ErrorMessage = errMsg;
        }
    }
}
