using IMS.Data.DLL.IContext;
using IMS.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Data.DLL.Context
{
    public class UserContext : IDisposable, IUserContext
    {
        private readonly InventoryEntities context;
        private bool disposed;

        public UserContext()
        {
            context = new InventoryEntities();
        }

        public UserManager GetUserByUserName(string UserName)
        {

            return context.UserManagers.Where(u => u.UserName == UserName).FirstOrDefault();

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
