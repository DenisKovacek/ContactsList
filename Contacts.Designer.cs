namespace Contacts
{
    partial class Contacts
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
            this.lblContactID = new System.Windows.Forms.Label();
            this.textBoxContactID = new System.Windows.Forms.TextBox();
            this.textBoxContactNo = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContactID
            // 
            this.lblContactID.AutoSize = true;
            this.lblContactID.Location = new System.Drawing.Point(37, 57);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(86, 20);
            this.lblContactID.TabIndex = 0;
            this.lblContactID.Text = "Contact ID";
            // 
            // textBoxContactID
            // 
            this.textBoxContactID.Location = new System.Drawing.Point(129, 51);
            this.textBoxContactID.Name = "textBoxContactID";
            this.textBoxContactID.ReadOnly = true;
            this.textBoxContactID.Size = new System.Drawing.Size(202, 26);
            this.textBoxContactID.TabIndex = 1;
            // 
            // textBoxContactNo
            // 
            this.textBoxContactNo.Location = new System.Drawing.Point(129, 212);
            this.textBoxContactNo.Name = "textBoxContactNo";
            this.textBoxContactNo.Size = new System.Drawing.Size(202, 26);
            this.textBoxContactNo.TabIndex = 3;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(37, 212);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(89, 20);
            this.lblContactNo.TabIndex = 2;
            this.lblContactNo.Text = "Contact No";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(129, 154);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(202, 26);
            this.textBoxLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(37, 160);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(129, 103);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(202, 26);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(37, 109);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(129, 268);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(202, 143);
            this.textBoxAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(37, 268);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(129, 457);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(202, 28);
            this.comboBoxGender.TabIndex = 10;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(37, 465);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(55, 504);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 43);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(169, 504);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 43);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(294, 504);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 43);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(417, 504);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 43);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvContactList
            // 
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Location = new System.Drawing.Point(376, 103);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.RowHeadersWidth = 62;
            this.dgvContactList.RowTemplate.Height = 28;
            this.dgvContactList.Size = new System.Drawing.Size(542, 382);
            this.dgvContactList.TabIndex = 16;
            this.dgvContactList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContactList_RowHeaderMouseClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(372, 51);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 20);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(456, 45);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(462, 26);
            this.textBoxSearch.TabIndex = 18;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 555);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvContactList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.textBoxContactNo);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.textBoxContactID);
            this.Controls.Add(this.lblContactID);
            this.Name = "Contacts";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Contacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContactID;
        private System.Windows.Forms.TextBox textBoxContactID;
        private System.Windows.Forms.TextBox textBoxContactNo;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}

