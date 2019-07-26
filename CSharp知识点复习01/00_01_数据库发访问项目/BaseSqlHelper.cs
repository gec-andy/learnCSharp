using System.Data.Common;

namespace _00_01_数据库发访问项目
{
    /// <summary>
    /// 数据库访问帮助类
    /// </summary>
    public abstract class BaseSqlHelper : ISqlActionable
    {
        private static string _sqlConnectText = string.Empty;
        private static string _sqlCommandText = string.Empty;
        private static string _sqlDataOperationResult = string.Empty;
        private static int _sqlDataOperationRecord = -1;
        private static string _sqlDataOperationMessage = string.Empty;
        private static object _sqlDataReaderResult = null;
        /// <summary>
        /// SQL连接文本
        /// </summary>
        public static string SqlConnectText { get => _sqlConnectText; set => _sqlConnectText = value; }
        /// <summary>
        /// SQL命令文本
        /// </summary>
        public static string SqlCommandText { get => _sqlCommandText; set => _sqlCommandText = value; }
        /// <summary>
        /// SQL数据操作结果
        /// </summary>
        public static string SqlDataOperationResult { get => _sqlDataOperationResult; set => _sqlDataOperationResult = value; }
        /// <summary>
        /// SQL数据操作记录
        /// </summary>
        public static int SqlDataOperationRecord { get => _sqlDataOperationRecord; set => _sqlDataOperationRecord = value; }
        /// <summary>
        /// SQL数据操作信息
        /// </summary>
        public static string SqlDataOperationMessage { get => _sqlDataOperationMessage; set => _sqlDataOperationMessage = value; }
        public static object SqlDataReaderResult { get => _sqlDataReaderResult; set => _sqlDataReaderResult = value; }

        static BaseSqlHelper()
        {
            //TODO: 从配置文件中读取数据库连接字符串
            //      设置数据库连接字符串
        }
        /// <summary>
        /// 根据数据操作类别执行命令
        /// </summary>
        /// <param name="type">数据操作类别</param>
        public abstract void ExecuteCommand();
        /// <summary>
        /// 执行读取器
        /// </summary>
        /// <returns></returns>
        public abstract DbDataReader ExecuteReader();
        /// <summary>
        /// 执行适配器
        /// </summary>
        /// <returns></returns>
        public abstract DbDataAdapter EexcuteAdapter();

        /// <summary>
        /// 设置命令字符串
        /// </summary>
        /// <param name="strCommandText"></param>
        public static void SettingCommandText(string strCommandText)
        {
            SqlCommandText = strCommandText;
        }
        /// <summary>
        /// 设置数据操作信息
        /// </summary>
        /// <param name="strOperationMessage"></param>
        public void SettingOperattionMessage(string strOperationMessage)
        {
            SqlDataOperationMessage = strOperationMessage;
        }
    }
}
