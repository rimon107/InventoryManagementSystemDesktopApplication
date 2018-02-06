namespace IMS.Desktop.Views
{
    partial class SupplierForm
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
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gvSupplier = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.hdnSupplierId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(510, 36);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(71, 13);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "Supplier Form";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(425, 107);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(76, 13);
            this.lblSupplierName.TabIndex = 1;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(553, 104);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(193, 20);
            this.txtSupplierName.TabIndex = 2;
            this.txtSupplierName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSupplierName_KeyDown);
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Location = new System.Drawing.Point(553, 162);
            this.txtSupplierAddress.Multiline = true;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(193, 87);
            this.txtSupplierAddress.TabIndex = 4;
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Location = new System.Drawing.Point(425, 202);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(86, 13);
            this.lblSupplierAddress.TabIndex = 3;
            this.lblSupplierAddress.Text = "Supplier Address";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(597, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gvSupplier
            // 
            this.gvSupplier.AllowUserToAddRows = false;
            this.gvSupplier.AllowUserToDeleteRows = false;
            this.gvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSupplier.Location = new System.Drawing.Point(379, 412);
            this.gvSupplier.MultiSelect = false;
            this.gvSupplier.Name = "gvSupplier";
            this.gvSupplier.ReadOnly = true;
            this.gvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSupplier.ShowEditingIcon = false;
            this.gvSupplier.Size = new System.Drawing.Size(379, 150);
            this.gvSupplier.TabIndex = 6;
            this.gvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSupplier_CellClick);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Black;
            this.lblError.Location = new System.Drawing.Point(489, 58);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 7;
            // 
            // hdnSupplierId
            // 
            this.hdnSupplierId.AutoSize = true;
            this.hdnSupplierId.Location = new System.Drawing.Point(470, 9);
            this.hdnSupplierId.Name = "hdnSupplierId";
            this.hdnSupplierId.Size = new System.Drawing.Size(0, 13);
            this.hdnSupplierId.TabIndex = 8;
            this.hdnSupplierId.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(671, 297);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 39);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(671, 36);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 610);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.hdnSupplierId);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.gvSupplier);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSupplierAddress);
            this.Controls.Add(this.lblSupplierAddress);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblSupplier);
            this.Name = "SupplierForm";
            this.Text = "SupplyForm";
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gvSupplier;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label hdnSupplierId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}