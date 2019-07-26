using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

namespace _00_01_数据库发访问项目
{
    /// <summary>
    /// SqlServer数据库访问帮助类
    /// </summary>
    public class SqlServerHelper : BaseSqlHelper
    {
        private static SqlServerHelper _instance;
        public static SqlServerHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SqlServerHelper();
                }
                return _instance;
            }
        }
        private static SqlConnection _ConnectionInstance;
        /// <summary>
        /// 连接对象
        /// </summary>
        private static SqlConnection ConnectionInstance
        {
            get
            {
                if (_ConnectionInstance == null)
                    _ConnectionInstance = new SqlConnection(SqlConnectText);
                return _ConnectionInstance;
            }
        }
        private static SqlCommand _CommandInstance;
        /// <summary>
        /// 命令对象
        /// </summary>
        private static SqlCommand CommandInstance
        {
            get
            {
                if (_CommandInstance == null)
                    _CommandInstance = new SqlCommand(SqlCommandText, ConnectionInstance);
                return _CommandInstance;
            }
        }
        /// <summary>
        /// 数据适配器
        /// </summary>
        private SqlDataAdapter adapter = null;
        /// <summary>
        /// 数据局读取器
        /// </summary>
        private SqlDataReader reader = null;
        private object objResult = null;

        private static List<SqlParameter> _SqlParametersInstance;
        /// <summary>
        /// 数据参数
        /// </summary>
        public static List<SqlParameter> SqlParametersInstance
        {
            get

            {
                if (_SqlParametersInstance == null)
                {
                    _SqlParametersInstance = new List<SqlParameter>();
                }
                return _SqlParametersInstance;
            }
        }
        private SqlServerHelper() { }


        /// <summary>
        /// 执行命令
        /// </summary>
        public override void ExecuteCommand()
        {
            try
            {
                CommandInstance.CommandText = SqlCommandText;
                CommandInstance.Connection = ConnectionInstance;
                ConnectionInstance.Open();
                if (SqlParametersInstance != null && SqlParametersInstance.Count > 0)
                {
                    foreach (SqlParameter parameter in SqlParametersInstance)
                    {
                        SqlParameter copyParameter = (SqlParameter)((ICloneable)parameter).Clone();
                        CommandInstance.Parameters.Add(copyParameter);
                    }
                }
                SqlDataOperationRecord = CommandInstance.ExecuteNonQuery();
                ConnectionInstance.Close();
            }
            catch (Exception exception)
            {
                base.SettingOperattionMessage(exception.Message);
            }
            SettingCommandText(string.Empty);
            CommandInstance.Parameters.Clear();
            SqlParametersInstance.Clear();
        }

        public object ExecuteScaler()
        {
            return objResult;
        }
        /// <summary>
        /// 数据读取器
        /// </summary>
        /// <returns></returns>
        public override DbDataReader ExecuteReader()
        {
            try
            {
                CommandInstance.CommandText = SqlCommandText;
                CommandInstance.Connection = ConnectionInstance;
                ConnectionInstance.Open();
                if (SqlParametersInstance != null)
                    if (SqlParametersInstance.Count > 0)
                        CommandInstance.Parameters.AddRange(SqlParametersInstance.ToArray());
                this.reader = CommandInstance.ExecuteReader();
                ConnectionInstance.Close();
            }
            catch (Exception ex)
            {
                base.SettingOperattionMessage(ex.Message);
            }
            SettingCommandText(string.Empty);
            CommandInstance.Parameters.Clear();
            SqlParametersInstance.Clear();
            return this.reader;
        }
        /// <summary>
        /// 数据适配器
        /// </summary>
        /// <returns></returns>
        public override DbDataAdapter EexcuteAdapter()
        {
            if (!string.IsNullOrEmpty(SqlConnectText))
            {
                this.adapter = new SqlDataAdapter(SqlCommandText, SqlConnectText);
                if (SqlParametersInstance != null && SqlParametersInstance.Count > 0)
                    adapter.SelectCommand.Parameters.AddRange(SqlParametersInstance.ToArray());
            }
            return this.adapter;
        }
    }
}
