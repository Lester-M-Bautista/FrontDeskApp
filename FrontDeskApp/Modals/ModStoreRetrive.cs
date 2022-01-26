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

namespace FrontDeskApp.Modals
{
    public partial class ModStoreRetrive : Form
    {
        public customerrecord _customerrecord;

        private BoxRecordService BoxRecordService = new BoxRecordService();
        private CustomerInfoService CustomerInfoService = new CustomerInfoService();
        private BoxTypeService BoxTypeService = new BoxTypeService();
        private CustomerRecordService CustomerRecordService = new CustomerRecordService();
        

        public box SelectedBoxRecord => bSourceBoxRecord.Current as box;
        public customer SelectedCustomer => bSourceCustomers.Current as customer;

        public ModStoreRetrive(customerrecord customerrecord, string transactionmode)
        {
            InitializeComponent();
            _customerrecord = customerrecord;        
        }

        private void cboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemsearch = BoxRecordService.getbyName(cboBoxType.Text);
            cboBoxNumber.SelectedValue = "";
            if (itemsearch.Count == 0) return;

            var availability = itemsearch.OrderBy(x => x.boxnumber).Where(x => x.isavailable == true);
            if (availability.ToList().Count == 0)
            {
                MessageBox.Show("Not enough space", "System Message");
                return;
            }

            bSourceBoxRecord.DataSource = availability;
            cboBoxNumber.SelectedValue = "";
        }

        private void gridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblName.Text = SelectedCustomer.firstname + " " + SelectedCustomer.lastname;
            lblPhoneNumber.Text = SelectedCustomer.phonenumber;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblName.Text == "")
            {
                MessageBox.Show("Please choose Customer Name by clicking in grid", "System Message");
                return;
            }

            customerrecord thisdata = MaptoDTO();
            var itemupdatecustomerrecord = CustomerRecordService.Save(thisdata);

            var itembox = BoxRecordService.getbyBoxId(SelectedBoxRecord.boxid);
            itembox = new box
            {
                boxid = itembox.boxid,
                boxnumber = itembox.boxnumber,
                boxtypeid = itembox.boxtypeid,
                isavailable = false,
            };

            var itemupdateboxrecord = BoxRecordService.Save(itembox);

            DialogResult = DialogResult.OK;
        }

        private customerrecord MaptoDTO()
        {
            return new customerrecord
            {
               customerrecordid = _customerrecord.customerrecordid,
               boxid = SelectedBoxRecord.boxid,
               customerid = SelectedCustomer.customerid,
               status = "Stored"
            };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please input last name to search!");
                return;
            }
            bSourceCustomers.DataSource = CustomerInfoService.getbyName(txtSearch.Text);
        }

        private void ModStoreRetrive_Load(object sender, EventArgs e)
        {
            bSourceBoxtype.DataSource = BoxTypeService.List();
            cboBoxType.SelectedValue = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
