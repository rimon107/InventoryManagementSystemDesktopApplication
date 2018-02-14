using Common.Library;
using IMS.Data.DAL.IContext;
using System.Collections.Generic;
using System.ComponentModel;

namespace IMS.Service.BLL
{
    public class GenericContext<T> where T : class
    {
        private readonly IContext<T> context;
        private T entity;
       
        public GenericContext(IContext<T> context)
        {
            EntityList = new List<T>();
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
            T entity = context.GetById(EntityId);

            if (entity != null)
            {
                
                return context.Delete(entity);

            }
            else
            {
                return false;
            }



        }

        public ICollection<T> GetAll()
        {
            return context.GetAll();
        }

        public T GetById(int EntityId)
        {
            return context.GetById(EntityId);
        }

        public void SetEntityList()
        {
            EntityList.Clear();
            Entity = null;

            var Elist = GetAll();
            foreach (var entity in Elist)
                EntityList.Add(entity);
        }
    }
}
