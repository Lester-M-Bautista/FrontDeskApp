using System.Collections.Generic;

namespace FrontDeskApp.BaseValidatorObject
{
    public class BaseValidator
    {
        public bool isValid { set; get; }
        public List<string> ValidationErrorList { set; get; }
    }
}
