using IMS.Data.Model;
using IMS.Service.DAL.IContext;
using System;
using System.Collections.Generic;


namespace IMS.Service.BLL
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
            //Supplier supplier = new Supplier();
            //supplier.SupplierName = SupplierName;
            //supplier.SupplierAddress = SupplierAddress;

            //if (ModelState.IsValid<Supplier>(supplier))
            //{
            //    return context.CreateSupplier(supplier);
            //}
            //else
            //{

            //    return false;
            //}
            throw new NotImplementedException();



        }

        public bool UpdateSupplier(int SupplierId,string SupplierName, string SupplierAddress)
        {
            //Supplier supplier = context.GetSupplierById(SupplierId);

            //supplier.SupplierName = SupplierName;
            //supplier.SupplierAddress = SupplierAddress;

            //if (ModelState.IsValid<Supplier>(supplier))
            //{
            //    return context.UpdateSupplier(supplier);
            //}
            //else
            //{
            //    return false;
            //}

            throw new NotImplementedException();



        }

        public bool DeleteSupplier(int SupplierId)
        {
            //Supplier supplier = context.GetSupplierById(SupplierId);

            //if (supplier != null && supplier.Id != 0)
            //{
            //    return context.DeleteSupplier(supplier);
            //}
            //else
            //{
            //    return false;
            //}

            throw new NotImplementedException();



        }

        public ICollection<Supplier> GetAllSupplier()
        {
            //return context.GetAllSupplier();

            throw new NotImplementedException();
        }

 
    }
}
