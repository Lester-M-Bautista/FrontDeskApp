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
    public partial class frmBoxRecords : Form
    {
        private BoxRecordService BoxRecordService = new BoxRecordService();
        private BoxTypeService BoxTypeService = new BoxTypeService();
        public box SelectedItem => bSourceBoxRecord.Current as box;
        public frmBoxRecords()
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
            using (ModBoxRecord frm = new ModBoxRecord(new box { boxtypeid = 0 }, "ADD"))
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
                var itemsearch = BoxRecordService.List();
                bSourceBoxRecord.DataSource = BoxRecordService.List();
                bSourceBoxtype.DataSource = BoxTypeService.List();
                lblAvailable.Text = itemsearch.Where(x => x.isavailable == true).ToList().Count.ToString();
                bSourceBoxRecord_CurrentItemChanged(new object(), new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bSourceBoxRecord_CurrentItemChanged(object sender, EventArgs e)
        {
            var item = (bSourceBoxRecord.Count <= 0) ? null : bSourceBoxRecord.Current as boxtype;

        }

        private void frmIndigeniousDetails_Load(object sender, EventArgs e)
        {
            List();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please choose box type to search!");
                return;
            }
            var itemsearch = BoxRecordService.getbyName(txtSearch.Text);
            bSourceBoxRecord.DataSource = itemsearch;
            lblAvailable.Text = itemsearch.Where(x => x.isavailable == true).ToList().Count.ToString();
            bSourceBoxRecord_CurrentItemChanged(new object(), new EventArgs());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bSourceBoxRecord.Current == null)
            {
                MessageBox.Show("No User record selected.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (ModBoxRecord frm = new ModBoxRecord(bSourceBoxRecord.Current as box, "EDIT"))
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
            if (bSourceBoxRecord.Current == null)
            {
                MessageBox.Show("No User record selected.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult res = MessageBox.Show("Are you sure you want to delete the selected record?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No)
            {
                return;
            }

            box objres = BoxRecordService.Delete(bSourceBoxRecord.Current as box);

            if (objres.Validation.isValid == false)
            {
                MessageBox.Show(objres.Validation.ValidationErrorList.FirstOrDefault(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Record successfully deleted", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bSourceBoxRecord.RemoveCurrent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List();
            txtSearch.SelectedValue = "";
        }

        private void frmBoxRecords_Load(object sender, EventArgs e)
        {
            List();
            txtSearch.SelectedValue = "";
        }

        private void gridUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "isavailableDataGridViewCheckBoxColumn")
            {
                e.Value = Convert.ToBoolean(e.Value) ? "YES" : "NO";
                e.FormattingApplied = true;
            }
        }
    }
}
