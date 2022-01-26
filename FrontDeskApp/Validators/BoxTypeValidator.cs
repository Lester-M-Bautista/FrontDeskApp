using FrontDeskApp.BaseValidatorObject;
using FrontDeskApp.Models;
using System.Collections.Generic;

namespace FrontDeskApp.Validators
{
    public class BoxTypeValidator
    {
        private DBModel DBModel;

        public BoxTypeValidator()
        {
            Initialize();
        }
        private void Initialize()
        {
            DBModel = new DBModel();
        }
        public BaseValidator Validate(boxtype x, string action)
        {

            List<string> errlist = new List<string>();
            bool valid;

            if (action == "INSERT" || action == "UPDATE")
            {
                if (x.boxtypename == string.Empty || x.boxtypename == null) errlist.Add("Box Type is a required field.");
                if (x.boxtypename.Length > 10) errlist.Add("Box Type length exceeds the '15' characters limit.");             
            }
            if (errlist.Count <= 0)
                valid = true;
            else
                valid = false;

            BaseValidator Validation = new BaseValidator { isValid = valid, ValidationErrorList = errlist };
            return Validation;

        }
    }
}
