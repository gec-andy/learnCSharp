using System.Data.Common;

namespace _00_01_数据库发访问项目
{
    /// <summary>
    /// 数据访问行为
    /// </summary>
    /// <typeparam name="TReturnParameter"></typeparam>
    public interface ISqlActionable
    {
        void ExecuteCommand();
        DbDataReader ExecuteReader();
        DbDataAdapter EexcuteAdapter();

    }
}
