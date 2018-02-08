using IMS.Data.Model;

namespace IMS.Data.DLL.IContext
{
    public interface IUserContext
    {
        UserManager GetUserByUserName(string UserName);
    }
}