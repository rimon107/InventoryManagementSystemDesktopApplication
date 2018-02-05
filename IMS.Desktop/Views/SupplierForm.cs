using IMS.Service.BAL.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.Desktop.Views
{
    public partial class SupplierForm : Form
    {
        private readonly BalSupplierContext supplierContext;

        public SupplierForm()
        {
            InitializeComponent();

            this.supplierContext = new BalSupplierContext();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string SupplierName = txtSupplierName.Text;
            string SupplierAddress = txtSupplierAddress.Text;
            var res = supplierContext.CreateSupplier(SupplierName, SupplierAddress);

            if (res)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Error");
            }


        }
    }
}
