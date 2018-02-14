using System.Collections.Generic;
using IMS.Data.Model;

namespace IMS.Service.DAL.IContext
{
    public interface ISupplierContext
    {
        bool CreateSupplier(Supplier supplier);
        bool DeleteSupplier(Supplier supplier);
        bool UpdateSupplier(Supplier supplier);
        ICollection<Supplier> GetAllSupplier();
        Supplier GetSupplierById(int SupplierId);
    }
}