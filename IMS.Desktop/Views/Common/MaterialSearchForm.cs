using Common.Library;
using IMS.Data.DLL.Context;
using IMS.Data.DLL.IContext;
using IMS.Data.Model;
using IMS.Service.BAL;
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
    public partial class MaterialSearchForm : Form
    {
        private readonly GenericContext<Material> Context;

        public MaterialSearchForm()
        {
            InitializeComponent();

            var container = new UnityContainer();

            container.RegisterType<IContext<Material>, Context<Material>>();

            Context = container.Resolve<GenericContext<Material>>();

            LoadData();
        }

        private void LoadData()
        {
            Context.SetEntityList();
            var data = Context.EntityList;
            gvMaterial.DataSource = data;
            gvMaterial.AllowUserToAddRows = false;

            for (int i = 0; i < gvMaterial.Columns.Count; i++)
            {
                gvMaterial.Columns[i].Visible = false;
            }

            gvMaterial.Columns["MaterialCode"].HeaderText = "Material Code";
            gvMaterial.Columns["MaterialCode"].ReadOnly = true;
            gvMaterial.Columns["MaterialCode"].Visible = true;

            gvMaterial.Columns["MaterialName"].HeaderText = "Material Name";
            gvMaterial.Columns["MaterialName"].ReadOnly = true;
            gvMaterial.Columns["MaterialName"].Visible = true;

            gvMaterial.Columns["Unit"].HeaderText = "Unit";
            gvMaterial.Columns["Unit"].ReadOnly = true;
            gvMaterial.Columns["Unit"].Visible = true;


            gvMaterial.Columns["MaterialCode"].Width = 200;
            gvMaterial.Columns["MaterialName"].Width = 200;
            gvMaterial.Columns["Unit"].Width = 180;


        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var row = GetSelectedRow();

            if (row == null)
            {
                MessageBox.Show("Please select a row.");
            }
            else
            {
                SetMaterial(row);

                CloseForm();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void gvMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = GetSelectedRow();

            if (row == null)
            {
                MessageBox.Show("Please select a row.");
            }
            else
            {
                SetMaterial(row);

                CloseForm();
            }
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void SetMaterial(DataGridViewRow row)
        {
            var _Material = new Material();

            _Material.MaterialCode = row.Cells["MaterialCode"].Value.ToString();
            _Material.MaterialName = row.Cells["MaterialName"].Value.ToString();
            _Material.Unit = row.Cells["Unit"].Value.ToString();
            
            Entity<Material>.entity = _Material;
        }

        private DataGridViewRow GetSelectedRow()
        {
            DataGridViewRow row;
            try
            {
                Int32 selectedRowCount = gvMaterial.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount == 1)
                {
                    row = gvMaterial.SelectedRows[0];
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
                            var RowIndex = gvMaterial.SelectedCells[0].RowIndex;
                            row = gvMaterial.Rows[RowIndex];
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
