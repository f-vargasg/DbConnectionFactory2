using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnFactory
{
    class MySqlDatabase : Database
    {
        public override DbConnection CreateConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public override DbConnection CreateOpenConnection()
        {
            MySqlConnection connection = (MySqlConnection)CreateConnection();
            connection.Open();

            return connection;
        }

        public override DbCommand CreateCommand()
        {
            return new MySqlCommand();
        }

        public override DbCommand CreateCommand(string commandText, DbConnection connection)
        {
            MySqlCommand command = (MySqlCommand)CreateCommand();

            command.CommandText = commandText;
            command.Connection = (MySqlConnection)connection;
            command.CommandType = CommandType.Text;

            return command;
        }

        public override DbCommand CreateStoredProcCommand(string procName, DbConnection connection)
        {
            MySqlCommand command = (MySqlCommand)CreateCommand();

            command.CommandText = procName;
            command.Connection = (MySqlConnection)connection;
            command.CommandType = CommandType.StoredProcedure;

            return command;
        }


        public override DbParameter CreateParameter(string parameterName, object parameterValue)
        {
            return new MySqlParameter(parameterName, parameterValue);
        }

        public override DbParameter CreateParameter(string parameterName, DbType dbType, object parameterValue)
        {
            MySqlParameter sqlParameter = new MySqlParameter(parameterName, parameterValue);
            sqlParameter.DbType = dbType;
            return sqlParameter;
        }

        public override DbParameter CreateParameter(string parameterName, DbType dbType, ParameterDirection parameterDirection)
        {
            MySqlParameter sqlParameter = new MySqlParameter();
            sqlParameter.ParameterName = parameterName;
            sqlParameter.DbType = dbType;
            sqlParameter.Direction = parameterDirection;
            return sqlParameter;
        }


    }
}
