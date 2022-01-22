using FrontDeskApp.Models;
using FrontDeskApp.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FrontDeskApp.Modals
{
    public partial class ModCustomerInformation : Form
    {
        string _transactionmode;
        public customer _customer;
        private CustomerInfoService CustomerInfoService = new CustomerInfoService();

        public ModCustomerInformation(customer customer, string transactionmode)
        {
            InitializeComponent();

            _customer = customer;
            _transactionmode = transactionmode;
            if (transactionmode == "ADD")
            {
                lblCaption.Text = "Add Customer";
            }
            else if (transactionmode == "EDIT")
            {
                lblCaption.Text = "Edit Customer";
            }
            CrudAction();
            MaptoUI(_customer);
        }

        private void CrudAction()
        {
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void MaptoUI(customer item)
        {
           
            txtFn.Text = item.firstname;
            txtLn.Text = item.lastname;
            txtPhone.Text = item.phonenumber;        

        }

        private customer MaptoDTO()
        {
            return new customer
            {
                customerid = _customer.customerid,
                firstname = txtFn.Text,
                lastname = txtLn.Text,
                phonenumber = txtPhone.Text
            };
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            customer thisdata = MaptoDTO();
            thisdata = CustomerInfoService.Save(thisdata);

            if (thisdata.Validation.isValid == false)
            {
                if (thisdata.Validation.ValidationErrorList.Count <= 0) thisdata.Validation.ValidationErrorList.Add("An error has occured.");
                MessageBox.Show(thisdata.Validation.ValidationErrorList.FirstOrDefault(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_transactionmode == "ADD")
            {
                MessageBox.Show("Customer record successfully added.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else//EDIT
            {
                MessageBox.Show("Customer record successfully updated.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            _customer = thisdata;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
    }
}
