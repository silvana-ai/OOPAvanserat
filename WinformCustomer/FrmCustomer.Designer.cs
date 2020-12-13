namespace WinformCustomer
{
    partial class FrmCustomer
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
            this.dtgGridCustomer = new System.Windows.Forms.DataGridView();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBillingDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBillingAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCustomerType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.DalLayer = new System.Windows.Forms.ComboBox();
            this.btnUOW = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGridCustomer
            // 
            this.dtgGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGridCustomer.Location = new System.Drawing.Point(26, 202);
            this.dtgGridCustomer.Name = "dtgGridCustomer";
            this.dtgGridCustomer.RowHeadersWidth = 62;
            this.dtgGridCustomer.RowTemplate.Height = 24;
            this.dtgGridCustomer.Size = new System.Drawing.Size(879, 312);
            this.dtgGridCustomer.TabIndex = 32;
            this.dtgGridCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGridCustomer_CellContentClick);
            this.dtgGridCustomer.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGridCustomer_RowEnter);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(442, 103);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(228, 82);
            this.txtAddress.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Email";
            // 
            // txtBillingDate
            // 
            this.txtBillingDate.Location = new System.Drawing.Point(442, 60);
            this.txtBillingDate.Name = "txtBillingDate";
            this.txtBillingDate.Size = new System.Drawing.Size(163, 26);
            this.txtBillingDate.TabIndex = 25;
            this.txtBillingDate.Text = "1/1/2010";
            this.txtBillingDate.TextChanged += new System.EventHandler(this.txtBillingDate_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Bill Date";
            // 
            // txtBillingAmount
            // 
            this.txtBillingAmount.Location = new System.Drawing.Point(442, 17);
            this.txtBillingAmount.Name = "txtBillingAmount";
            this.txtBillingAmount.Size = new System.Drawing.Size(163, 26);
            this.txtBillingAmount.TabIndex = 22;
            this.txtBillingAmount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Bill Amount";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(165, 103);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(163, 26);
            this.txtPhoneNumber.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Phone number";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(165, 60);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(163, 26);
            this.txtCustomerName.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Customer Name";
            // 
            // cmbCustomerType
            // 
            this.cmbCustomerType.FormattingEnabled = true;
            this.cmbCustomerType.Items.AddRange(new object[] {
            "Lead",
            "Customer",
            "SelfService",
            "HomeDelivery"});
            this.cmbCustomerType.Location = new System.Drawing.Point(165, 14);
            this.cmbCustomerType.Name = "cmbCustomerType";
            this.cmbCustomerType.Size = new System.Drawing.Size(163, 28);
            this.cmbCustomerType.TabIndex = 20;
            this.cmbCustomerType.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Customer Type";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 152);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 43);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add/Update";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DalLayer
            // 
            this.DalLayer.FormattingEnabled = true;
            this.DalLayer.Location = new System.Drawing.Point(639, 17);
            this.DalLayer.Name = "DalLayer";
            this.DalLayer.Size = new System.Drawing.Size(163, 28);
            this.DalLayer.TabIndex = 39;
            this.DalLayer.SelectedIndexChanged += new System.EventHandler(this.DalLayer_SelectedIndexChanged);
            // 
            // btnUOW
            // 
            this.btnUOW.Location = new System.Drawing.Point(692, 126);
            this.btnUOW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUOW.Name = "btnUOW";
            this.btnUOW.Size = new System.Drawing.Size(112, 60);
            this.btnUOW.TabIndex = 40;
            this.btnUOW.Text = "UOW";
            this.btnUOW.UseVisualStyleBackColor = true;
            this.btnUOW.Click += new System.EventHandler(this.btnUOW_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(171, 151);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 45);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(292, 152);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 529);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUOW);
            this.Controls.Add(this.DalLayer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgGridCustomer);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBillingDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBillingAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCustomerType);
            this.Controls.Add(this.label1);
            this.Name = "FrmCustomer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGridCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGridCustomer;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBillingDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBillingAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCustomerType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox DalLayer;
        private System.Windows.Forms.Button btnUOW;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}

