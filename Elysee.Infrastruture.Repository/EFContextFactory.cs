using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;
using Elysee.Infrastruture.Entity;

namespace Elysee.Infrastruture.Repository
{
    public class EFContextFactory
    {
        /// <summary>
        /// 返回当前线程内的数据库上下文，如果当前线程内没有上下文，则创建一个上下文
        /// 保证实例在线程内是唯一的
        /// </summary>
        /// <returns></returns>
        public static DbContext GetCurrentDbContext()
        {
            //CallContext:线程内部唯一独用的数据槽（一块内存空间）
            //传递DbContext进去获取实例信息，这里进行强制转换
            DbContext dbContext = CallContext.GetData("DbContext") as DbContext;

            //在线程槽内没有上下文
            if (null == dbContext)
            {
                //如果不存在，创建一个EF上下文
                dbContext = new H3Entities();

                //把上下文放到数据槽中
                CallContext.SetData("DbContext", dbContext);
            }
            return dbContext;
        }
    }
}
