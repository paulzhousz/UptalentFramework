using System;
using System.Collections.Generic;
using System.Data;

namespace UptalentFramework.Data
{
    public interface IUintOfWork:IDisposable
    {
        void BeginTransaction();
        void Commit();

        void Execute(CommandType type, string sql, params object[] args);
        IEnumerable<T> ExecuteQuery<T>(CommandType type, string sql, params object[] args);
        T ExecuteScalar<T>(CommandType type, string sql, params object[] args);
        T ExecuteSingleOrDefault<T>(CommandType type, string sql, params object[] args);

        void RollbackTransaction();


    }
}