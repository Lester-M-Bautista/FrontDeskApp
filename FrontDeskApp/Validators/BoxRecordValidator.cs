using FrontDeskApp.BaseValidatorObject;
using FrontDeskApp.Models;
using FrontDeskApp.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FrontDeskApp.Validators
{
    public class BoxRecordValidator
    {
        private DBModel DBModel;
        public BoxRecordValidator()
        {
            Initialize();
        }
        private void Initialize()
        {
            DBModel = new DBModel();
        }
        public BaseValidator Validate(box x, string action)
        {

            List<string> errlist = new List<string>();
            bool valid;

            if (action == "INSERT" || action == "UPDATE")
            {

                

                if (x.boxnumber == null) errlist.Add("Box Number is a required field.");
                if (x.boxnumber > 100) errlist.Add("Box Number count exceeds the '100' characters limit.");

                if ( x.boxtypeid == null) errlist.Add("Box Type is a required field.");

            }

            if (action == "DELETE")
            {
                var item = DBModel.customerrecord.SingleOrDefault(y => y.boxid == x.boxid);
                if (item != null) errlist.Add("Cannot delete this record.");
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
