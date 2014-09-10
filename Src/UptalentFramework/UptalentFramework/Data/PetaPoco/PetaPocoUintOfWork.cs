using System.Collections.Generic;
using System.Configuration;
using System.Data;
using PetaPoco;

namespace UptalentFramework.Data.PetaPoco
{
    public class PetaPocoUintOfWork:IUintOfWork
    {

        #region Private Members
        private Database _dbContext;
        private readonly IUnitOfWorkProvider _uowProvider;
        #endregion

        public PetaPocoUintOfWork(IUnitOfWorkProvider uowProvider)
        {
            _uowProvider = uowProvider;
        }

        public Database DBContext
        {
            get { return _dbContext ?? (_dbContext = _uowProvider.GetDBContext() as Database); }
        }

        public void BeginTransaction()
        {
            DBContext.BeginTransaction();
        }

        public void Commit()
        {
            DBContext.CompleteTransaction();
        }

        public void Execute(CommandType type, string sql, params object[] args)
        {
            if (type == CommandType.StoredProcedure)
            {
                sql = DataUtil.GenerateExecuteStoredProcedureSql(sql, args);
            }

            DBContext.Execute(sql, args);
        }

        public IEnumerable<T> ExecuteQuery<T>(CommandType type, string sql, params object[] args)
        {
            if (type == CommandType.StoredProcedure)
            {
                sql = DataUtil.GenerateExecuteStoredProcedureSql(sql, args);
            }

            return DBContext.Fetch<T>(sql, args);
        }

        public T ExecuteScalar<T>(CommandType type, string sql, params object[] args)
        {
            if (type == CommandType.StoredProcedure)
            {
                sql = DataUtil.GenerateExecuteStoredProcedureSql(sql, args);
            }

            return DBContext.ExecuteScalar<T>(sql, args);
        }

        public T ExecuteSingleOrDefault<T>(CommandType type, string sql, params object[] args)
        {
            if (type == CommandType.StoredProcedure)
            {
                sql = DataUtil.GenerateExecuteStoredProcedureSql(sql, args);
            }

            return DBContext.SingleOrDefault<T>(sql, args);
        }

        public void RollbackTransaction()
        {
            DBContext.AbortTransaction();
        }


        public void Dispose()
        {
            DBContext.Dispose();
        }
    }
}