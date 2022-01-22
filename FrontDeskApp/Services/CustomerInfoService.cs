using FrontDeskApp.BaseValidatorObject;
using FrontDeskApp.Models;
using FrontDeskApp.Validators;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FrontDeskApp.Services
{

    public class CustomerInfoService
    {
        public DBModel DBModel;

        public CustomerInfoService()
        {
            Initialize();
        }
        private void Initialize()
        {
            DBModel = new DBModel();
        }

        public customer Save(customer item)
        {
            return (item.customerid <= 0) ? Insert(item) : Update(item);
        }

        public customer Insert(customer item)
        {
            try
            {
                CustomerValidator validator = new CustomerValidator();
                item.Validation = validator.Validate(item, "INSERT");

                if (item.Validation.isValid == false)
                {
                    return item;
                }

                DBModel.customer.Add(item);
                DBModel.SaveChanges();

                return item;
            }
            catch (Exception ex)
            {
                item.Validation = new BaseValidator { isValid = false, ValidationErrorList = new List<string> { "Exception Error:" + ex.Message } };
                return item;
            }

        }

        public customer Update(customer item)
        {
            try
            {
                CustomerValidator validator = new CustomerValidator();
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

        public customer Delete(customer item)
        {
            try
            {
                CustomerValidator validator = new CustomerValidator();
                item.Validation = validator.Validate(item, "INSERT");

                if (item.Validation.isValid == false)
                {
                    return item;
                }

                var itemtodelete = DBModel.customer.SingleOrDefault(x => x.customerid == item.customerid);
                DBModel.customer.Remove(itemtodelete);
                DBModel.SaveChanges();

                return item;
            }
            catch (Exception ex)
            {
                item.Validation = new BaseValidator { isValid = false, ValidationErrorList = new List<string> { "Exception Error:" + ex.Message } };
                return item;
            }

        }

        public List<customer> List()
        {
            var item = DBModel.customer.AsNoTracking().ToList();
            return item;

        }

        public List<customer> getbyName(string name)
        {
            var item = DBModel.customer.AsNoTracking().Where(x => x.firstname.ToLower().StartsWith(name.ToLower()) || x.lastname.ToLower().StartsWith(name.ToLower())).ToList();
            return item;

        }
    }   
}
