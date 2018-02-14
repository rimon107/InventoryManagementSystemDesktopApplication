using IMS.Data.DAL.IContext;
using IMS.Data.Model;
using IMS.Service.DAL.IContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace IMS.Data.DAL.Context
{
    public class Context<T> : IContext<T>  where T: class
    {
        private bool disposed;
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
        
        public IList<T> GetAll()
        {
            return entities.ToList();
        }


        public T GetById(int EntityId)
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
