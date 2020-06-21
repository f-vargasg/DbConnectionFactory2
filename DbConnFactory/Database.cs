using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace DbConnFactory
{
    public abstract class Database
    {
        public string connectionString;
        #region Abstract Functions
        public abstract DbConnection CreateConnection();
        public abstract DbConnection CreateOpenConnection();
        public abstract DbCommand CreateCommand();
        public abstract DbCommand CreateCommand(string commandText, DbConnection connection);
        public abstract DbCommand CreateStoredProcCommand(string procName, DbConnection connection);
        public abstract DbParameter CreateParameter(string parameterName, object parameterValue);
        public abstract DbParameter CreateParameter(string parameterName, DbType dbType, object parameterValue);

        public abstract DbParameter CreateParameter(string parameterName, DbType dbType, ParameterDirection parameterDirection);

        // public abstract IDataParameter CreateParameter(string parameterName, object parameterValue, );

        #endregion
    }
}