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
    
    public partial class TransactionSource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransactionSource()
        {
            this.Receives = new HashSet<Receive>();
        }
    
        public int Id { get; set; }
        public string TransactionSource1 { get; set; }
        public string ShortName { get; set; }
        public string TransactionType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receive> Receives { get; set; }
    }
}
