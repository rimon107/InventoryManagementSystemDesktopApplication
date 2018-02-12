using Common.Library;
using IMS.Data.DLL.IContext;
using IMS.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IMS.Service.BAL
{
    public class GenericContext<T> where T : class
    {
        private readonly IContext<T> context;
        private T entity;
       
        public GenericContext(IContext<T> context)
        {
            EntityList = new BindingList<T>();
            this.context = context;
        }

        public ICollection<T> EntityList
        {
            get;
            private set;
        }

       public T Entity
        {
            get
            {
                return entity;
            }
            set
            {
                entity = value;
            }
        }

        //public T Create(T Entity)
        //{


        //    if (ModelState.IsValid<T>(Entity))
        //    {
        //        var entity = context.Create(Entity);

        //        return entity;
        //    }
        //    else
        //    {

        //        return null;
        //    }



        //}

        public T Create()
        {
            if (ModelState.IsValid<T>(Entity))
            {
                var entity = context.Create(Entity);

                SetEntityList();

                return entity;
            }
            else
            {

                return null;
            }
            
        }

        public bool Update()
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

        //public bool Update(T Entity)
        //{

        //    if (ModelState.IsValid<T>(Entity))
        //    {
        //        var supp = context.Update(Entity);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }



        //}

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

        public ICollection<T> GetAllEntity()
        {
            return context.GetAllEntity();
        }

        public T GetEntityById(int EntityId)
        {
            return context.GetEntityById(EntityId);
        }

        public void SetEntityList()
        {
            EntityList.Clear();
            Entity = null;

            var Elist = GetAllEntity();
            foreach (var entity in Elist)
                EntityList.Add(entity);
        }
    }
}
