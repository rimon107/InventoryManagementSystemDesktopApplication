using Common.Library;
using CommonServiceLocator;
using IMS.Data.Model;
using IMS.Service.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.Desktop.Views.Common
{
    public partial class ManufacturerSearchForm : Form
    {
        private readonly GenericContext<Manufacturer> Context;

        public ManufacturerSearchForm()
        {
            InitializeComponent();
            Context = ServiceLocator.Current.GetInstance<GenericContext<Manufacturer>>();

            LoadData();
        }

        private void LoadData()
        {
            
            var data = Context.GetAll();
            gvManufacturer.DataSource = data;
            gvManufacturer.AllowUserToAddRows = false;

            gvManufacturer.Columns["Id"].Visible = false;

            gvManufacturer.Columns["Name"].HeaderText = "Manufacturer Name";
            gvManufacturer.Columns["Name"].ReadOnly = true;
            gvManufacturer.Columns["Address"].HeaderText = "Manufacturer Address";
            gvManufacturer.Columns["Address"].ReadOnly = true;

            gvManufacturer.Columns["Name"].Width = 200;
            gvManufacturer.Columns["Address"].Width = 380;


        }

        private void gvManufacturer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = new DataGridViewCommon().GetSelectedRow(this.gvManufacturer);

            if (row == null)
            {
                MessageBox.Show("Please select a row.");
            }
            else
            {
                SetManufacturer(row);

                CloseForm();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var row = new DataGridViewCommon().GetSelectedRow(this.gvManufacturer);

            if (row == null)
            {
                MessageBox.Show("Please select a row.");
            }
            else
            {
                SetManufacturer(row);

                CloseForm();
            }
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void SetManufacturer(DataGridViewRow row)
        {
            var _Manufacturer = new Manufacturer();

            _Manufacturer.Id = int.Parse(row.Cells["Id"].Value.ToString());
            _Manufacturer.Name = row.Cells["Name"].Value.ToString();
            _Manufacturer.Address = row.Cells["Address"].Value.ToString();


            Entity<Manufacturer>.entity = _Manufacturer;
        }
        
    }
}
