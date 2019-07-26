using _08_02_三层架构之用户登录.DAO;

namespace _08_02_三层架构之用户登录.BLL
{
    public class UserBLL
    {
        /// <summary>
        /// 处理用户登录请求
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string OnUserLogin(string userName, string password)
        {
            string result = string.Empty;
            if (UserDao.OnCheckUserNameExsits(userName))
                result = UserDao.OnCheckUserNameWithPasswordIsMatch(userName, password) ? "登陆成功~" : "登录失败~";
            else
                result = "账户不存在~";
            return result;
        }
    }
}
