namespace IMS.Desktop.Views.Received
{
    partial class QuarantineReceiveForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransactionRefNo = new System.Windows.Forms.TextBox();
            this.btnTransactionRefSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeTransaction = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.btnSupplierFind = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGRN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimeGRN = new System.Windows.Forms.DateTimePicker();
            this.cmbPlantInfo = new System.Windows.Forms.ComboBox();
            this.dateTimeChallan = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChallan = new System.Windows.Forms.TextBox();
            this.dateTimeVATChallan = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVATChallan = new System.Windows.Forms.TextBox();
            this.gvReceiveDetail = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.txtReceiveText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddNewRow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvReceiveDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Ref #";
            // 
            // txtTransactionRefNo
            // 
            this.txtTransactionRefNo.Location = new System.Drawing.Point(136, 39);
            this.txtTransactionRefNo.Name = "txtTransactionRefNo";
            this.txtTransactionRefNo.Size = new System.Drawing.Size(133, 20);
            this.txtTransactionRefNo.TabIndex = 1;
            // 
            // btnTransactionRefSearch
            // 
            this.btnTransactionRefSearch.Location = new System.Drawing.Point(275, 37);
            this.btnTransactionRefSearch.Name = "btnTransactionRefSearch";
            this.btnTransactionRefSearch.Size = new System.Drawing.Size(26, 23);
            this.btnTransactionRefSearch.TabIndex = 2;
            this.btnTransactionRefSearch.Text = "...";
            this.btnTransactionRefSearch.UseVisualStyleBackColor = true;
            this.btnTransactionRefSearch.Click += new System.EventHandler(this.btnTransactionRefSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transaction Ref Date";
            // 
            // dateTimeTransaction
            // 
            this.dateTimeTransaction.Enabled = false;
            this.dateTimeTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTransaction.Location = new System.Drawing.Point(136, 63);
            this.dateTimeTransaction.Name = "dateTimeTransaction";
            this.dateTimeTransaction.Size = new System.Drawing.Size(165, 20);
            this.dateTimeTransaction.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Supplier Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Supplier Name";
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Enabled = false;
            this.txtSupplierId.Location = new System.Drawing.Point(136, 87);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(133, 20);
            this.txtSupplierId.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Supplier Id";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Enabled = false;
            this.txtSupplierName.Location = new System.Drawing.Point(136, 111);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(165, 20);
            this.txtSupplierName.TabIndex = 14;
            // 
            // btnSupplierFind
            // 
            this.btnSupplierFind.Location = new System.Drawing.Point(275, 84);
            this.btnSupplierFind.Name = "btnSupplierFind";
            this.btnSupplierFind.Size = new System.Drawing.Size(26, 23);
            this.btnSupplierFind.TabIndex = 15;
            this.btnSupplierFind.Text = "...";
            this.btnSupplierFind.UseVisualStyleBackColor = true;
            this.btnSupplierFind.Click += new System.EventHandler(this.btnSupplierFind_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(687, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "GRN Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(696, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "GRN No";
            // 
            // txtGRN
            // 
            this.txtGRN.Location = new System.Drawing.Point(757, 24);
            this.txtGRN.Name = "txtGRN";
            this.txtGRN.Size = new System.Drawing.Size(170, 20);
            this.txtGRN.TabIndex = 17;
            this.txtGRN.Enter += new System.EventHandler(this.RandomNumberGenerate);
            this.txtGRN.Leave += new System.EventHandler(this.RandomNumberGenerate);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Plant";
            // 
            // dateTimeGRN
            // 
            this.dateTimeGRN.Enabled = false;
            this.dateTimeGRN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeGRN.Location = new System.Drawing.Point(757, 48);
            this.dateTimeGRN.Name = "dateTimeGRN";
            this.dateTimeGRN.Size = new System.Drawing.Size(170, 20);
            this.dateTimeGRN.TabIndex = 44;
            // 
            // cmbPlantInfo
            // 
            this.cmbPlantInfo.Enabled = false;
            this.cmbPlantInfo.FormattingEnabled = true;
            this.cmbPlantInfo.Location = new System.Drawing.Point(136, 14);
            this.cmbPlantInfo.Name = "cmbPlantInfo";
            this.cmbPlantInfo.Size = new System.Drawing.Size(165, 21);
            this.cmbPlantInfo.TabIndex = 45;
            // 
            // dateTimeChallan
            // 
            this.dateTimeChallan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeChallan.Location = new System.Drawing.Point(757, 97);
            this.dateTimeChallan.Name = "dateTimeChallan";
            this.dateTimeChallan.Size = new System.Drawing.Size(170, 20);
            this.dateTimeChallan.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(676, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Challan Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(639, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Challan / Invoice No";
            // 
            // txtChallan
            // 
            this.txtChallan.Location = new System.Drawing.Point(757, 72);
            this.txtChallan.Name = "txtChallan";
            this.txtChallan.Size = new System.Drawing.Size(170, 20);
            this.txtChallan.TabIndex = 46;
            // 
            // dateTimeVATChallan
            // 
            this.dateTimeVATChallan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeVATChallan.Location = new System.Drawing.Point(757, 145);
            this.dateTimeVATChallan.Name = "dateTimeVATChallan";
            this.dateTimeVATChallan.ShowCheckBox = true;
            this.dateTimeVATChallan.Size = new System.Drawing.Size(170, 20);
            this.dateTimeVATChallan.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(652, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "VAT Challan Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(661, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "VAT Challan No";
            // 
            // txtVATChallan
            // 
            this.txtVATChallan.Location = new System.Drawing.Point(757, 121);
            this.txtVATChallan.Name = "txtVATChallan";
            this.txtVATChallan.Size = new System.Drawing.Size(170, 20);
            this.txtVATChallan.TabIndex = 50;
            // 
            // gvReceiveDetail
            // 
            this.gvReceiveDetail.AllowUserToAddRows = false;
            this.gvReceiveDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvReceiveDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvReceiveDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvReceiveDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvReceiveDetail.Location = new System.Drawing.Point(28, 222);
            this.gvReceiveDetail.Name = "gvReceiveDetail";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvReceiveDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvReceiveDetail.Size = new System.Drawing.Size(1543, 295);
            this.gvReceiveDetail.TabIndex = 54;
            this.gvReceiveDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvReceiveDetail_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(952, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 23);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1041, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 23);
            this.btnClose.TabIndex = 56;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Enabled = false;
            this.txtSupplierAddress.Location = new System.Drawing.Point(136, 135);
            this.txtSupplierAddress.Multiline = true;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(344, 67);
            this.txtSupplierAddress.TabIndex = 13;
            // 
            // txtReceiveText
            // 
            this.txtReceiveText.Location = new System.Drawing.Point(159, 531);
            this.txtReceiveText.Multiline = true;
            this.txtReceiveText.Name = "txtReceiveText";
            this.txtReceiveText.Size = new System.Drawing.Size(962, 50);
            this.txtReceiveText.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 546);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "Receive Text/ Comments";
            // 
            // btnAddNewRow
            // 
            this.btnAddNewRow.Location = new System.Drawing.Point(952, 193);
            this.btnAddNewRow.Name = "btnAddNewRow";
            this.btnAddNewRow.Size = new System.Drawing.Size(169, 23);
            this.btnAddNewRow.TabIndex = 59;
            this.btnAddNewRow.Text = "Add New Row";
            this.btnAddNewRow.UseVisualStyleBackColor = true;
            this.btnAddNewRow.Click += new System.EventHandler(this.btnAddNewRow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(952, 92);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(169, 23);
            this.btnClear.TabIndex = 60;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // QuarantineReceiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 595);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddNewRow);
            this.Controls.Add(this.txtReceiveText);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gvReceiveDetail);
            this.Controls.Add(this.dateTimeVATChallan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtVATChallan);
            this.Controls.Add(this.dateTimeChallan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtChallan);
            this.Controls.Add(this.cmbPlantInfo);
            this.Controls.Add(this.dateTimeGRN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtGRN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSupplierFind);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtSupplierAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSupplierId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimeTransaction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTransactionRefSearch);
            this.Controls.Add(this.txtTransactionRefNo);
            this.Controls.Add(this.label1);
            this.Name = "QuarantineReceiveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Receive(Quarantine)";
            ((System.ComponentModel.ISupportInitialize)(this.gvReceiveDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTransactionRefNo;
        private System.Windows.Forms.Button btnTransactionRefSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeTransaction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Button btnSupplierFind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGRN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimeGRN;
        private System.Windows.Forms.ComboBox cmbPlantInfo;
        private System.Windows.Forms.DateTimePicker dateTimeChallan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChallan;
        private System.Windows.Forms.DateTimePicker dateTimeVATChallan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVATChallan;
        private System.Windows.Forms.DataGridView gvReceiveDetail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.TextBox txtReceiveText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddNewRow;
        private System.Windows.Forms.Button btnClear;
    }
}