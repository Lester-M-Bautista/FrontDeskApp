using FrontDeskApp.Models;
using FrontDeskApp.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FrontDeskApp.Modals
{
    public partial class ModBoxType : Form
    {
        string _transactionmode;
        public boxtype _boxtype;
        private BoxTypeService BoxTypeService = new BoxTypeService();

        public ModBoxType(boxtype boxtype, string transactionmode)
        {
            InitializeComponent();

            _boxtype = boxtype;
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
            MaptoUI(_boxtype);
        }

        private void CrudAction()
        {
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void MaptoUI(boxtype item)
        {
            txtBoxType.Text = item.boxtypename;
        }

        private boxtype MaptoDTO()
        {
            return new boxtype
            {
                boxtypeid = _boxtype.boxtypeid,
                boxtypename = txtBoxType.Text,
            };
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            boxtype thisdata = MaptoDTO();
            thisdata = BoxTypeService.Save(thisdata);

            if (thisdata.Validation.isValid == false)
            {
                if (thisdata.Validation.ValidationErrorList.Count <= 0) thisdata.Validation.ValidationErrorList.Add("An error has occured.");
                MessageBox.Show(thisdata.Validation.ValidationErrorList.FirstOrDefault(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_transactionmode == "ADD")
            {
                MessageBox.Show("Box Type record successfully added.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else//EDIT
            {
                MessageBox.Show("Box Type record successfully updated.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            _boxtype = thisdata;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
    }
}
