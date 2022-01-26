using FrontDeskApp.Modals;
using FrontDeskApp.Models;
using FrontDeskApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontDeskApp.Forms
{
    public partial class frmStoreRetrive : Form
    {

        private BoxRecordService BoxRecordService = new BoxRecordService();
        private BoxTypeService BoxTypeService = new BoxTypeService();
        private CustomerInfoService CustomerInfoService = new CustomerInfoService();
        private CustomerRecordService CustomerRecordService = new CustomerRecordService();

        public customerrecord SelectedCustomerRecord => bSourceCustomerRecord.Current as customerrecord;

        public frmStoreRetrive()
        {
            InitializeComponent();
            CrudAction();
        }

        private void CrudAction()
        {
            btnStore.Click += btnStore_Click;
            btnDelete.Click += btnDelete_Click;         
            btnRetrive.Click += btnRetrive_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnSearch.Click += btnSearch_Click;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please input Name to search!");
                return;
            }
            var search = CustomerRecordService.List();
            bSourceCustomerRecord.DataSource = search.Where(x => x.customer.firstname.ToLower().StartsWith(txtSearch.Text.ToLower()) || x.customer.lastname.ToLower().StartsWith(txtSearch.Text.ToLower()));
            bSourceCustomerRecord_CurrentItemChanged(new object(), new EventArgs());
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List();
            txtSearch.Clear();
        }
        private void btnRetrive_Click(object sender, System.EventArgs e)
        {
            if (SelectedCustomerRecord.status == "Retrieved")
            {
                MessageBox.Show("Already Retrieved Item!","System Message");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to Retrieve the item?", "Retrieve", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var item = CustomerRecordService.getbyCustomerId(SelectedCustomerRecord.customerrecordid);
                item = new customerrecord
                {
                    customerrecordid = item.customerrecordid,
                    customerid = item.customerid,
                    boxid = item.boxid,
                    status = "Retrieved"
                };

                var itemupdatecustomerrecord = CustomerRecordService.Save(item);

                var itembox = BoxRecordService.getbyBoxId(SelectedCustomerRecord.boxid??0);
                itembox = new box
                {
                    boxid = itembox.boxid,
                    boxnumber = itembox.boxnumber,
                    boxtypeid = itembox.boxtypeid,
                    isavailable = true,
                };

                var itemupdateboxrecord = BoxRecordService.Save(itembox);
                List();
            }
        }

      
        private void btnStore_Click(object sender, System.EventArgs e)
        {
            using (ModStoreRetrive frm = new ModStoreRetrive(new customerrecord { customerrecordid = 0 }, "ADD"))
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
            if (bSourceBoxtype.Current == null)
            {
                MessageBox.Show("No User record selected.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult res = MessageBox.Show("Are you sure you want to delete the selected record?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No)
            {
                return;
            }

            customerrecord objres = CustomerRecordService.Delete(bSourceCustomerRecord.Current as customerrecord);
        
            MessageBox.Show("Record successfully deleted", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bSourceCustomerRecord.RemoveCurrent();
        }
        private void List()
        {
            try
            {
                bSourceCustomers.DataSource = CustomerInfoService.List();
                bSourceBoxRecord.DataSource = BoxRecordService.List();
                bSourceBoxtype.DataSource = BoxTypeService.List();
                bSourceCustomerRecord.DataSource = CustomerRecordService.List();

                bSourceCustomerRecord_CurrentItemChanged(new object(), new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bSourceCustomerRecord_CurrentItemChanged(object sender, EventArgs e)
        {
            var item = (bSourceBoxtype.Count <= 0) ? null : bSourceBoxtype.Current as boxtype;

        }

        private void frmStoreRetrive_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
