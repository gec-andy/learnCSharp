using _00_01_数据库发访问项目;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _08_02_三层架构之用户登录.DAO
{
    public class UserDao
    {
        /// <summary>
        /// 检查用户是否存在
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static bool OnCheckUserNameExsits(string userName)
        {
            //设置SQL执行命令
            SqlServerHelper.SettingCommandText("Select Count(*) From Users Where loginId = @UserName ");
            //添加参数列表
            SqlServerHelper.SqlParametersInstance.Add(new SqlParameter() { ParameterName = "@UserName", Value = userName });
            //将执行完毕的结果进行传递给上层
            return Convert.ToInt32(SqlServerHelper.Instance.ExecuteScaler().ToString()) > 0;
        }
        /// <summary>
        /// 检查用户名和密码是否匹配
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool OnCheckUserNameWithPasswordIsMatch(string userName, string password)
        {
            //设置SQL执行命令
            SqlServerHelper.SettingCommandText("Select Count(*) From Users Where loginId = @UserName and loginPwd = @Pwd");
            //添加参数列表
            SqlServerHelper.SqlParametersInstance.AddRange(new List<SqlParameter>() {
                new SqlParameter() { ParameterName = "@UserName", Value = userName },
                new SqlParameter() { ParameterName = "@Pwd", Value = password } });
            //将执行完毕的结果进行传递给上层
            return Convert.ToInt32(SqlServerHelper.Instance.ExecuteScaler().ToString()) > 0;
        }
    }
}
