using Common.Library;
using IMS.Data.Model;
using IMS.Desktop.Views.Received;
using IMS.Desktop.Views.Security;
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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            Login.Visible = true;
            LogOut.Visible = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            new Login().ShowDialog();

            if (Session<UserManager>.LoginStatus)
            {
                Login.Visible = false;
                LogOut.Visible = true;
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            if (Session<UserManager>.LoginStatus)
            {
                Session<UserManager>.LoginStatus = false;
                Session<UserManager>.User = null;
                Login.Visible = true;
                LogOut.Visible = false;
            }
            else
            {
                Session<UserManager>.User = null;
                Login.Visible = true;
                LogOut.Visible = false;
            }
        }

        private void Supplier_Click(object sender, EventArgs e)
        {
            //new SupplierForm().ShowDialog();
        }

        private void ReceiveQuarantine_Click(object sender, EventArgs e)
        {
            new QuarantineReceiveForm().ShowDialog();
        }
    }
}
