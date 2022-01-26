namespace FrontDeskApp.Modals
{
    partial class ModStoreRetrive
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModStoreRetrive));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bSourceCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerrecordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboBoxType = new System.Windows.Forms.ComboBox();
            this.bSourceBoxtype = new System.Windows.Forms.BindingSource(this.components);
            this.cboBoxNumber = new System.Windows.Forms.ComboBox();
            this.bSourceBoxRecord = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceBoxtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceBoxRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.Black;
            this.lblCaption.Location = new System.Drawing.Point(31, 56);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(416, 25);
            this.lblCaption.TabIndex = 102;
            this.lblCaption.Text = "STORE ITEM";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(373, 480);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 26);
            this.btnCancel.TabIndex = 101;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(301, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 26);
            this.btnSave.TabIndex = 100;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(165, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 96;
            this.label7.Text = "Item Size : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(119, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 19);
            this.label6.TabIndex = 95;
            this.label6.Text = "Customer Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(144, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 94;
            this.label5.Text = "Box Number : ";
            // 
            // bSourceCustomers
            // 
            this.bSourceCustomers.DataSource = typeof(FrontDeskApp.Models.customer);
            // 
            // gridUsers
            // 
            this.gridUsers.AllowUserToAddRows = false;
            this.gridUsers.AllowUserToDeleteRows = false;
            this.gridUsers.AllowUserToResizeColumns = false;
            this.gridUsers.AllowUserToResizeRows = false;
            this.gridUsers.AutoGenerateColumns = false;
            this.gridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUsers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.validationDataGridViewTextBoxColumn,
            this.customerrecordDataGridViewTextBoxColumn});
            this.gridUsers.DataSource = this.bSourceCustomers;
            this.gridUsers.Location = new System.Drawing.Point(35, 161);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridUsers.RowHeadersVisible = false;
            this.gridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsers.Size = new System.Drawing.Size(412, 178);
            this.gridUsers.TabIndex = 103;
            this.gridUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsers_CellClick);
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customerid";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customerid";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.customeridDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phonenumber";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phonenumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // validationDataGridViewTextBoxColumn
            // 
            this.validationDataGridViewTextBoxColumn.DataPropertyName = "Validation";
            this.validationDataGridViewTextBoxColumn.HeaderText = "Validation";
            this.validationDataGridViewTextBoxColumn.Name = "validationDataGridViewTextBoxColumn";
            this.validationDataGridViewTextBoxColumn.ReadOnly = true;
            this.validationDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerrecordDataGridViewTextBoxColumn
            // 
            this.customerrecordDataGridViewTextBoxColumn.DataPropertyName = "customerrecord";
            this.customerrecordDataGridViewTextBoxColumn.HeaderText = "customerrecord";
            this.customerrecordDataGridViewTextBoxColumn.Name = "customerrecordDataGridViewTextBoxColumn";
            this.customerrecordDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerrecordDataGridViewTextBoxColumn.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(359, 117);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 32);
            this.btnRefresh.TabIndex = 106;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(59, 122);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(209, 22);
            this.txtSearch.TabIndex = 105;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(274, 117);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 32);
            this.btnSearch.TabIndex = 104;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboBoxType
            // 
            this.cboBoxType.DataSource = this.bSourceBoxtype;
            this.cboBoxType.DisplayMember = "boxtypename";
            this.cboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxType.FormattingEnabled = true;
            this.cboBoxType.Location = new System.Drawing.Point(250, 405);
            this.cboBoxType.Name = "cboBoxType";
            this.cboBoxType.Size = new System.Drawing.Size(197, 28);
            this.cboBoxType.TabIndex = 107;
            this.cboBoxType.ValueMember = "boxtypeid";
            this.cboBoxType.SelectedIndexChanged += new System.EventHandler(this.cboBoxType_SelectedIndexChanged);
            // 
            // bSourceBoxtype
            // 
            this.bSourceBoxtype.DataSource = typeof(FrontDeskApp.Models.boxtype);
            // 
            // cboBoxNumber
            // 
            this.cboBoxNumber.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bSourceBoxRecord, "boxid", true));
            this.cboBoxNumber.DataSource = this.bSourceBoxRecord;
            this.cboBoxNumber.DisplayMember = "boxnumber";
            this.cboBoxNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxNumber.FormattingEnabled = true;
            this.cboBoxNumber.Location = new System.Drawing.Point(250, 439);
            this.cboBoxNumber.MaxDropDownItems = 10;
            this.cboBoxNumber.Name = "cboBoxNumber";
            this.cboBoxNumber.Size = new System.Drawing.Size(197, 28);
            this.cboBoxNumber.TabIndex = 108;
            this.cboBoxNumber.ValueMember = "boxid";
            // 
            // bSourceBoxRecord
            // 
            this.bSourceBoxRecord.DataSource = typeof(FrontDeskApp.Models.box);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(58, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 109;
            this.label1.Text = "Customer Phone Number  : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(250, 354);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 19);
            this.lblName.TabIndex = 110;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumber.Location = new System.Drawing.Point(250, 373);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(0, 19);
            this.lblPhoneNumber.TabIndex = 111;
            // 
            // ModStoreRetrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrontDeskApp.Properties.Resources.normal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 546);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBoxNumber);
            this.Controls.Add(this.cboBoxType);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gridUsers);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModStoreRetrive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModStoreRetrive";
            this.Load += new System.EventHandler(this.ModStoreRetrive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bSourceCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceBoxtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceBoxRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bSourceCustomers;
        private System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerrecordDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboBoxType;
        private System.Windows.Forms.ComboBox cboBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.BindingSource bSourceBoxtype;
        private System.Windows.Forms.BindingSource bSourceBoxRecord;
    }
}