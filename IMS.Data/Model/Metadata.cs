using System;
using System.ComponentModel.DataAnnotations;

namespace IMS.Data.Model
{
    public class ReceiveMetadata
    {
        [Display(Name = "Transaction Source")]
        public Nullable<int> TransactionSourceId;

        [StringLength(50)]
        [Display(Name = "Transaction Ref #")]
        public string TransactionReferenceNo;

        [Display(Name = "Invoice Date")]
        [DataType(DataType.Date)]
        public System.DateTime InvoiceDate;

        [Display(Name = "Material Type")]
        public Nullable<int> MaterialTypeId;

        [Display(Name = "Supplier")]
        public int SupplierId;

        [StringLength(50)]
        [Display(Name = "GRN No")]
        public string GRNNo;

        [Display(Name = "GRN Date")]
        public System.DateTime GRNDate;

        [StringLength(50)]
        [Display(Name = "Challan No")]
        public string ChallanNo;

        [Display(Name = "Challan Date")]
        public System.DateTime ChallanDate;

        [StringLength(200)]
        [Display(Name = "Comments")]
        public string Comments;

        [Display(Name = "Invoice Quantity")]
        public int InvoiceQuantity;

        [Display(Name = "Receive Quantity")]
        public int ReceivedQuantity;

        [Display(Name = "Damaged Quantity")]
        public Nullable<int> DamagedQuantity;

        [Display(Name = "OutStanding Quantity")]
        public Nullable<int> OutStandingQuantity;

        [Display(Name = "Shortage Quantity")]
        public Nullable<int> ShortageQuantity;

        [Display(Name = "Batch No")]
        public string BatchNo;

        [Display(Name = "Manufacturer")]
        public Nullable<int> ManufacturerId;

        [StringLength(50)]
        [Display(Name = "Manufacturer Lot No")]
        public string ManufacturerLotNo;

        [Display(Name = "Lot Quantity")]
        public Nullable<int> LotQuantity;

        [Display(Name = "No Of Pack")]
        public Nullable<int> NoOfPack;

        [Display(Name = "VAT Amount")]
        public Nullable<int> VAT;

        [StringLength(50)]
        [Display(Name = "BOE / VAT Challan No")]
        public string VATChallanNo;

        [Display(Name = "BOE / VAT Challan Date")]
        public Nullable<System.DateTime> VATChallanDate;
    }

    public class SupplierMetadata
    {

        [StringLength(50)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Suplier Name Required")]
        [Display(Name = "Suplier Name")]
        public string SupplierName { get; set; }

        [StringLength(50)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Suplier Address Required")]
        [Display(Name = "Suplier Address")]
        public string SupplierAddress { get; set; }
    }
}
