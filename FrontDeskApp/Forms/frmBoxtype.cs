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
    public partial class frmBoxtype : Form
    {
        private BoxTypeService BoxTypeService = new BoxTypeService();
        public boxtype SelectedItem => bSourceBoxtype.Current as boxtype;
        public frmBoxtype()
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
            using (ModBoxType frm = new ModBoxType(new boxtype { boxtypeid = 0 }, "ADD"))
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
                bSourceBoxtype.DataSource = BoxTypeService.List();
                bSourceBoxType_CurrentItemChanged(new object(), new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bSourceBoxType_CurrentItemChanged(object sender, EventArgs e)
        {
            var item = (bSourceBoxtype.Count <= 0) ? null : bSourceBoxtype.Current as boxtype;

        }

        private void frmIndigeniousDetails_Load(object sender, EventArgs e)
        {
            List();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please input Box type name to search!");
                return;
            }
            bSourceBoxtype.DataSource = BoxTypeService.getbyName(txtSearch.Text);
            bSourceBoxType_CurrentItemChanged(new object(), new EventArgs());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bSourceBoxtype.Current == null)
            {
                MessageBox.Show("No User record selected.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (ModBoxType frm = new ModBoxType(bSourceBoxtype.Current as boxtype, "EDIT"))
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

            boxtype objres = BoxTypeService.Delete(bSourceBoxtype.Current as boxtype);

            if (objres.Validation.isValid == false)
            {
                MessageBox.Show(objres.Validation.ValidationErrorList.FirstOrDefault(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Record successfully deleted", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bSourceBoxtype.RemoveCurrent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List();
            txtSearch.Clear();
        }

        private void frmBoxtype_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
