using System.Collections.Generic;
using IMS.Data.Model;

namespace IMS.Service.DLL.IContext
{
    public interface ISupplierContext
    {
        bool CreateSupplier(Supplier supplier);
        bool DeleteSupplier(Supplier supplier);
        bool EditSupplier(Supplier supplier);
        ICollection<Supplier> GetAllSupplier(int SupplierId);
        Supplier GetSupplierById(int SupplierId);
    }
}