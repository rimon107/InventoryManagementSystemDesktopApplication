using Common.Library;
using IMS.Data.DAL.Context;
using IMS.Data.DAL.IContext;
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
using Unity;

namespace IMS.Desktop.Views.Common
{
    public partial class SupplierSearchForm : Form
    {
        private readonly GenericContext<Supplier> Context;

        public SupplierSearchForm()
        {
            InitializeComponent();

            var container = new UnityContainer();

            container.RegisterType<IContext<Supplier>, Context<Supplier>>();

            Context = container.Resolve<GenericContext<Supplier>>();

            LoadData();
        }

        private void LoadData()
        {
            Context.SetEntityList();
            var data = Context.EntityList;
            gvSupplier.DataSource = data;
            gvSupplier.AllowUserToAddRows = false;

            gvSupplier.Columns["Id"].Visible = false;
            
            gvSupplier.Columns["Name"].HeaderText = "Supplier Name";
            gvSupplier.Columns["Name"].ReadOnly = true;
            gvSupplier.Columns["Address"].HeaderText = "Supplier Address";
            gvSupplier.Columns["Address"].ReadOnly = true;

            gvSupplier.Columns["Name"].Width = 200;
            gvSupplier.Columns["Address"].Width = 380;


        }

        private void gvSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = GetSelectedRow();

            if (row == null)
            {
                MessageBox.Show("Please select a row.");
            }
            else
            {
                SetSupplier(row);

                CloseForm();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var row = GetSelectedRow();

            if(row == null)
            {
                MessageBox.Show("Please select a row.");
            }
            else
            {
                SetSupplier(row);

                CloseForm();
            }
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void SetSupplier(DataGridViewRow row)
        {
            var _Supplier = new Supplier();

            _Supplier.Id = int.Parse(row.Cells["Id"].Value.ToString());
            _Supplier.Name = row.Cells["Name"].Value.ToString();
            _Supplier.Address = row.Cells["Address"].Value.ToString();


            Entity<Supplier>.entity = _Supplier;
        }

        private DataGridViewRow GetSelectedRow()
        {
            DataGridViewRow row;
            try
            {
                Int32 selectedRowCount = gvSupplier.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if(selectedRowCount == 1)
                {
                    row = gvSupplier.SelectedRows[0];
                }
                else 
                {
                    if (selectedRowCount > 1)
                    {
                        row = null;
                    }
                    else
                    {
                        try
                        {
                            var RowIndex = gvSupplier.SelectedCells[0].RowIndex;
                            row = gvSupplier.Rows[RowIndex];
                        }
                        catch
                        {
                            row = null;
                        }
                    }
                }
                
                
            }
            catch
            {
                

                row = null;

            }

            return row;
        }
    }
}
