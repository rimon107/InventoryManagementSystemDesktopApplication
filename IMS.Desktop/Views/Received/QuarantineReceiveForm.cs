using Common.Library;
using IMS.Data.DLL.Context;
using IMS.Data.DLL.IContext;
using IMS.Data.Model;
using IMS.Desktop.Views.Common;
using IMS.Service.BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Unity;
using Unity.Injection;

namespace IMS.Desktop.Views.Received
{
    public partial class QuarantineReceiveForm : Form
    {

        #region Variables
        private GenericContext<PlantInfo> _PlantContext;
        private GenericContext<ReceiveDetail> _ReceiveDetailContext;
        private GenericContext<Receive> _ReceiveContext;


        #endregion

        public QuarantineReceiveForm()
        {
            InitializeComponent();

            var container = new UnityContainer();

            container.RegisterType<IContext<PlantInfo>, Context<PlantInfo>>("PlantInfo");
            container.RegisterType<GenericContext<PlantInfo>>("Plant",
                new InjectionConstructor(container.Resolve<IContext<PlantInfo>>("PlantInfo")));

            container.RegisterType<IContext<Receive>, Context<Receive>>("ReceiveInfo");
            container.RegisterType<GenericContext<Receive>>("Receive",
                new InjectionConstructor(container.Resolve<IContext<Receive>>("ReceiveInfo")));

            container.RegisterType<IContext<ReceiveDetail>, Context<ReceiveDetail>>("ReceiveDetailInfo");
            container.RegisterType<GenericContext<ReceiveDetail>>("ReceiveDetail",
                new InjectionConstructor(container.Resolve<IContext<ReceiveDetail>>("ReceiveDetailInfo")));

            _PlantContext = container.Resolve<GenericContext<PlantInfo>>("Plant");
            _ReceiveContext = container.Resolve<GenericContext<Receive>>("Receive");
            _ReceiveDetailContext = container.Resolve<GenericContext<ReceiveDetail>>("ReceiveDetail");

            LoadData();
        }

        private void LoadData()
        {
            cmbPlantInfo.DataSource = _PlantContext.GetAllEntity();
            cmbPlantInfo.ValueMember = "PlantID";
            cmbPlantInfo.DisplayMember = "PlantName";

            var data = _ReceiveDetailContext.GetAllEntity();
            //gvReceiveDetail.AutoGenerateColumns = false;
            if (data.Count == 0)
            {
                BindingList<ReceiveDetail> clientDataSource;
                clientDataSource = new BindingList<ReceiveDetail>() { AllowNew = true };
                clientDataSource.Add(new ReceiveDetail());
                var source = new BindingSource(clientDataSource, null);
                gvReceiveDetail.DataSource = clientDataSource;
                gvReceiveDetail.AllowUserToAddRows = false;

                gvReceiveDetail.Columns["Id"].Visible = false;
                gvReceiveDetail.Columns["ReceiveId"].Visible = false;
                gvReceiveDetail.Columns["IsQCReleased"].Visible = false;
                gvReceiveDetail.Columns["RestrictedQuantity"].Visible = false;
                gvReceiveDetail.Columns["Receive"].Visible = false;

                gvReceiveDetail.Columns["MaterialCode"].HeaderText = "Material Code";
                gvReceiveDetail.Columns["OrderQuantity"].HeaderText = "Order Quantity";
                gvReceiveDetail.Columns["ChallanQuantity"].HeaderText = "Challan Quantity";
                gvReceiveDetail.Columns["ReceivedQuantity"].HeaderText = "Received Quantity";
                gvReceiveDetail.Columns["DetailUnit"].HeaderText = "Detail Unit";
                gvReceiveDetail.Columns["DetailQuantity"].HeaderText = "Detail Quantity";
                gvReceiveDetail.Columns["UnitPrice"].HeaderText = "Unit Price";
                gvReceiveDetail.Columns["VatPercent"].HeaderText = "Vat Percent";

                gvReceiveDetail.Columns["VatAmount"].HeaderText = "Vat Amount";
                gvReceiveDetail.Columns["BatchNo"].HeaderText = "Batch No";
                gvReceiveDetail.Columns["ManufacturerId"].HeaderText = "Manufacturer";
                gvReceiveDetail.Columns["ManufacturerLotNo"].HeaderText = "Manufacturer Lot No";
                gvReceiveDetail.Columns["LotQuantity"].HeaderText = "Lot Quantity";
                gvReceiveDetail.Columns["NoOfPack"].HeaderText = "No Of Pack";

            }
            else
            {
                gvReceiveDetail.DataSource = data;
                gvReceiveDetail.Columns["Id"].Visible = false;
                gvReceiveDetail.Columns["ReceiveId"].Visible = false;
                gvReceiveDetail.Columns["IsQCReleased"].Visible = false;
                gvReceiveDetail.Columns["RestrictedQuantity"].Visible = false;
                gvReceiveDetail.Columns["Receive"].Visible = false;

                gvReceiveDetail.Columns["MaterialCode"].HeaderText = "Material Code";
                gvReceiveDetail.Columns["OrderQuantity"].HeaderText = "Order Quantity";
                gvReceiveDetail.Columns["ChallanQuantity"].HeaderText = "Challan Quantity";
                gvReceiveDetail.Columns["ReceivedQuantity"].HeaderText = "Received Quantity";
                gvReceiveDetail.Columns["DetailUnit"].HeaderText = "Detail Unit";
                gvReceiveDetail.Columns["DetailQuantity"].HeaderText = "Detail Quantity";
                gvReceiveDetail.Columns["UnitPrice"].HeaderText = "Unit Price";
                gvReceiveDetail.Columns["VatPercent"].HeaderText = "Vat Percent";
                gvReceiveDetail.Columns["VatAmount"].HeaderText = "Vat Amount";
                gvReceiveDetail.Columns["BatchNo"].HeaderText = "Batch No";
                gvReceiveDetail.Columns["ManufacturerId"].HeaderText = "Manufacturer";
                gvReceiveDetail.Columns["ManufacturerLotNo"].HeaderText = "Manufacturer Lot No";
                gvReceiveDetail.Columns["LotQuantity"].HeaderText = "Lot Quantity";
                gvReceiveDetail.Columns["NoOfPack"].HeaderText = "No Of Pack";
            }

            

            
            
            
            //gvReceiveDetail.Columns["SupplierAddress"].Width = 300;


        }

