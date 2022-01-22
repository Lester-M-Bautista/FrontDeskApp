using System.Windows.Forms;

namespace FrontDeskApp.Forms
{
    public partial class frmMainMenu : Form
    {
        TabPage frmCustomerInformation = new TabPage { Name = "frmCustomerInformation", Text = "Customers Information" };
        TabPage frmAccountSettings = new TabPage { Name = "frmAccountSettings", Text = "Account Settings" };

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
    }
}
