using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.Desktop.Views.Received
{
    public partial class TransactionSourceSearchForm : Form
    {
        public TransactionSourceSearchForm()
        {
            InitializeComponent();
        }

        private void btnTransactionFind_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
