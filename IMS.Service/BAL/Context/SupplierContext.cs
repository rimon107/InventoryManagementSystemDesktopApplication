using IMS.Data.Model;
using IMS.Service.DLL.IContext;
using IMS.Data.DLL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Service.BAL.Context
{
    public class BalSupplierContext
    {
        private SupplierContext context;
        private Supplier _supplier = new Supplier();

        //public SupplierContext(ISupplierContext context)
        //{
        //    this.context = context;
        //}

        public BalSupplierContext()
        {
            context = new SupplierContext();
        }

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
            supplier.SuplierName = SupplierName;
            supplier.SuplierAddress = SupplierAddress;
            

            return context.CreateSupplier(supplier);
        }

 
    }
}
