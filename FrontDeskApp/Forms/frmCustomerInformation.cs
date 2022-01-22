using FrontDeskApp.Modals;
using FrontDeskApp.Models;
using FrontDeskApp.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FrontDeskApp.Forms
{
    public partial class frmCustomerInformation : Form
    {
        private CustomerInfoService CustomerInfoService = new CustomerInfoService();
        public customer SelectedItem => bSourceCustomers.Current as customer;
        public frmCustomerInformation()
        {
            InitializeComponent();
            CrudAction();
        }
        private void CrudAction()
        {
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnSearch.Click += btnSearch_Click;
            btnRefresh.Click += btnRefresh_Click;
        }
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            using (ModCustomerInformation frm = new ModCustomerInformation(new customer { customerid = 0 }, "ADD"))
            {
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List();
                }

            }          
        }

        private void List()
        {
            try
            {
                bSourceCustomers.DataSource = CustomerInfoService.List();
                bSourceCustomer_CurrentItemChanged(new object(), new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bSourceCustomer_CurrentItemChanged(object sender, EventArgs e)
        {
            var item = (bSourceCustomers.Count <= 0) ? null : bSourceCustomers.Current as customer;

        }

        private void frmIndigeniousDetails_Load(object sender, EventArgs e)
        {
            List();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please input last name to search!");
                return;
            }
            bSourceCustomers.DataSource = CustomerInfoService.getbyName(txtSearch.Text);
            bSourceCustomer_CurrentItemChanged(new object(), new EventArgs());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bSourceCustomers.Current == null)
            {
                MessageBox.Show("No User record selected.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (ModCustomerInformation frm = new ModCustomerInformation(bSourceCustomers.Current as customer, "EDIT"))
            {
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List();
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bSourceCustomers.Current == null)
            {
                MessageBox.Show("No User record selected.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult res = MessageBox.Show("Are you sure you want to delete the selected record?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No)
            {
                return;
            }

            customer objres = CustomerInfoService.Delete(bSourceCustomers.Current as customer);

            if (objres.Validation.isValid == false)
            {
                MessageBox.Show(objres.Validation.ValidationErrorList.FirstOrDefault(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Record successfully deleted", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bSourceCustomers.RemoveCurrent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List();
            txtSearch.Clear();
        }

        private void frmCustomerInformation_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
