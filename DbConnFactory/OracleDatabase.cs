using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OracleClient;
using System.Linq;
using System.Text;

namespace DbConnFactory
{
    public class OracleDatabase : Database
    {
        public override DbConnection CreateConnection()
        {
            return new OracleConnection(connectionString);
        }

        public override DbConnection CreateOpenConnection()
        {
            OracleConnection connection = (OracleConnection)CreateConnection();
            connection.Open();

            return connection;
        }

        public override DbCommand CreateCommand()
        {
            return new OracleCommand();
        }


        public override DbCommand CreateCommand(string commandText, DbConnection connection)
        {
            OracleCommand command = (OracleCommand)CreateCommand();

            command.CommandText = commandText;
            command.Connection = (OracleConnection)connection;
            command.CommandType = CommandType.Text;

            return command;
        }

        public override DbCommand CreateStoredProcCommand(string procName, DbConnection connection)
        {
            OracleCommand command = (OracleCommand)CreateCommand();

            command.CommandText = procName;
            command.Connection = (OracleConnection)connection;
            command.CommandType = CommandType.StoredProcedure;

            return command;

        }

        public override DbParameter CreateParameter(string parameterName, object parameterValue)
        {
            return new OracleParameter(parameterName, parameterValue);
        }

        public override DbParameter CreateParameter(string parameterName, DbType dbType, object parameterValue)
        {
            throw new NotImplementedException();
        }


        public override DbParameter CreateParameter(string parameterName, DbType dbType, ParameterDirection parameterDirection)
        {
            throw new NotImplementedException();
        }
    }
}
