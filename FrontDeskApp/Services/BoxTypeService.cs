using FrontDeskApp.BaseValidatorObject;
using FrontDeskApp.Models;
using FrontDeskApp.Validators;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FrontDeskApp.Services
{

    public class BoxTypeService
    {
        public DBModel DBModel;

        public BoxTypeService()
        {
            Initialize();
        }
        private void Initialize()
        {
            DBModel = new DBModel();
        }

        public boxtype Save(boxtype item)
        {
            return (item.boxtypeid <= 0) ? Insert(item) : Update(item);
        }

        public boxtype Insert(boxtype item)
        {
            try
            {
                BoxTypeValidator validator = new BoxTypeValidator();
                item.Validation = validator.Validate(item, "INSERT");

                if (item.Validation.isValid == false)
                {
                    return item;
                }

                DBModel.boxtype.Add(item);
                DBModel.SaveChanges();

                return item;
            }
            catch (Exception ex)
            {
                item.Validation = new BaseValidator { isValid = false, ValidationErrorList = new List<string> { "Exception Error:" + ex.Message } };
                return item;
            }

        }

        public boxtype Update(boxtype item)
        {
            try
            {
                BoxTypeValidator validator = new BoxTypeValidator();
                item.Validation = validator.Validate(item, "INSERT");

                if (item.Validation.isValid == false)
                {
                    return item;
                }
                DBModel.Entry(item).State = EntityState.Modified;
                DBModel.SaveChanges();

                return item;
            }
            catch (Exception ex)
            {
                item.Validation = new BaseValidator { isValid = false, ValidationErrorList = new List<string> { "Exception Error:" + ex.Message } };
                return item;
            }

        }

        public boxtype Delete(boxtype item)
        {
            try
            {
                BoxTypeValidator validator = new BoxTypeValidator();
                item.Validation = validator.Validate(item, "INSERT");

                if (item.Validation.isValid == false)
                {
                    return item;
                }

                var itemtodelete = DBModel.boxtype.SingleOrDefault(x => x.boxtypeid == item.boxtypeid);
                DBModel.boxtype.Remove(itemtodelete);
                DBModel.SaveChanges();

                return item;
            }
            catch (Exception ex)
            {
                item.Validation = new BaseValidator { isValid = false, ValidationErrorList = new List<string> { "Exception Error:" + ex.Message } };
                return item;
            }

        }

        public List<boxtype> List()
        {
            var item = DBModel.boxtype.ToList();
            return item;

        }

        public List<boxtype> getbyName(string name)
        {
            var item = DBModel.boxtype.AsNoTracking().Where(x => x.boxtypename.ToLower().StartsWith(name.ToLower())).ToList();
            return item;

        }
    }   
}
