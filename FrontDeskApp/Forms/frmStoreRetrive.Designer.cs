namespace FrontDeskApp.Forms
{
    partial class frmStoreRetrive
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreRetrive));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnRetrive = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bSourceCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.bSourceBoxtype = new System.Windows.Forms.BindingSource(this.components);
            this.bSourceBoxRecord = new System.Windows.Forms.BindingSource(this.components);
            this.bSourceCustomerRecord = new System.Windows.Forms.BindingSource(this.components);
            this.customerrecordidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.customerid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.boxtypeid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.boxidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.validationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceBoxtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceBoxRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceCustomerRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(433, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(294, 29);
            this.txtSearch.TabIndex = 46;
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
            this.customerrecordidDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.customerid,
            this.boxtypeid,
            this.boxidDataGridViewTextBoxColumn,
            this.validationDataGridViewTextBoxColumn,
            this.boxDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.status});
            this.gridUsers.DataSource = this.bSourceCustomerRecord;
            this.gridUsers.Location = new System.Drawing.Point(30, 60);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridUsers.RowHeadersVisible = false;
            this.gridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsers.Size = new System.Drawing.Size(937, 519);
            this.gridUsers.TabIndex = 41;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(853, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 38);
            this.btnRefresh.TabIndex = 47;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(733, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 38);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.Color.Transparent;
            this.btnStore.BackgroundImage = global::FrontDeskApp.Properties.Resources.normal;
            this.btnStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStore.Location = new System.Drawing.Point(733, 603);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(114, 38);
            this.btnStore.TabIndex = 42;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = false;
            // 
            // btnRetrive
            // 
            this.btnRetrive.BackColor = System.Drawing.Color.Transparent;
            this.btnRetrive.BackgroundImage = global::FrontDeskApp.Properties.Resources.normal;
            this.btnRetrive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetrive.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRetrive.Location = new System.Drawing.Point(853, 603);
            this.btnRetrive.Name = "btnRetrive";
            this.btnRetrive.Size = new System.Drawing.Size(114, 38);
            this.btnRetrive.TabIndex = 48;
            this.btnRetrive.Text = "Retrive";
            this.btnRetrive.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(853, 603);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 38);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // bSourceCustomers
            // 
            this.bSourceCustomers.DataSource = typeof(FrontDeskApp.Models.customer);
            // 
            // bSourceBoxtype
            // 
            this.bSourceBoxtype.DataSource = typeof(FrontDeskApp.Models.boxtype);
            // 
            // bSourceBoxRecord
            // 
            this.bSourceBoxRecord.DataSource = typeof(FrontDeskApp.Models.box);
            // 
            // bSourceCustomerRecord
            // 
            this.bSourceCustomerRecord.DataSource = typeof(FrontDeskApp.Models.customerrecord);
            // 
            // customerrecordidDataGridViewTextBoxColumn
            // 
            this.customerrecordidDataGridViewTextBoxColumn.DataPropertyName = "customerrecordid";
            this.customerrecordidDataGridViewTextBoxColumn.HeaderText = "customerrecordid";
            this.customerrecordidDataGridViewTextBoxColumn.Name = "customerrecordidDataGridViewTextBoxColumn";
            this.customerrecordidDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerrecordidDataGridViewTextBoxColumn.Visible = false;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customerid";
            this.customeridDataGridViewTextBoxColumn.DataSource = this.bSourceCustomers;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customeridDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.customeridDataGridViewTextBoxColumn.DisplayMember = "firstname";
            this.customeridDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customeridDataGridViewTextBoxColumn.HeaderText = "First name";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.customeridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customeridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.customeridDataGridViewTextBoxColumn.ValueMember = "customerid";
            // 
            // customerid
            // 
            this.customerid.DataPropertyName = "customerid";
            this.customerid.DataSource = this.bSourceCustomers;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerid.DefaultCellStyle = dataGridViewCellStyle3;
            this.customerid.DisplayMember = "lastname";
            this.customerid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerid.HeaderText = "Last name";
            this.customerid.Name = "customerid";
            this.customerid.ReadOnly = true;
            this.customerid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.customerid.ValueMember = "customerid";
            // 
            // boxtypeid
            // 
            this.boxtypeid.DataPropertyName = "boxtypeid";
            this.boxtypeid.DataSource = this.bSourceBoxtype;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxtypeid.DefaultCellStyle = dataGridViewCellStyle4;
            this.boxtypeid.DisplayMember = "boxtypename";
            this.boxtypeid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxtypeid.HeaderText = "Box Type";
            this.boxtypeid.Name = "boxtypeid";
            this.boxtypeid.ReadOnly = true;
            this.boxtypeid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.boxtypeid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.boxtypeid.ValueMember = "boxtypeid";
            // 
            // boxidDataGridViewTextBoxColumn
            // 
            this.boxidDataGridViewTextBoxColumn.DataPropertyName = "boxid";
            this.boxidDataGridViewTextBoxColumn.DataSource = this.bSourceBoxRecord;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.boxidDataGridViewTextBoxColumn.DisplayMember = "boxnumber";
            this.boxidDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxidDataGridViewTextBoxColumn.HeaderText = "Box Number";
            this.boxidDataGridViewTextBoxColumn.Name = "boxidDataGridViewTextBoxColumn";
            this.boxidDataGridViewTextBoxColumn.ReadOnly = true;
            this.boxidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.boxidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.boxidDataGridViewTextBoxColumn.ValueMember = "boxid";
            // 
            // validationDataGridViewTextBoxColumn
            // 
            this.validationDataGridViewTextBoxColumn.DataPropertyName = "Validation";
            this.validationDataGridViewTextBoxColumn.HeaderText = "Validation";
            this.validationDataGridViewTextBoxColumn.Name = "validationDataGridViewTextBoxColumn";
            this.validationDataGridViewTextBoxColumn.ReadOnly = true;
            this.validationDataGridViewTextBoxColumn.Visible = false;
            // 
            // boxDataGridViewTextBoxColumn
            // 
            this.boxDataGridViewTextBoxColumn.DataPropertyName = "boxid";
            this.boxDataGridViewTextBoxColumn.HeaderText = "boxid";
            this.boxDataGridViewTextBoxColumn.Name = "boxDataGridViewTextBoxColumn";
            this.boxDataGridViewTextBoxColumn.ReadOnly = true;
            this.boxDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerDataGridViewTextBoxColumn.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.DefaultCellStyle = dataGridViewCellStyle6;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // frmStoreRetrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 663);
            this.Controls.Add(this.btnRetrive);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.gridUsers);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStoreRetrive";
            this.Text = "frmRetRes";
            this.Load += new System.EventHandler(this.frmStoreRetrive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceBoxtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceBoxRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSourceCustomerRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.Button btnRetrive;
        private System.Windows.Forms.BindingSource bSourceCustomerRecord;
        private System.Windows.Forms.BindingSource bSourceCustomers;
        private System.Windows.Forms.BindingSource bSourceBoxRecord;
        private System.Windows.Forms.BindingSource bSourceBoxtype;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerrecordidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn customerid;
        private System.Windows.Forms.DataGridViewComboBoxColumn boxtypeid;
        private System.Windows.Forms.DataGridViewComboBoxColumn boxidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}