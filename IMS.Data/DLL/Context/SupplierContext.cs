using IMS.Data.Model;
using IMS.Service.DLL.IContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace IMS.Data.DLL.Context
{
    public class SupplierContext : IDisposable, ISupplierContext
    {
        private readonly InventoryEntities context;
        private bool disposed;

        public SupplierContext()
        {
            context = new InventoryEntities();
        }

        public bool CreateSupplier(Supplier supplier)
        {
            try
            {
                context.Suppliers.Add(supplier);
                context.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool EditSupplier(Supplier supplier)
        {
            try
            {
                context.Entry(supplier).State = EntityState.Modified;
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteSupplier(Supplier supplier)
        {
            try
            {
                Supplier _supplier = context.Suppliers.Find(supplier.Id);
                context.Suppliers.Remove(_supplier);
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Supplier GetSupplierById(int SupplierId)
        {
          
           return context.Suppliers.Find(SupplierId);
               
        }

        public ICollection<Supplier> GetAllSupplier(int SupplierId)
        {
            return context.Suppliers.ToList();
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
