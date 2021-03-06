﻿using System;
using System.Configuration;
using Microsoft.SqlServer.Server;
using PetaPoco;

namespace UptalentFramework.Data.PetaPoco
{
    public class PetaPocoUnitOfWorkProvider:IUnitOfWorkProvider,IDisposable
    {
        private Database _dbContext;
        public object GetDBContext()
        {            
            return _dbContext ?? (_dbContext = new Database(Constants.ConnstringDefaultName));
        }

        public object GetDBContext(string connectStringName)
        {
            return _dbContext ?? (_dbContext = new Database(connectStringName));
        }

        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }
    }
}