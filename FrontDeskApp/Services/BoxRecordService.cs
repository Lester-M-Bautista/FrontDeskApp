using FrontDeskApp.BaseValidatorObject;
using FrontDeskApp.Models;
using FrontDeskApp.Validators;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FrontDeskApp.Services
{

    public class BoxRecordService
    {

        public DBModel DBModel;

        public BoxRecordService()
        {
            Initialize();
        }
        private void Initialize()
        {
            DBModel = new DBModel();
        }

        public box Save(box item)
        {
            return (item.boxid <= 0) ? Insert(item) : Update(item);
        }

        public box Insert(box item)
        {
            try
            {
                BoxRecordValidator validator = new BoxRecordValidator();
                item.Validation = validator.Validate(item, "INSERT");

                if (item.Validation.isValid == false)
                {
                    return item;
                }

                DBModel.box.Add(item);
                DBModel.SaveChanges();

                return item;
            }
            catch (Exception ex)
            {
                item.Validation = new BaseValidator { isValid = false, ValidationErrorList = new List<string> { "Exception Error:" + ex.Message } };
                return item;
            }

        }

        public box Update(box item)
        {
            try
            {
                BoxRecordValidator validator = new BoxRecordValidator();
                item.Validation = validator.Validate(item, "INSERT");

                if (item.Validation.isValid == false)
                {
                    return item;
                }

                box data = MapToEntity(item);
                DBModel.Entry(data).State = EntityState.Modified;
                DBModel.SaveChanges();

                return item;
            }
            catch (Exception ex)
            {
                item.Validation = new BaseValidator { isValid = false, ValidationErrorList = new List<string> { "Exception Error:" + ex.Message } };
                return item;
            }

        }

        protected box MapToEntity(box item)
        {
            box _existing = DBModel.Set<box>().Local.FirstOrDefault(x => x.boxid == item.boxid);
            if (_existing != null)
            {
                _existing.boxid = item.boxid;
                _existing.boxtypeid = item.boxtypeid;
                _existing.boxnumber = item.boxnumber;
                _existing.isavailable = item.isavailable;
                return _existing;
            }
            else
            {
                return new box
                {
                    boxid = item.boxid,
                    boxtypeid = item.boxtypeid,
                    boxnumber = item.boxnumber,
                    isavailable = item.isavailable,
                };
            }
        }

        public box Delete(box item)
        {
            try
            {
                BoxRecordValidator validator = new BoxRecordValidator();
                item.Validation = validator.Validate(item, "DELETE");

                if (item.Validation.isValid == false)
                {
                    return item;
                }

                var itemtodelete = DBModel.box.SingleOrDefault(x => x.boxid == item.boxid);

                DBModel.box.Remove(itemtodelete);
                DBModel.SaveChanges();

                return item;
            }
            catch (Exception ex)
            {
                item.Validation = new BaseValidator { isValid = false, ValidationErrorList = new List<string> { "Exception Error:" + ex.Message } };
                return item;
            }

        }

        public List<box> List()
        {
            var item = DBModel.box.AsNoTracking().OrderByDescending(x=>x.boxtype.boxtypename).ToList();
            return item;

        }

        public List<box> getbyName(string name)
        {
            var item = DBModel.box.AsNoTracking().OrderByDescending(x=>x.boxnumber).Where(x => x.boxtype.boxtypename.ToLower().StartsWith(name.ToLower())).ToList();
            return item;

        }

        public box getbyBoxId(int boxid)
        {
            var item = DBModel.box.SingleOrDefault(x => x.boxid == boxid);
            return item;

        }
    }   
}
