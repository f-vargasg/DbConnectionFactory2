using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DbConnFactory
{
    class MsSqlServerDatabase : Database
    {

        public override DbConnection CreateConnection()
        {
            return new SqlConnection(connectionString);
        }

        public override DbConnection CreateOpenConnection()
        {
            return new SqlConnection();
        }


        public override DbCommand CreateCommand()
        {
            return new SqlCommand();
        }

        public override DbCommand CreateCommand(string commandText, DbConnection connection)
        {
            SqlCommand command = (SqlCommand)CreateCommand();

            command.CommandText = commandText;
            command.Connection = (SqlConnection)connection;
            command.CommandType = CommandType.Text;

            return command;
        }

        public override DbCommand CreateStoredProcCommand(string procName, DbConnection connection)
        {
            SqlCommand command = (SqlCommand)CreateCommand();

            command.CommandText = procName;
            command.Connection = (SqlConnection)connection;
            command.CommandType = CommandType.StoredProcedure;

            return command;
        }

        public override DbParameter CreateParameter(string parameterName, object parameterValue)
        {
            return new SqlParameter (parameterName, parameterValue);
        }

        public override DbParameter CreateParameter(string parameterName, DbType dbType, object parameterValue)
        {
            SqlParameter sqlParameter = new SqlParameter(parameterName, parameterValue);
            sqlParameter.DbType = dbType;
            return sqlParameter;
        }

        public override DbParameter CreateParameter(string parameterName, DbType dbType, ParameterDirection parameterDirection)
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = parameterName;
            sqlParameter.DbType = dbType;
            sqlParameter.Direction = parameterDirection;
            return sqlParameter;
        }

        
    }
}
