using IMS.Data.DLL.IContext;
using IMS.Data.Model;
using IMS.Service.DLL.IContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace IMS.Data.DLL.Context
{
    public class Context<T> : IContext<T>  where T: class
    {
        //private readonly IDbContext _context;
        private readonly InventoryEntities context;
        private IDbSet<T> entities;

        public Context()
        {
            context = new InventoryEntities();
            entities = context.Set<T>();
        }
        

        public T Create(T entity)
        {
            entities.Add(entity);
            Save();
            return entity;
        }

        
        public T Update(T entity)
        {
            entities.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            Save();

            return entity;
        }


        

        public ICollection<T> GetAllEntity()
        {
            return entities.ToList();
        }


        public T GetEntityById(int EntityId)
        {
            return entities.Find(EntityId);
        }

        private void Save()
        {
            try
            {
                context.SaveChanges();
                
            }
            catch 
            {
              
            }
        }
        

        public bool Delete(T entity)
        {
            try
            {


                if (context.Entry(entity).State == EntityState.Detached)
                {
                    entities.Attach(entity);
                }
                entities.Remove(entity);
                Save();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
