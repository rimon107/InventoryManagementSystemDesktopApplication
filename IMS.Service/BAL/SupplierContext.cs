using IMS.Data.Model;
using IMS.Service.DLL.IContext;
using IMS.Data.DLL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Library;

namespace IMS.Service.BAL
{
    public class SupplierContext
    {
        //private SupplierContext context;
        private readonly ISupplierContext context;
        private Supplier _supplier = new Supplier();

        public SupplierContext(ISupplierContext context)
        {
            this.context = context;
        }

        //public SupplierContext()
        //{
            
        //}

        public Supplier supplier
        {
            get
            {
                return _supplier;
            }
        }

        public bool CreateSupplier(string SupplierName, string SupplierAddress)
        {
            Supplier supplier = new Supplier();
            supplier.SupplierName = SupplierName;
            supplier.SupplierAddress = SupplierAddress;

            if (ModelState.IsValid<Supplier>(supplier))
            {
                return context.CreateSupplier(supplier);
            }
            else
            {

                return false;
            }
            
            

        }

        public bool UpdateSupplier(int SupplierId,string SupplierName, string SupplierAddress)
        {
            Supplier supplier = context.GetSupplierById(SupplierId);

            supplier.SupplierName = SupplierName;
            supplier.SupplierAddress = SupplierAddress;

            if (ModelState.IsValid<Supplier>(supplier))
            {
                return context.UpdateSupplier(supplier);
            }
            else
            {
                return false;
            }



        }

        public bool DeleteSupplier(int SupplierId)
        {
            Supplier supplier = context.GetSupplierById(SupplierId);
            
            if (supplier != null && supplier.Id != 0)
            {
                return context.DeleteSupplier(supplier);
            }
            else
            {
                return false;
            }



        }

        public ICollection<Supplier> GetAllSupplier()
        {
            return context.GetAllSupplier();
        }

 
    }
}
