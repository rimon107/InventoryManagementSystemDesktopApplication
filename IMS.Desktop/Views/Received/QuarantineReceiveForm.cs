using Common.Library;
using CommonServiceLocator;
using IMS.Data.DAL.Context;
using IMS.Data.DAL.IContext;
using IMS.Data.Model;
using IMS.Desktop.Views.Common;
using IMS.Service.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            
            _PlantContext = ServiceLocator.Current.GetInstance<GenericContext<PlantInfo>>();
            _ReceiveContext = ServiceLocator.Current.GetInstance<GenericContext<Receive>>();
            _ReceiveDetailContext = ServiceLocator.Current.GetInstance<GenericContext<ReceiveDetail>>();

            LoadData();
        }

        private void LoadData()
        {
            cmbPlantInfo.DataSource = _PlantContext.GetAll();
            cmbPlantInfo.ValueMember = "PlantID";
            cmbPlantInfo.DisplayMember = "PlantName";

            DataGridViewButtonColumn columnDel = new DataGridViewButtonColumn();
            columnDel.Name = "Delete";
            columnDel.HeaderText = "Delete";
            columnDel.Text = "Del";
            columnDel.UseColumnTextForButtonValue = true;

            //if (!gvReceiveDetail.Columns.Contains(columnDel))
            //{
                gvReceiveDetail.Columns.Insert(0, columnDel);
                gvReceiveDetail.AutoSize = true;
                gvReceiveDetail.AllowUserToAddRows = false;
                gvReceiveDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gvReceiveDetail.CellClick += new DataGridViewCellEventHandler(gvReceiveDetail_CellClick);
            //}

            var data = _ReceiveDetailContext.EntityList;
           
            if (data.Count == 0)
            {
                InitializeDefaultReceiveDetail();
            }
            else
            {
                var _data = CollectionHelper.ConvertTo(data);

                gvReceiveDetail.DataSource = _data;

                InitialzeReceiveDetail();

            }
            
        }

        private DataTable DataTableReceiveDetail()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(Int32));
            dt.Columns.Add("MaterialCode", typeof(String));
            dt.Columns.Add("MaterialName", typeof(String));
            dt.Columns.Add("MaterialUnit", typeof(String));
            dt.Columns.Add("OrderQuantity", typeof(Double));
            dt.Columns.Add("ChallanQuantity", typeof(Double));
            dt.Columns.Add("EarlierReceivedQuantity", typeof(Double));
            dt.Columns.Add("ReceivedQuantity", typeof(Double));
            dt.Columns.Add("DetailUnit", typeof(Double));
            dt.Columns.Add("DetailQuantity", typeof(Double));
            dt.Columns.Add("BatchNo", typeof(String));
            dt.Columns.Add("ManufacturerLotNo", typeof(String));
            dt.Columns.Add("LotQuantity", typeof(Double));
            dt.Columns.Add("NoOfPack", typeof(Int32));

            return dt;
        }

        private void SetDefaultReceiveDetail()
        {
            gvReceiveDetail.Columns["Id"].Visible = false;

            gvReceiveDetail.Columns["MaterialCode"].HeaderText = "Material Code";
            gvReceiveDetail.Columns["MaterialName"].HeaderText = "Material Name";
            gvReceiveDetail.Columns["MaterialUnit"].HeaderText = "Material Unit";

            gvReceiveDetail.Columns["OrderQuantity"].HeaderText = "Order Quantity";
            gvReceiveDetail.Columns["ChallanQuantity"].HeaderText = "Challan Quantity";
            gvReceiveDetail.Columns["ReceivedQuantity"].HeaderText = "Received Quantity";
            gvReceiveDetail.Columns["EarlierReceivedQuantity"].HeaderText = "Earlier Received Quantity";

            gvReceiveDetail.Columns["DetailUnit"].HeaderText = "Detail Unit";
            gvReceiveDetail.Columns["DetailQuantity"].HeaderText = "Detail Quantity";

            gvReceiveDetail.Columns["BatchNo"].HeaderText = "Batch No";

            gvReceiveDetail.Columns["ManufacturerLotNo"].HeaderText = "Manufacturer Lot No";
            gvReceiveDetail.Columns["LotQuantity"].HeaderText = "Lot Quantity";
            gvReceiveDetail.Columns["NoOfPack"].HeaderText = "No Of Pack";


            
        }

        private void InitializeDefaultReceiveDetail()
        {
            DataTable dt = DataTableReceiveDetail();

            gvReceiveDetail.DataSource = dt;
            
            SetDefaultReceiveDetail();
        }

        // If the user clicks on an enabled button cell, this event handler 
        // reports that the button is enabled.
        void gvReceiveDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvReceiveDetail.Columns[e.ColumnIndex].Name == "Delete")
            {
                gvReceiveDetail.AllowUserToAddRows = false;
                if (gvReceiveDetail.Rows.Count > 0)
                {
                    gvReceiveDetail.Rows.RemoveAt(e.RowIndex);
                }
                
            }

        }

        private void InitialzeReceiveDetail()
        {
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

        private void btnSupplierFind_Click(object sender, EventArgs e)
        {
            new SupplierSearchForm().ShowDialog();

            if (Entity<Supplier>.entity != null)
            {

                txtSupplierName.Text = Entity<Supplier>.entity.Name;
                txtSupplierAddress.Text = Entity<Supplier>.entity.Address;
                txtSupplierId.Text = Entity<Supplier>.entity.Id.ToString();

                Entity<Material>.entity = null;
            }


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

            _ReceiveContext.Entity = receive;
            var ReceiveEntity = _ReceiveContext.Create();


            foreach (DataGridViewRow row in gvReceiveDetail.Rows)
            {
                var recDetail = new ReceiveDetail();

                _ReceiveDetailContext.Entity = null;
                recDetail.Receive = null;
                recDetail.ReceiveId = ReceiveEntity.Id;
                recDetail.MaterialCode = row.Cells["MaterialCode"].Value.ToString();
                recDetail.OrderQuantity = Decimal.Parse(row.Cells["OrderQuantity"].Value.ToString());
                recDetail.ChallanQuantity = Decimal.Parse(row.Cells["ChallanQuantity"].Value.ToString());
                recDetail.ReceivedQuantity = Decimal.Parse(row.Cells["ReceivedQuantity"].Value.ToString());
                recDetail.DetailQuantity = Decimal.Parse(row.Cells["DetailQuantity"].Value.ToString());

                //recDetail.UnitPrice = Decimal.Parse(row.Cells["UnitPrice"].Value.ToString());
                //recDetail.VatPercent = Decimal.Parse(row.Cells["VatPercent"].Value.ToString());
                //recDetail.VatAmount = Decimal.Parse(row.Cells["VatAmount"].Value.ToString());

                recDetail.UnitPrice = 0;
                recDetail.VatPercent = 0;
                recDetail.VatAmount = 0;

                recDetail.BatchNo = row.Cells["BatchNo"].Value.ToString();

                //recDetail.ManufacturerId = row.Cells["ManufacturerId"].Value.ToString();

                recDetail.ManufacturerId = "1" ;

                recDetail.ManufacturerLotNo = row.Cells["ManufacturerLotNo"].Value.ToString();
                recDetail.LotQuantity = Decimal.Parse(row.Cells["LotQuantity"].Value.ToString());
                recDetail.NoOfPack = Int32.Parse(row.Cells["NoOfPack"].Value.ToString());

                _ReceiveDetailContext.Entity = recDetail;
                _ReceiveDetailContext.Create();

            }

            MessageBox.Show("Success");

            ClearForm();



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

        private void ClearForm()
        {
            gvReceiveDetail.DataSource = null;
            gvReceiveDetail.Rows.Clear();


            txtTransactionRefNo.Text = String.Empty;

            txtSupplierName.Text = String.Empty;
            txtGRN.Text = String.Empty;

            txtChallan.Text = String.Empty;

            txtVATChallan.Text = String.Empty;

            txtReceiveText.Text = String.Empty;


        }

        private void AddNewMaterial()
        {

            if (Entity<Material>.check)
            {
                if (Entity<Material>.entity == null)
                {
                    MessageBox.Show("Select Material Code");
                }
                else
                {
                    var MatCode = Entity<Material>.entity.MaterialCode;
                    var MatName = Entity<Material>.entity.MaterialName;
                    var MatUnit = Entity<Material>.entity.Unit;

                    Entity<Material>.entity = null;
                    bool flag = false;

                    int index;

                    try
                    {
                        index = gvReceiveDetail.Rows.Count;
                    }
                    catch
                    {
                        index = 0;
                    }

                    if (index > 0)
                    {


                        if (gvReceiveDetail.Rows[index - 1].Cells["MaterialCode"].Value == null ||
                            String.IsNullOrWhiteSpace(gvReceiveDetail.Rows[index - 1].Cells["MaterialCode"].Value.ToString())
                            )
                        {
                            InitializeDefaultReceiveDetail();
                            gvReceiveDetail.AllowUserToAddRows = true;

                            gvReceiveDetail.Rows[0].Cells["MaterialCode"].Value = MatCode;
                            gvReceiveDetail.Rows[0].Cells["MaterialName"].Value = MatName;
                            gvReceiveDetail.Rows[0].Cells["MaterialUnit"].Value = MatUnit;
                        }

                        else
                        {
                            DataTable dt = DataTableReceiveDetail();
                            foreach (DataGridViewRow row in gvReceiveDetail.Rows)
                            {
                                if (row.Cells["MaterialCode"].Value.ToString() == MatCode)
                                {
                                    flag = true;
                                    break;
                                }

                                #region Using DataTable

                                DataRow dr = dt.NewRow();

                                dr["MaterialCode"] = row.Cells["MaterialCode"].Value.ToString();
                                dr["MaterialName"] = row.Cells["MaterialName"].Value.ToString();
                                dr["MaterialUnit"] = row.Cells["MaterialUnit"].Value.ToString();
                                //dr[3] = row.Cells["OrderQuantity"].Value.ToString();
                                //dr[4] = row.Cells["ChallanQuantity"].Value.ToString();
                                //dr[5] = row.Cells["EarlierReceivedQuantity"].Value.ToString();
                                //dr[6] = row.Cells["ReceivedQuantity"].Value.ToString();
                                //dr[7] = row.Cells["DetailUnit"].Value.ToString();
                                //dr[8] = row.Cells["DetailQuantity"].Value.ToString();
                                //dr[9] = row.Cells["BatchNo"].Value.ToString();
                                //dr[10] = row.Cells["ManufacturerLotNo"].Value.ToString();
                                //dr[11] = row.Cells["LotQuantity"].Value.ToString();
                                //dr[12] = row.Cells["NoOfPack"].Value.ToString();

                                dt.Rows.Add(dr);
                                #endregion

                            }

                            if (!flag)
                            {
                                DataRow drn = dt.NewRow();

                                drn["MaterialCode"] = MatCode;
                                drn["MaterialName"] = MatName;
                                drn["MaterialUnit"] = MatUnit;
                                //dr[3] = row.Cells["OrderQuantity"].Value.ToString();
                                //dr[4] = row.Cells["ChallanQuantity"].Value.ToString();
                                //dr[5] = row.Cells["EarlierReceivedQuantity"].Value.ToString();
                                //dr[6] = row.Cells["ReceivedQuantity"].Value.ToString();
                                //dr[7] = row.Cells["DetailUnit"].Value.ToString();
                                //dr[8] = row.Cells["DetailQuantity"].Value.ToString();
                                //dr[9] = row.Cells["BatchNo"].Value.ToString();
                                //dr[10] = row.Cells["ManufacturerLotNo"].Value.ToString();
                                //dr[11] = row.Cells["LotQuantity"].Value.ToString();
                                //dr[12] = row.Cells["NoOfPack"].Value.ToString();

                                dt.Rows.Add(drn);

                                gvReceiveDetail.DataSource = dt;
                                gvReceiveDetail.AllowUserToAddRows = false;
                            }
                        }


                        #region prev
                        //if (int.Parse(gvReceiveDetail.Rows[index - 1].Cells["Id"].Value.ToString()) != 0)
                        //{
                        //    var data = _ReceiveDetailContext.EntityList;

                        //    var recDetail = new ReceiveDetail();
                        //    recDetail.MaterialCode = MatCode;

                        //    data.Add(recDetail);
                        //    gvReceiveDetail.DataSource = null;
                        //    gvReceiveDetail.DataSource = data;
                        //    //gvReceiveDetail.Refresh();
                        //}
                        //else
                        //{
                        //    if (gvReceiveDetail.Rows[index - 1].Cells["MaterialCode"].Value != null)
                        //    {
                        //        if (!String.IsNullOrWhiteSpace(gvReceiveDetail.Rows[index - 1].Cells["MaterialCode"].Value.ToString()))
                        //        {
                        //            var DataList = new BindingList<ReceiveDetail>();

                        //            DataTable dt = DataTableReceiveDetail();
                        //            foreach (DataGridViewRow row in gvReceiveDetail.Rows)
                        //            {

                        //                #region using model
                        //                //var recDetail = new ReceiveDetail();
                        //                //recDetail.Receive = null;

                        //                //recDetail.MaterialCode = row.Cells["MaterialCode"].Value.ToString();
                        //                //try
                        //                //{
                        //                //    recDetail.OrderQuantity = Decimal.Parse(row.Cells["OrderQuantity"].Value.ToString());
                        //                //}
                        //                //catch
                        //                //{
                        //                //    recDetail.OrderQuantity = 0;
                        //                //}
                        //                //try
                        //                //{
                        //                //    recDetail.ChallanQuantity = Decimal.Parse(row.Cells["ChallanQuantity"].Value.ToString());
                        //                //}
                        //                //catch
                        //                //{
                        //                //    recDetail.ChallanQuantity = 0;
                        //                //}
                        //                //try
                        //                //{
                        //                //    recDetail.ReceivedQuantity = Decimal.Parse(row.Cells["ReceivedQuantity"].Value.ToString());
                        //                //}
                        //                //catch
                        //                //{
                        //                //    recDetail.ReceivedQuantity = 0;
                        //                //}
                        //                //try
                        //                //{
                        //                //    recDetail.DetailQuantity = Decimal.Parse(row.Cells["DetailQuantity"].Value.ToString());
                        //                //}
                        //                //catch
                        //                //{
                        //                //    recDetail.DetailQuantity = 0;
                        //                //}
                        //                //try
                        //                //{
                        //                //    recDetail.UnitPrice = Decimal.Parse(row.Cells["UnitPrice"].Value.ToString());
                        //                //}
                        //                //catch
                        //                //{
                        //                //    recDetail.UnitPrice = 0;
                        //                //}
                        //                //try
                        //                //{
                        //                //    recDetail.VatPercent = Decimal.Parse(row.Cells["VatPercent"].Value.ToString());
                        //                //}
                        //                //catch
                        //                //{
                        //                //    recDetail.VatPercent = 0;
                        //                //}
                        //                //try
                        //                //{
                        //                //    recDetail.VatAmount = Decimal.Parse(row.Cells["VatAmount"].Value.ToString());
                        //                //}
                        //                //catch
                        //                //{
                        //                //    recDetail.VatAmount = 0;
                        //                //}
                        //                //try
                        //                //{
                        //                //    recDetail.BatchNo = row.Cells["BatchNo"].Value.ToString();
                        //                //}
                        //                //catch
                        //                //{
                        //                //    recDetail.BatchNo = String.Empty;
                        //                //}
                        //                //try
                        //                //{
                        //                //    recDetail.ManufacturerId = row.Cells["ManufacturerId"].Value.ToString();
                        //                //}
                        //                //catch
                        //                //{
                        //                //    recDetail.ManufacturerId = String.Empty;
                        //                //}
                        //                //try
                        //                //{
                        //                //    recDetail.ManufacturerLotNo = row.Cells["ManufacturerLotNo"].Value.ToString();
                        //                //}
                        //                //catch
                        //                //{
                        //                //    recDetail.ManufacturerLotNo = String.Empty;
                        //                //}
                        //                //try
                        //                //{
                        //                //    recDetail.LotQuantity = Decimal.Parse(row.Cells["LotQuantity"].Value.ToString());
                        //                //}
                        //                //catch
                        //                //{
                        //                //    recDetail.LotQuantity = 0;
                        //                //}
                        //                //try
                        //                //{
                        //                //    recDetail.NoOfPack = Int32.Parse(row.Cells["NoOfPack"].Value.ToString());
                        //                //}
                        //                //catch
                        //                //{
                        //                //    recDetail.NoOfPack = 0;
                        //                //}

                        //                //DataList.Add(recDetail);

                        //                #endregion

                        //                #region Using DataTable

                        //                DataRow dr = dt.NewRow();

                        //                dr[0] = row.Cells["MaterialCode"].Value.ToString();
                        //                dr[1] = row.Cells["MaterialName"].Value.ToString();
                        //                dr[2] = row.Cells["MaterialUnit"].Value.ToString();
                        //                dr[3] = row.Cells["OrderQuantity"].Value.ToString();
                        //                dr[4] = row.Cells["ChallanQuantity"].Value.ToString();
                        //                dr[5] = row.Cells["EarlierReceivedQuantity"].Value.ToString();
                        //                dr[6] = row.Cells["ReceivedQuantity"].Value.ToString();
                        //                dr[7] = row.Cells["DetailUnit"].Value.ToString();
                        //                dr[8] = row.Cells["DetailQuantity"].Value.ToString();
                        //                dr[9] = row.Cells["BatchNo"].Value.ToString();
                        //                dr[10] = row.Cells["ManufacturerLotNo"].Value.ToString();
                        //                dr[11] = row.Cells["LotQuantity"].Value.ToString();
                        //                dr[12] = row.Cells["NoOfPack"].Value.ToString();

                        //                dt.Rows.Add(dr);
                        //                #endregion

                        //            }

                        //            DataRow drn = dt.NewRow();

                        //            dt.Rows.Add(drn);

                        //            //var newRecDetail = new ReceiveDetail();

                        //            //newRecDetail.MaterialCode = MatCode;

                        //            //DataList.Add(newRecDetail);
                        //            //gvReceiveDetail.DataSource = null;
                        //            //gvReceiveDetail.DataSource = DataList;

                        //            //gvReceiveDetail.Columns["Id"].Visible = false;
                        //            //gvReceiveDetail.Columns["ReceiveId"].Visible = false;
                        //            //gvReceiveDetail.Columns["IsQCReleased"].Visible = false;
                        //            //gvReceiveDetail.Columns["RestrictedQuantity"].Visible = false;
                        //            //gvReceiveDetail.Columns["Receive"].Visible = false;
                        //        }
                        //    }
                        //    else
                        //    {
                        //        BindingList<ReceiveDetail> clientDataSource;
                        //        clientDataSource = new BindingList<ReceiveDetail>() { AllowNew = true };
                        //        var newRecDetail = new ReceiveDetail();

                        //        newRecDetail.MaterialCode = MatCode;

                        //        clientDataSource.Add(newRecDetail);
                        //        var source = new BindingSource(clientDataSource, null);
                        //        gvReceiveDetail.DataSource = clientDataSource;
                        //        gvReceiveDetail.AllowUserToAddRows = false;
                        //    }
                        //}
                        #endregion
                    }
                    else
                    {
                        InitializeDefaultReceiveDetail();
                        gvReceiveDetail.AllowUserToAddRows = true;

                        gvReceiveDetail.Rows[0].Cells["MaterialCode"].Value = MatCode;
                        gvReceiveDetail.Rows[0].Cells["MaterialName"].Value = MatName;
                        gvReceiveDetail.Rows[0].Cells["MaterialUnit"].Value = MatUnit;

                        DataGridViewButtonColumn columnDel = new DataGridViewButtonColumn();
                        columnDel.Name = "Delete";
                        columnDel.Text = "Del";
                        columnDel.UseColumnTextForButtonValue = true;

                        if (!gvReceiveDetail.Columns.Contains(columnDel))
                        {
                            gvReceiveDetail.Columns.Insert(0, columnDel);
                            gvReceiveDetail.AutoSize = true;
                            //gvReceiveDetail.AllowUserToAddRows = false;
                            gvReceiveDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            gvReceiveDetail.CellClick += new DataGridViewCellEventHandler(gvReceiveDetail_CellClick);
                        }
                    }
                }

            }



        }

        private void AddMaterial(Material material)
        {
            var MatCode = material.MaterialCode;
            var MatName = material.MaterialName;
            var MatUnit = material.Unit;
            
            bool flag = false;

            int index;

            try
            {
                index = gvReceiveDetail.Rows.Count;
            }
            catch
            {
                index = 0;
            }

            if (index > 0)
            {


                if (gvReceiveDetail.Rows[index - 1].Cells["MaterialCode"].Value == null ||
                    String.IsNullOrWhiteSpace(gvReceiveDetail.Rows[index - 1].Cells["MaterialCode"].Value.ToString())
                    )
                {
                    InitializeDefaultReceiveDetail();
                    gvReceiveDetail.AllowUserToAddRows = true;

                    gvReceiveDetail.Rows[0].Cells["MaterialCode"].Value = MatCode;
                    gvReceiveDetail.Rows[0].Cells["MaterialName"].Value = MatName;
                    gvReceiveDetail.Rows[0].Cells["MaterialUnit"].Value = MatUnit;
                }

                else
                {
                    DataTable dt = DataTableReceiveDetail();
                    foreach (DataGridViewRow row in gvReceiveDetail.Rows)
                    {
                        if (row.Cells["MaterialCode"].Value.ToString() == MatCode)
                        {
                            flag = true;
                            break;
                        }

                        #region Using DataTable

                        DataRow dr = dt.NewRow();

                        dr["MaterialCode"] = row.Cells["MaterialCode"].Value.ToString();
                        dr["MaterialName"] = row.Cells["MaterialName"].Value.ToString();
                        dr["MaterialUnit"] = row.Cells["MaterialUnit"].Value.ToString();
                        //dr[3] = row.Cells["OrderQuantity"].Value.ToString();
                        //dr[4] = row.Cells["ChallanQuantity"].Value.ToString();
                        //dr[5] = row.Cells["EarlierReceivedQuantity"].Value.ToString();
                        //dr[6] = row.Cells["ReceivedQuantity"].Value.ToString();
                        //dr[7] = row.Cells["DetailUnit"].Value.ToString();
                        //dr[8] = row.Cells["DetailQuantity"].Value.ToString();
                        //dr[9] = row.Cells["BatchNo"].Value.ToString();
                        //dr[10] = row.Cells["ManufacturerLotNo"].Value.ToString();
                        //dr[11] = row.Cells["LotQuantity"].Value.ToString();
                        //dr[12] = row.Cells["NoOfPack"].Value.ToString();

                        dt.Rows.Add(dr);
                        #endregion

                    }

                    if (!flag)
                    {
                        DataRow drn = dt.NewRow();

                        drn["MaterialCode"] = MatCode;
                        drn["MaterialName"] = MatName;
                        drn["MaterialUnit"] = MatUnit;
                        //dr[3] = row.Cells["OrderQuantity"].Value.ToString();
                        //dr[4] = row.Cells["ChallanQuantity"].Value.ToString();
                        //dr[5] = row.Cells["EarlierReceivedQuantity"].Value.ToString();
                        //dr[6] = row.Cells["ReceivedQuantity"].Value.ToString();
                        //dr[7] = row.Cells["DetailUnit"].Value.ToString();
                        //dr[8] = row.Cells["DetailQuantity"].Value.ToString();
                        //dr[9] = row.Cells["BatchNo"].Value.ToString();
                        //dr[10] = row.Cells["ManufacturerLotNo"].Value.ToString();
                        //dr[11] = row.Cells["LotQuantity"].Value.ToString();
                        //dr[12] = row.Cells["NoOfPack"].Value.ToString();

                        dt.Rows.Add(drn);

                        gvReceiveDetail.DataSource = dt;
                        gvReceiveDetail.AllowUserToAddRows = false;
                    }
                }

            }
            else
            {
                InitializeDefaultReceiveDetail();
                gvReceiveDetail.AllowUserToAddRows = true;

                gvReceiveDetail.Rows[0].Cells["MaterialCode"].Value = MatCode;
                gvReceiveDetail.Rows[0].Cells["MaterialName"].Value = MatName;
                gvReceiveDetail.Rows[0].Cells["MaterialUnit"].Value = MatUnit;
                gvReceiveDetail.Rows[0].Cells["Delete"].Value = "Del";

                //DataGridViewButtonColumn columnDel = new DataGridViewButtonColumn();
                //columnDel.Name = "Delete";
                //columnDel.Text = "Del";
                //columnDel.UseColumnTextForButtonValue = true;

                //if (!gvReceiveDetail.Columns.Contains(columnDel))
                //{
                //    gvReceiveDetail.Columns.Insert(0, columnDel);
                //    gvReceiveDetail.AutoSize = true;
                //    //gvReceiveDetail.AllowUserToAddRows = false;
                //    gvReceiveDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //    gvReceiveDetail.CellClick += new DataGridViewCellEventHandler(gvReceiveDetail_CellClick);
                //}
            }
           
        }

        private void btnAddNewRow_Click(object sender, EventArgs e)
        {
            var MatForm = new MaterialSearchForm();

            MatForm.btnAddMaterial += (senderMatForm, eMatForm) => AddMaterial(eMatForm.Entity);

            MatForm.ShowDialog();

            //AddNewMaterial();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            //gvReceiveDetail.DataSource = null;
            //gvReceiveDetail.Rows.Clear();
            if (gvReceiveDetail.Rows.Count > 0)
            {
                gvReceiveDetail.DataSource = null;
                InitializeDefaultReceiveDetail();
            }
            
        }
    }
}
