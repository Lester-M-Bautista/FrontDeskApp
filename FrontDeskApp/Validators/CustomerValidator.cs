using FrontDeskApp.BaseValidatorObject;
using FrontDeskApp.Models;
using System.Collections.Generic;

namespace FrontDeskApp.Validators
{
    public class CustomerValidator
    {
        private DBModel DBModel;

        public CustomerValidator()
        {
            Initialize();
        }
        private void Initialize()
        {
            DBModel = new DBModel();
        }
        public BaseValidator Validate(customer x, string action)
        {

            List<string> errlist = new List<string>();
            bool valid;

            if (action == "INSERT" || action == "UPDATE")
            {
                if (x.firstname == string.Empty || x.firstname == null) errlist.Add("First name is a required field.");
                if (x.firstname.Length > 15) errlist.Add("Firstname length exceeds the '15' characters limit.");

                if (x.lastname == string.Empty || x.lastname == null) errlist.Add("Last name is a required field.");
                if (x.lastname.Length > 15) errlist.Add("Last name length exceeds the '15' characters limit.");

                if (x.phonenumber == string.Empty || x.phonenumber == null) errlist.Add("Phone number is a required field.");
                if (x.phonenumber.Length > 11) errlist.Add("Last name length exceeds the '11' characters limit.");

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
