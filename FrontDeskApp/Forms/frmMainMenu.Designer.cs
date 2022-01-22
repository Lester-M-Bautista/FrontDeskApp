namespace FrontDeskApp.Forms
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customersInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retrivedRestoredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::FrontDeskApp.Properties.Resources.normal;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(49, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 675);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersInformationToolStripMenuItem,
            this.boxTypeToolStripMenuItem,
            this.boxNumberToolStripMenuItem,
            this.retrivedRestoredToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(278, 656);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customersInformationToolStripMenuItem
            // 
            this.customersInformationToolStripMenuItem.Checked = true;
            this.customersInformationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customersInformationToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.customersInformationToolStripMenuItem.Name = "customersInformationToolStripMenuItem";
            this.customersInformationToolStripMenuItem.Size = new System.Drawing.Size(265, 36);
            this.customersInformationToolStripMenuItem.Text = "Customers Information";
            this.customersInformationToolStripMenuItem.Click += new System.EventHandler(this.customersInformationToolStripMenuItem_Click);
            // 
            // boxTypeToolStripMenuItem
            // 
            this.boxTypeToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.boxTypeToolStripMenuItem.Name = "boxTypeToolStripMenuItem";
            this.boxTypeToolStripMenuItem.Size = new System.Drawing.Size(265, 36);
            this.boxTypeToolStripMenuItem.Text = "Box type";
            this.boxTypeToolStripMenuItem.Click += new System.EventHandler(this.boxTypeToolStripMenuItem_Click);
            // 
            // boxNumberToolStripMenuItem
            // 
            this.boxNumberToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.boxNumberToolStripMenuItem.Name = "boxNumberToolStripMenuItem";
            this.boxNumberToolStripMenuItem.Size = new System.Drawing.Size(265, 36);
            this.boxNumberToolStripMenuItem.Text = "Box Number";
            this.boxNumberToolStripMenuItem.Click += new System.EventHandler(this.boxNumberToolStripMenuItem_Click);
            // 
            // retrivedRestoredToolStripMenuItem
            // 
            this.retrivedRestoredToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.retrivedRestoredToolStripMenuItem.Name = "retrivedRestoredToolStripMenuItem";
            this.retrivedRestoredToolStripMenuItem.Size = new System.Drawing.Size(265, 36);
            this.retrivedRestoredToolStripMenuItem.Text = "Retrived / Restored";
            this.retrivedRestoredToolStripMenuItem.Click += new System.EventHandler(this.retrivedRestoredToolStripMenuItem_Click);
            // 
            // TabControl
            // 
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl.Controls.Add(this.tabMain);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.TabControl.Location = new System.Drawing.Point(336, 72);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1005, 672);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 51;
            // 
            // tabMain
            // 
            this.tabMain.BackgroundImage = global::FrontDeskApp.Properties.Resources.TopView;
            this.tabMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabMain.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.ForeColor = System.Drawing.Color.DarkGreen;
            this.tabMain.Location = new System.Drawing.Point(4, 5);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(997, 663);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(511, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 39);
            this.label1.TabIndex = 52;
            this.label1.Text = "Frontdesk Application";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrontDeskApp.Properties.Resources.normal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customersInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retrivedRestoredToolStripMenuItem;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.Label label1;
    }
}