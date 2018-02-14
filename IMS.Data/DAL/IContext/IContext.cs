using System.Collections.Generic;

namespace IMS.Data.DAL.IContext
{
    public interface IContext<T> where T : class
    {
        T Create(T entity);

        T Update(T entity);

        bool Delete(T entity);

        IList<T> GetAll();

        T GetById(int EntityId);


    }
}
