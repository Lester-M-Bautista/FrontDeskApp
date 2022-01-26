using FrontDeskApp.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FrontDeskApp.Services
{

    public class CustomerRecordService
    {
        public DBModel DBModel;

        public CustomerRecordService()
        {
            Initialize();
        }
        private void Initialize()
        {
            DBModel = new DBModel();
        }

        public customerrecord Save(customerrecord item)
        {
            return (item.customerrecordid <= 0) ? Insert(item) : Update(item);
        }

        public customerrecord Insert(customerrecord item)
        {
           
                DBModel.customerrecord.Add(item);
                DBModel.SaveChanges();
                return item;
        }

        public customerrecord Update(customerrecord item)
        {

            customerrecord data = MapToEntity(item);

            DBModel.Entry(data).State = EntityState.Modified;
                DBModel.SaveChanges();
                return item;       
        }

        protected customerrecord MapToEntity(customerrecord item)
        {
            customerrecord _existing = DBModel.Set<customerrecord>().Local.FirstOrDefault(x => x.customerrecordid == item.customerrecordid);
            if (_existing != null)
            {
                _existing.customerrecordid = item.customerrecordid;
                _existing.customerid = item.customerid;
                _existing.boxid = item.boxid;
                _existing.status = item.status;
                return _existing;
            }
            else
            {
                return new customerrecord
                {
                    customerrecordid = item.customerrecordid,
                    customerid = item.customerid,
                    boxid = item.boxid,
                    status = item.status,
                };
            }
        }

        public customerrecord Delete(customerrecord item)
        {
          
                var itemtodelete = DBModel.customerrecord.SingleOrDefault(x => x.customerrecordid == item.customerrecordid);
                DBModel.customerrecord.Remove(itemtodelete);
                DBModel.SaveChanges();

                return item;        
        }

        public List<customerrecord> List()
        {
            List<customerrecord> newrecord = new List<customerrecord>();
            var item = DBModel.customerrecord.ToList();
            foreach (customerrecord customeritem in item)        
            {
                var customervalue = new customerrecord
                {
                    boxid = customeritem.boxid,
                    boxtypeid = customeritem.box.boxtypeid,
                    customerid = customeritem.customerid,
                    customerrecordid = customeritem.customerrecordid,
                    status = customeritem.status,
                    customer = customeritem.customer
                };

                newrecord.Add(customervalue);
            }
            return newrecord;

        }

        public List<customerrecord> getbyName(string name)
        {
            var item = DBModel.customerrecord.AsNoTracking().Where(x => x.customer.firstname.ToLower().StartsWith(name.ToLower()) || x.customer.lastname.ToLower().StartsWith(name.ToLower())).ToList();
            return item;

        }

        public customerrecord getbyCustomerId(int customerid)
        {
            var item = DBModel.customerrecord.SingleOrDefault(x=>x.customerrecordid == customerid);
            return item;

        }

        public customerrecord getbyBoxId(int boxid)
        {
            var item = DBModel.customerrecord.SingleOrDefault(x => x.boxid == boxid);
            return item;

        }
    }   
}
