using IMS.Data.Model;

namespace IMS.Data.DAL.IContext
{
    public interface IUserContext
    {
        UserManager GetUserByUserName(string UserName);
    }
}