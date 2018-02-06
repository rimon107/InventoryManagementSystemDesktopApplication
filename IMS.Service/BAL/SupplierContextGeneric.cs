using Common.Library;
using IMS.Data.DLL.IContext;
using IMS.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Service.BAL
{
    public class SupplierContextGeneric
    {
        private readonly IContext<Supplier> context;
        private Supplier _supplier = new Supplier();

        public SupplierContextGeneric(IContext<Supplier> context)
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
                var sup =  context.Create(supplier);

                return true;
            }
            else
            {

                return false;
            }



        }

        public bool UpdateSupplier(int SupplierId, string SupplierName, string SupplierAddress)
        {
            Supplier supplier = context.GetEntityById(SupplierId);

            supplier.SupplierName = SupplierName;
            supplier.SupplierAddress = SupplierAddress;

            if (ModelState.IsValid<Supplier>(supplier))
            {
                var supp = context.Update(supplier);
                return true;
            }
            else
            {
                return false;
            }



        }

        public bool DeleteSupplier(int SupplierId)
        {
            Supplier supplier = context.GetEntityById(SupplierId);

            if (supplier != null && supplier.Id != 0)
            {
                var supp = context.Delete(supplier);

                return true;

            }
            else
            {
                return false;
            }



        }

        public ICollection<Supplier> GetAllSupplier()
        {
            return context.GetAllEntity();
        }

    }
}
