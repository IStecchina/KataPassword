using System.Collections.Generic;

namespace KataPassword
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<string> ErrorDescription { get; }
        public ValidationResult()
        {
            IsValid = true;
            ErrorDescription = new List<string>();
        }
    }
}
