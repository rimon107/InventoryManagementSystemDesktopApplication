using IMS.Data.Model;
using IMS.Data.DLL.IContext;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Library;


namespace IMS.Service.BAL
{
    public class UserContext
    {
        private readonly IUserContext context;
        private UserManager _supplier = new UserManager();

        public UserContext(IUserContext context)
        {
            this.context = context;
        }

        public UserManager GetUserByUserName(string username)
        {
            return context.GetUserByUserName(username);
        }

        public bool ValidateUser(string UserName, string Password)
        {
            UserManager user = new UserManager();
            user.UserName = UserName;
            user.Password = Password;

            if (ModelState.IsValid<UserManager>(user))
            {
                var User = GetUserByUserName(UserName);

                if (User != null && User.Id != 0)
                {
                    if (User.Password.Equals(Password))
                    {
                        Session<UserManager>.User = User;
                        Session<UserManager>.LoginStatus = true;
                        return true;
                    }
                    
                }
            }
            Session<UserManager>.LoginStatus = false;
            return false;
            
    
            
            
        }
    }
}
