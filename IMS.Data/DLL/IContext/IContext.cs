using IMS.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Data.DLL.IContext
{
    public interface IContext<T> where T : class
    {
        T Create(T entity);

        T Update(T entity);

        bool Delete(T entity);

        ICollection<T> GetAllEntity();

        T GetEntityById(int EntityId);


    }
}
