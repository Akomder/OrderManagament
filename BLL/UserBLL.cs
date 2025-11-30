using DAL;

namespace BLL
{
    public class UserBLL
    {
        UserDAL dal = new UserDAL();

        public bool Login(string username, string password)
        {
            return dal.CheckLogin(username, password);
        }
    }
}
