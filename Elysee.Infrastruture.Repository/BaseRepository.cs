using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elysee.Infrastruture.Repository
{
    /// <summary>
    /// 实现对数据库的（增删改查）的基类
    /// </summary>
    /// <typeparam name="T">定义泛型：约束其为一个类</typeparam>
    public class BaseRepository<T> where T : class
    {
        //创建EF上下文，EF上下文保证线程内唯一
        private DbContext db = EFContextFactory.GetCurrentDbContext();

        /// <summary>
        /// 实现对数据库的添加功能
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public T AddEntity(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Added;

            db.SaveChanges();

            return entity;
        }

        /// <summary>
        /// 实现对数据库的删除功能
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool DeleteEntity(T entity)
        {
            db.Set<T>().Attach(entity);

            db.Entry<T>(entity).State = EntityState.Deleted;

            return db.SaveChanges() > 0;
        }

        /// <summary>
        /// 实现对数据库的修改功能
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool UpdateEntity(T entity)
        {
            db.Set<T>().Attach(entity);

            db.Entry<T>(entity).State = EntityState.Modified;

            return db.SaveChanges() > 0;
        }

        /// <summary>
        /// 实现对数据库的查询功能
        /// </summary>
        /// <param name="whereLambda">查询条件</param>
        /// <returns></returns>
        public IQueryable<T> LoadEntities(Func<T,bool> whereLambda)
        {
            return db.Set<T>().Where<T>(whereLambda).AsQueryable();
        }


        /// <summary>
        /// 实现对数据库的分页查询功能
        /// </summary>
        /// <typeparam name="S">按照某个类进行分页</typeparam>
        /// <param name="pageIndex">当前第几页</param>
        /// <param name="pageSize">一页显示多少条数据</param>
        /// <param name="total">总条数</param>
        /// <param name="whereLambda">取得排序条件</param>
        /// <param name="isAsc">如何排序，根据倒叙还是升序</param>
        /// <param name="orderByLambda">根据那个字段进行排序</param>
        /// <returns></returns>
        public IQueryable<T> LoadPageEntities<S>(int pageIndex, int pageSize, out int total, Func<T, bool> whereLambda, bool isAsc,
            Func<T, S> orderByLambda)
        {
            var temp = db.Set<T>().Where<T>(whereLambda);

            //得到总的数量
            total = temp.Count();

            if (isAsc)
            {
                temp = temp.OrderBy<T, S>(orderByLambda)
                    .Skip<T>(pageSize * (pageIndex - 1))//越过多少条
                    .Take<T>(pageSize).AsQueryable();//取出多少条
            }
            else
            {
                temp = temp.OrderByDescending<T, S>(orderByLambda)
                   .Skip<T>(pageSize * (pageIndex - 1))//越过多少条
                   .Take<T>(pageSize).AsQueryable();//取出多少条
            }

            return temp.AsQueryable();
        }
    }
}
