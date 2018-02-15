using Common.Library;
using IMS.Data.DAL.Context;
using IMS.Data.DAL.IContext;
using IMS.Data.Model;
using IMS.Service.BLL;
using System;
using System.Windows.Forms;
using Unity;

namespace IMS.Desktop.Views.Common
{
    public partial class MaterialSearchForm : Form
    {
        private readonly GenericContext<Material> Context;
        public event EventHandler<MessageEventArgs<Material>> btnAddMaterial;

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
            InsertMaterial();
            CloseForm();
        }

        private void AddMaterialToParent()
        {
            var row = new DataGridViewCommon().GetSelectedRow(this.gvMaterial);

            if (row == null)
            {
                MessageBox.Show("Please select a row.");
            }
            else
            {
                SetMaterial(row);

                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void gvMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var row = GetSelectedRow();

            //if (row == null)
            //{
            //    MessageBox.Show("Please select a row.");
            //}
            //else
            //{
            //    SetMaterial(row);

            //    CloseForm();
            //}

            InsertMaterial();

        }

        private void CloseForm()
        {
            Entity<Material>.check = false;
            this.Close();
        }

        private void SetMaterial(DataGridViewRow row)
        {
            var _Material = new Material();

            _Material.MaterialCode = row.Cells["MaterialCode"].Value.ToString();
            _Material.MaterialName = row.Cells["MaterialName"].Value.ToString();
            _Material.Unit = row.Cells["Unit"].Value.ToString();
            
            Entity<Material>.entity = _Material;
            Entity<Material>.check = true;
        }
        
        private void InsertMaterial()
        {
            var _Material = new Material();

            var row = new DataGridViewCommon().GetSelectedRow(this.gvMaterial);

            _Material.MaterialCode = row.Cells["MaterialCode"].Value.ToString();
            _Material.MaterialName = row.Cells["MaterialName"].Value.ToString();
            _Material.Unit = row.Cells["Unit"].Value.ToString();

            EventHandler<MessageEventArgs<Material>> handler = btnAddMaterial;

            if (handler != null)
            {
                handler(this, new MessageEventArgs<Material>(_Material));
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertMaterial();
        }

        
    }
}
