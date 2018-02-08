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
    public class GenericContext<T> where T : class
    {
        private readonly IContext<T> context;
       
        public GenericContext(IContext<T> context)
        {
            this.context = context;
        }

        //public SupplierContext()
        //{

        //}

       

        public T Create(T Entity)
        {
            

            if (ModelState.IsValid<T>(Entity))
            {
                var entity = context.Create(Entity);

                return entity;
            }
            else
            {

                return null;
            }



        }

        public bool Update(T Entity)
        {

            if (ModelState.IsValid<T>(Entity))
            {
                var supp = context.Update(Entity);
                return true;
            }
            else
            {
                return false;
            }



        }

        public bool Delete(int EntityId)
        {
            T entity = context.GetEntityById(EntityId);

            if (entity != null)
            {
                
                return context.Delete(entity);

            }
            else
            {
                return false;
            }



        }

        public IList<T> GetAllEntity()
        {
            return context.GetAllEntity();
        }

        public T GetEntityById(int EntityId)
        {
            return context.GetEntityById(EntityId);
        }
    }
}
