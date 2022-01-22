using FrontDeskApp.Services;
using System.Windows.Forms;

namespace FrontDeskApp.Forms
{
    public partial class frmMainMenu : Form
    {

        TabPage frmCustomerInformation = new TabPage { Name = "frmCustomerInformation", Text = "Customers Information" };
        TabPage frmBoxtype = new TabPage { Name = "frmBoxtype", Text = "Box Type" };
        TabPage frmBoxRecords = new TabPage { Name = "frmBoxRecords", Text = "Box Number" };
        TabPage frmStoreRetrive = new TabPage { Name = "frmStoreRetrive", Text = "Customer Record" };


        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void customersInformationToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (TabControl.Contains(frmCustomerInformation))
            {
                TabControl.SelectTab("frmCustomerInformation");
                return;
            }
            frmCustomerInformation.Controls.Add(new frmCustomerInformation()
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Visible = true,
                Dock = DockStyle.Fill,
                Width = 1044,
                Height = 544
            });

            TabControl.TabPages.Add(frmCustomerInformation);
            TabControl.SelectTab("frmCustomerInformation");
        }

        private void boxTypeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (TabControl.Contains(frmBoxtype))
            {
                TabControl.SelectTab("frmBoxtype");
                return;
            }
            frmBoxtype.Controls.Add(new frmBoxtype()
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Visible = true,
                Dock = DockStyle.Fill,
                Width = 1044,
                Height = 544
            });

            TabControl.TabPages.Add(frmBoxtype);
            TabControl.SelectTab("frmBoxtype");
        }

        private void boxNumberToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (TabControl.Contains(frmBoxRecords))
            {
                TabControl.SelectTab("frmBoxRecords");
                return;
            }
            frmBoxRecords.Controls.Add(new frmBoxRecords()
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Visible = true,
                Dock = DockStyle.Fill,
                Width = 1044,
                Height = 544
            });

            TabControl.TabPages.Add(frmBoxRecords);
            TabControl.SelectTab("frmBoxRecords");
        }

        private void retrivedRestoredToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (TabControl.Contains(frmStoreRetrive))
            {
                TabControl.SelectTab("frmStoreRetrive");
                return;
            }
            frmStoreRetrive.Controls.Add(new frmStoreRetrive()
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Visible = true,
                Dock = DockStyle.Fill,
                Width = 1044,
                Height = 544
            });

            TabControl.TabPages.Add(frmStoreRetrive);
            TabControl.SelectTab("frmStoreRetrive");
        }
    }
}
