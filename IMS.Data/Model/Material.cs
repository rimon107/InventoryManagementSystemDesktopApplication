//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMS.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Material
    {
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public int SubCategoryId { get; set; }
        public string Unit { get; set; }
        public decimal MaxStockQty { get; set; }
        public decimal ReOrderLevel { get; set; }
        public string HSCode { get; set; }
        public string LeadTimeID { get; set; }
        public string BusiCode { get; set; }
        public string SubBusiCode { get; set; }
        public string IsActive { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string EditBy { get; set; }
        public Nullable<System.DateTime> EditeDate { get; set; }
        public string PlantCode { get; set; }
        public string PartNo { get; set; }
    
        public virtual MaterialSubCategory MaterialSubCategory { get; set; }
    }
}