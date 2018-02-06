using Common.Library;
using IMS.Data.DLL.Context;
using IMS.Service.BAL;
using IMS.Service.DLL.IContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace IMS.Desktop.Views
{
    public partial class SupplierForm : Form
    {
        private readonly SupplierContext supplierContext;

        public SupplierForm()
        {
            InitializeComponent();

            var container = new UnityContainer();
            container.RegisterType<ISupplierContext, DllSupplierContext>();

            this.supplierContext = container.Resolve<SupplierContext>();

            DisplayData();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            bool res;
            string SupplierName = txtSupplierName.Text;
            string SupplierAddress = txtSupplierAddress.Text;
           

            if(hdnSupplierId.Text == String.Empty)
            {
                res = supplierContext.CreateSupplier(SupplierName, SupplierAddress);
            }
            else
            {
                int SupplierId = int.Parse(hdnSupplierId.Text);
                res = supplierContext.UpdateSupplier(SupplierId, SupplierName, SupplierAddress);
                hdnSupplierId.Text = "";
            }

            if (res)
            {
                MessageBox.Show("Success");
                Refresh();
            }
            else
            {
                lblError.Text = "";
                lblError.ForeColor = Color.Red;
                foreach(string err in ModelState.ErrorMessages)
                {
                    lblError.Text += err + "\n";

                    MessageBox.Show(err);
                }
                ModelState.ErrorMessages.Clear();



            }


        }

        private void Refresh()
        {
            txtSupplierName.Text = String.Empty;
            txtSupplierAddress.Text = String.Empty;
            btnDelete.Enabled = false;

            DisplayData();
        }

        private void DisplayData()
        {

            var data = supplierContext.GetAllSupplier();
            gvSupplier.DataSource = data;

            gvSupplier.Columns["Id"].Visible = false;
            gvSupplier.Columns["Receiveds"].Visible = false;
            gvSupplier.Columns["SupplierName"].HeaderText = "Supplier Name";
            gvSupplier.Columns["SupplierAddress"].HeaderText = "Supplier Address";

            

        }

        private void gvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.gvSupplier.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                hdnSupplierId.Text = row.Cells[0].Value.ToString();
                txtSupplierName.Text = row.Cells[1].Value.ToString();
                txtSupplierAddress.Text = row.Cells[2].Value.ToString();

                btnDelete.Enabled = true;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool res;
            


            if (hdnSupplierId.Text == String.Empty)
            {
                MessageBox.Show("Please select any row from the table below");
               
                res = false;
            }
            else
            {
                int SupplierId = int.Parse(hdnSupplierId.Text);
                res = supplierContext.DeleteSupplier(SupplierId);
                hdnSupplierId.Text = "";
                
            }

            if (res)
            {
                MessageBox.Show("Success");
                Refresh();
            }
            else
            {
                MessageBox.Show("Error Deleting the record");
            }

            btnDelete.Enabled = false;
        }

        private void txtSupplierName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSupplierAddress.Focus();
            }
        }
    }
}
