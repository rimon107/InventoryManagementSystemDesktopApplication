namespace IMS.Desktop.Views.Common
{
    partial class MaterialSearchForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gvMaterial = new System.Windows.Forms.DataGridView();
            this.btnMaterialFind = new System.Windows.Forms.Button();
            this.txtMaterialSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(490, 463);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 23;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(571, 463);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gvMaterial
            // 
            this.gvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMaterial.Location = new System.Drawing.Point(24, 63);
            this.gvMaterial.Name = "gvMaterial";
            this.gvMaterial.Size = new System.Drawing.Size(622, 384);
            this.gvMaterial.TabIndex = 21;
            this.gvMaterial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMaterial_CellDoubleClick);
            // 
            // btnMaterialFind
            // 
            this.btnMaterialFind.Location = new System.Drawing.Point(618, 22);
            this.btnMaterialFind.Name = "btnMaterialFind";
            this.btnMaterialFind.Size = new System.Drawing.Size(28, 23);
            this.btnMaterialFind.TabIndex = 20;
            this.btnMaterialFind.Text = "...";
            this.btnMaterialFind.UseVisualStyleBackColor = true;
            // 
            // txtMaterialSearch
            // 
            this.txtMaterialSearch.Location = new System.Drawing.Point(54, 24);
            this.txtMaterialSearch.Name = "txtMaterialSearch";
            this.txtMaterialSearch.Size = new System.Drawing.Size(558, 20);
            this.txtMaterialSearch.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Find";
            // 
            // MaterialSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 507);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gvMaterial);
            this.Controls.Add(this.btnMaterialFind);
            this.Controls.Add(this.txtMaterialSearch);
            this.Controls.Add(this.label1);
            this.Name = "MaterialSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MaterialSearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView gvMaterial;
        private System.Windows.Forms.Button btnMaterialFind;
        private System.Windows.Forms.TextBox txtMaterialSearch;
        private System.Windows.Forms.Label label1;
    }
}