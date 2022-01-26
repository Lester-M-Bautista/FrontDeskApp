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
    public partial class ModBoxRecord : Form
    {
        public boxtype SelectedBoxType => bSourceBoxType.Current as boxtype;
        string _transactionmode;
        public box _box;
        private BoxRecordService BoxRecordService = new BoxRecordService();
        private BoxTypeService BoxTypeService = new BoxTypeService();
        int latestboxnumner;

        public ModBoxRecord(box box, string transactionmode)
        {
            InitializeComponent();

            _box = box;
            _transactionmode = transactionmode;
            if (transactionmode == "ADD")
            {
                lblCaption.Text = "Add Box Number";
            }
            else if (transactionmode == "EDIT")
            {
                lblCaption.Text = "Edit Box Number";
            }
            CrudAction();
        }

        private void CrudAction()
        {
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void MaptoUI(box item)
        {

            cboBoxType.SelectedItem = item.boxtypeid;
            txtBoxNumber.Text = item.boxnumber.ToString();
        }

        private box MaptoDTO()
        {
            return new box
            {
                boxtypeid = SelectedBoxType.boxtypeid,
                boxnumber = Convert.ToInt32(txtBoxNumber.Text),
                boxid = _box.boxid,
                isavailable = true

            };
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            box thisdata = MaptoDTO();
            thisdata = BoxRecordService.Save(thisdata);

            if (thisdata.Validation.isValid == false)
            {
                if (thisdata.Validation.ValidationErrorList.Count <= 0) thisdata.Validation.ValidationErrorList.Add("An error has occured.");
                MessageBox.Show(thisdata.Validation.ValidationErrorList.FirstOrDefault(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_transactionmode == "ADD")
            {
                MessageBox.Show("Box Number record successfully added.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else//EDIT
            {
                MessageBox.Show("Box Number record successfully updated.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            _box = thisdata;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void ModBoxRecord_Load(object sender, EventArgs e)
        {
            bSourceBoxType.DataSource = BoxTypeService.List();
            cboBoxType.SelectedValue = "";
        }

        private void cboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBoxType.Text == "") return;
            var item = BoxRecordService.getbyName(cboBoxType.Text);
            if (item.Count == 0)
            {
                latestboxnumner = 0;
            }
            else
            {
                latestboxnumner = item.FirstOrDefault().boxnumber;
            }

            var getlastnumber = latestboxnumner + 1;
            txtBoxNumber.Text = getlastnumber.ToString();
        }
    }
}