        private void btnSupplierFind_Click(object sender, EventArgs e)
        {
            new SupplierSearchForm().ShowDialog();
        }

        private void btnTransactionRefSearch_Click(object sender, EventArgs e)
        {
            new TransactionSourceSearchForm().ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RandomNumberGenerate(object sender, EventArgs e)
        {
            if (txtGRN.Text == String.Empty)
            {
                txtGRN.Text = RandomNumberGenerator.RandomNumberGenerate(111111, 222222);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var receive = new Receive();

            if (txtTransactionRefNo.Text != String.Empty)
            {
                receive.ReceiveReferenceNo = txtTransactionRefNo.Text;
            }
            receive.ReceiveReferenceDate = dateTimeTransaction.Value.Date;
            receive.SupplierId = txtSupplierName.Text;
            receive.GRNNo = txtGRN.Text;
            receive.GRNDate = dateTimeGRN.Value.Date;
            receive.ChallanNo = txtChallan.Text;
            receive.ChallanDate = dateTimeChallan.Value.Date;
            receive.VATChallanNo = txtVATChallan.Text;
            receive.VATChallanDate = dateTimeVATChallan.Value.Date;
            receive.ReceiveText = txtReceiveText.Text;
            receive.EntryBy = "Admin";
            receive.EntryDate = DateTime.Now;
            receive.PlantId = "1";

            var ReceiveEntity = _ReceiveContext.Create(receive);
            var recDetail = new ReceiveDetail();

            foreach (DataGridViewRow row in gvReceiveDetail.Rows)
            {
                recDetail.ReceiveId = ReceiveEntity.Id;
                recDetail.MaterialCode = row.Cells["MaterialCode"].Value.ToString();
                recDetail.OrderQuantity = Decimal.Parse(row.Cells["OrderQuantity"].Value.ToString());
                recDetail.ChallanQuantity = Decimal.Parse(row.Cells["ChallanQuantity"].Value.ToString());
                recDetail.ReceivedQuantity = Decimal.Parse(row.Cells["ReceivedQuantity"].Value.ToString());
                recDetail.DetailQuantity = Decimal.Parse(row.Cells["DetailQuantity"].Value.ToString());
                recDetail.UnitPrice = Decimal.Parse(row.Cells["UnitPrice"].Value.ToString());
                recDetail.VatPercent = Decimal.Parse(row.Cells["VatPercent"].Value.ToString());
                recDetail.VatAmount = Decimal.Parse(row.Cells["VatAmount"].Value.ToString());
                recDetail.BatchNo = row.Cells["BatchNo"].Value.ToString();
                recDetail.ManufacturerId = row.Cells["ManufacturerId"].Value.ToString();
                recDetail.ManufacturerLotNo = row.Cells["ManufacturerLotNo"].Value.ToString();
                recDetail.LotQuantity = Decimal.Parse(row.Cells["LotQuantity"].Value.ToString());
                recDetail.NoOfPack = Int32.Parse(row.Cells["NoOfPack"].Value.ToString());

                _ReceiveDetailContext.Create(recDetail);

            }

            //if (txtTransactionRefNo.Text == String.Empty)
            //{
            //    foreach (DataGridViewRow row in gvReceiveDetail.Rows)
            //    {
            //        recDetail.ReceiveId = ReceiveEntity.Id;
            //        recDetail.MaterialCode = row.Cells["MaterialCode"].Value.ToString();
            //        recDetail.OrderQuantity = Decimal.Parse(row.Cells["OrderQuantity"].Value.ToString());
            //        recDetail.ChallanQuantity = Decimal.Parse(row.Cells["ChallanQuantity"].Value.ToString());
            //        recDetail.ReceivedQuantity = Decimal.Parse(row.Cells["ReceivedQuantity"].Value.ToString());
            //        recDetail.DetailQuantity = Decimal.Parse(row.Cells["DetailQuantity"].Value.ToString());
            //        recDetail.UnitPrice = Decimal.Parse(row.Cells["UnitPrice"].Value.ToString());
            //        recDetail.VatPercent = Decimal.Parse(row.Cells["VatPercent"].Value.ToString());
            //        recDetail.VatAmount = Decimal.Parse(row.Cells["VatAmount"].Value.ToString());
            //        recDetail.BatchNo = row.Cells["BatchNo"].Value.ToString();
            //        recDetail.ManufacturerId = row.Cells["ManufacturerId"].Value.ToString();
            //        recDetail.ManufacturerLotNo = row.Cells["ManufacturerLotNo"].Value.ToString();
            //        recDetail.LotQuantity = Decimal.Parse(row.Cells["LotQuantity"].Value.ToString());
            //        recDetail.NoOfPack = Int32.Parse(row.Cells["NoOfPack"].Value.ToString());

            //        _ReceiveDetailContext.Create(recDetail);

            //    }
            //}
            //else
            //{
            //    foreach (DataGridViewRow row in gvReceiveDetail.Rows)
            //    {
            //        recDetail.Id = Int32.Parse(row.Cells["Id"].Value.ToString());
            //        recDetail.ReceiveId = ReceiveEntity.Id;
            //        recDetail.MaterialCode = row.Cells["MaterialCode"].Value.ToString();
            //        recDetail.OrderQuantity = Decimal.Parse(row.Cells["OrderQuantity"].Value.ToString());
            //        recDetail.ChallanQuantity = Decimal.Parse(row.Cells["ChallanQuantity"].Value.ToString());
            //        recDetail.ReceivedQuantity = Decimal.Parse(row.Cells["ReceivedQuantity"].Value.ToString());
            //        recDetail.DetailQuantity = Decimal.Parse(row.Cells["DetailQuantity"].Value.ToString());
            //        recDetail.UnitPrice = Decimal.Parse(row.Cells["UnitPrice"].Value.ToString());
            //        recDetail.VatPercent = Decimal.Parse(row.Cells["VatPercent"].Value.ToString());
            //        recDetail.VatAmount = Decimal.Parse(row.Cells["VatAmount"].Value.ToString());
            //        recDetail.BatchNo = row.Cells["BatchNo"].Value.ToString();
            //        recDetail.ManufacturerId = row.Cells["ManufacturerId"].Value.ToString();
            //        recDetail.ManufacturerLotNo = row.Cells["ManufacturerLotNo"].Value.ToString();
            //        recDetail.LotQuantity = Decimal.Parse(row.Cells["LotQuantity"].Value.ToString());
            //        recDetail.NoOfPack = Int32.Parse(row.Cells["NoOfPack"].Value.ToString());

            //        _ReceiveDetailContext.Update(recDetail);

            //    }
            //}


        }
    }
}
