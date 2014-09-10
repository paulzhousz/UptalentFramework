using System;
using System.Collections.Generic;
using System.ComponentModel;
using PetaPoco;
using UptalentFramework.Collections;

namespace UptalentFramework.Data.PetaPoco
{
    public class PetaPocoRepository<T>:IRepository<T>
    {
        private Database _dbContext;
        protected IUnitOfWorkProvider UowProvider { get; private set; }

        public PetaPocoRepository(IUnitOfWorkProvider _uowProvider)
        {
            UowProvider = _uowProvider;
        }

        protected Database DBContext
        {
            get { return _dbContext ?? UowProvider.GetDBContext() as Database; }
        }

        public TPassType Single<TPassType>(object primaryKey)
        {
            return DBContext.Single<TPassType>(primaryKey);
        }

        public TPassType Single<TPassType>(string sql, params object[] args)
        {
            return DBContext.Single<TPassType>(sql, args);
        }

        public TPassType Single<TPassType>(string sql)
        {
            return DBContext.Single<TPassType>(sql);
        }

        public TPassType SingleOrDefault<TPassType>(object primaryKey)
        {
            return DBContext.SingleOrDefault<TPassType>(primaryKey);
        }

        public TPassType SingleOrDefault<TPassType>(string sql, params object[] args)
        {
            return DBContext.SingleOrDefault<TPassType>(sql, args);
        }

        public TPassType SingleOrDefault<TPassType>(string sql)
        {
            return DBContext.SingleOrDefault<TPassType>(sql);
        }

        public IEnumerable<TPassType> Query<TPassType>()
        {
            var pd = TableInfo.FromPoco(typeof(TPassType));
            var sql = "SELECT * FROM " + pd.TableName;
            return DBContext.Query<TPassType>(sql);
        }

        public IEnumerable<TPassType> Query<TPassType>(string sql, params object[] args)
        {
            return DBContext.Query<TPassType>(sql, args);
        }

        public IEnumerable<TPassType> Query<TPassType>(string sql)
        {
            return DBContext.Query<TPassType>(sql);
        }

        public List<TPassType> Fetch<TPassType>()
        {
            
            var pd = TableInfo.FromPoco(typeof(TPassType));
            var sql = "SELECT * FROM " + pd.TableName;
            return DBContext.Fetch<TPassType>(sql);
        }

        public List<TPassType> Fetch<TPassType>(string sql, params object[] args)
        {
            return DBContext.Fetch<TPassType>(sql, args);
        }

        public List<TPassType> Fetch<TPassType>(string sql)
        {
            return DBContext.Fetch<TPassType>(sql);
        }

        public int Insert(object poco)
        {
            return Convert.ToInt32(DBContext.Insert(poco));
        }

        public int Insert(string tableName, string primaryKeyName, bool autoIncrement, object poco)
        {
            return Convert.ToInt32(DBContext.Insert(tableName, primaryKeyName, autoIncrement, poco));
        }

        public int Insert(string tableName, string primaryKeyName, object poco)
        {
            return Convert.ToInt32(DBContext.Insert(tableName, primaryKeyName, poco));
        }

        public int Update(object poco)
        {
            return DBContext.Update(poco);
        }

        public int Update(object poco, object primaryKeyValue)
        {
            return DBContext.Update(poco, primaryKeyValue);
        }

        public int Update(string tableName, string primaryKeyName, object poco)
        {
            return DBContext.Update(tableName, primaryKeyName, poco);
        }

        public int Update(object poco, IEnumerable<string> columns)
        {
            return DBContext.Update(poco, columns);
        }

        public int Update<TPassType>(string sql)
        {
            return DBContext.Update<TPassType>(sql);
        }

        public int Update<TPassType>(string sql, params object[] args)
        {
            return DBContext.Update<TPassType>(sql, args);
        }

        public int Delete<TPassType>(object pocoOrPrimaryKey)
        {
            return DBContext.Delete<TPassType>(pocoOrPrimaryKey);
        }

        public int Delete<TPassType>(string sql)
        {
            return DBContext.Delete<TPassType>(sql);
        }

        public int Delete<TPassType>(string sql, params object[] args)
        {
            return DBContext.Delete<TPassType>(sql, args);
        }

        public long GetCounts<TPassType>(string sql, params object[] args)
        {
            var pd = TableInfo.FromPoco(typeof(TPassType));
            var strsql = "SELECT count(1) FROM " + pd.TableName;
            return DBContext.ExecuteScalar<long>(strsql, args);
        }

        public long GetCounts<TPassType>(string sql)
        {
            return GetCounts<TPassType>(sql, new object[] { });
        }

        public bool Exists<TPassType>(string sql, params object[] args)
        {
            return (GetCounts<TPassType>(sql, args) > 0);
        }

        public bool Exists<TPassType>(string sql)
        {
            return (GetCounts<TPassType>(sql) > 0);
        }


        public string LastSQL()
        {
            return DBContext.LastSQL;
        }


        public IPagedList<T> PagedList(int pageIndex, int pageSize, string sqlCondition, params object[] args)
        {
            //throw new System.NotImplementedException();
            Page<T> petaPocoPage = DBContext.Page<T>(pageIndex + 1, pageSize, sqlCondition, args);

            return new PagedList<T>(petaPocoPage.Items, (int)petaPocoPage.TotalItems, pageIndex, pageSize);
        }

        public IPagedList<T> PagedList(int pageIndex, int pageSize, string sqlCondition)
        {
            //throw new System.NotImplementedException();
            Page<T> petaPocoPage = DBContext.Page<T>(pageIndex + 1, pageSize, sqlCondition);

            return new PagedList<T>(petaPocoPage.Items, (int)petaPocoPage.TotalItems, pageIndex, pageSize);
        }
    }
}