﻿
using System.Threading.Tasks;

namespace ICS.XFramework.Data
{
    /// <summary>
    /// 数据上下文，表示 Xfw 框架的主入口点
    /// </summary>
    public partial interface IDbContext
    {
        /// <summary>
        /// 计算要插入、更新或删除的已修改对象的集，并执行相应命令以实现对数据库的更改
        /// </summary>
        /// <returns></returns>
        Task<int> SubmitChangesAsync();
    }
}
