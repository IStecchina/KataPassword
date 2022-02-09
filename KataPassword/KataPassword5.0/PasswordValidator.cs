using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataPassword.Validators;

namespace KataPassword
{
    public class PasswordValidator
    {
        private readonly IValidator validator;
        private readonly List<PasswordRule> listRules = new List<PasswordRule>();
        public PasswordValidator()
        {
            #region impostazione regole
            var Rule_AtLeast8Chars = new PasswordRule(p => p.Length >= 8, "Password must be at least 8 characters");
            var Rule_AtLeast2Nums = new PasswordRule(p => p.Where(c => char.IsDigit(c)).Count() >= 2, "The password must contain at least 2 numbers");
            var Rule_AtLeast1Uppercase = new PasswordRule(p => p.Where(c => char.IsUpper(c)).Any(), "password must contain at least one capital letter");
            var Rule_AtLeast1SpChar = new PasswordRule(p => p.Where(c => !char.IsLetterOrDigit(c)).Any(), "password must contain at least one special character");

            listRules.Add(Rule_AtLeast8Chars);
            listRules.Add(Rule_AtLeast2Nums);
            listRules.Add(Rule_AtLeast1Uppercase);
            listRules.Add(Rule_AtLeast1SpChar);
            #endregion

            validator = new BaseValidator();
            foreach (var rule in listRules)
            {
                validator = new DecorationValidator(rule, validator);
            }
        }

        public ValidationResult Validate(string input) => validator.Validate(input);

    }
}
