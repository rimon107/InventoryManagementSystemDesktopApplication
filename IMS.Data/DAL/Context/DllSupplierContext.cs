using IMS.Data.Model;
using IMS.Service.DAL.IContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace IMS.Data.DAL.Context
{
    public class DllSupplierContext : IDisposable, ISupplierContext
    {
        private readonly InventoryEntities context;
        private bool disposed;

        public DllSupplierContext()
        {
            context = new InventoryEntities();
        }

        public bool CreateSupplier(Supplier supplier)
        {
            //try
            //{
            //    //var error = context.Entry(supplier).GetValidationResult();

            //    //context.Suppliers.Add(supplier);
            //    context.SaveChanges();

            //    return true;
            //}
            //catch(Exception ex)
            //{
            //    return false;
            //}
            throw new NotImplementedException();
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            //try
            //{
            //    context.Entry(supplier).State = EntityState.Modified;
            //    context.SaveChanges();

            //    return true;
            //}
            //catch
            //{
            //    return false;
            //}
            throw new NotImplementedException();
        }

        public bool DeleteSupplier(Supplier supplier)
        {
            //try
            //{
            //    //Supplier _supplier = context.Suppliers.Find(supplier.Id);
            //    //context.Suppliers.Remove(_supplier);
            //    context.SaveChanges();

            //    return true;
            //}
            //catch
            //{
            //    return false;
            //}
            throw new NotImplementedException();
        }

        public Supplier GetSupplierById(int SupplierId)
        {

            //return context.Suppliers.Find(SupplierId);
            throw new NotImplementedException();
               
        }

        public ICollection<Supplier> GetAllSupplier()
        {
            //return context.Suppliers.ToList();
            throw new NotImplementedException();
        }

        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposed || !disposing)
                return;

            if (context != null)
                //context.Dispose();

                disposed = true;
        }

        #endregion
    }
}
