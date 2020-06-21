using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace DbConnFactory
{
    public class OracleOdpDatabase : Database
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

        public OracleDbType ConvertDbType2OraDbyType(DbType dbType)
        {
            OracleDbType res = OracleDbType.Int32;
            switch (dbType)
            {
                case DbType.AnsiString:
                    throw new NotSupportedException();
                // break;
                case DbType.Binary:
                    res = OracleDbType.Raw;
                    break;
                case DbType.Byte:
                    res = OracleDbType.Byte;
                    break;
                case DbType.Boolean:
                    res = OracleDbType.Boolean;
                    break;
                case DbType.Currency:
                    throw new NotSupportedException();
                // break;
                case DbType.Date:
                    res = OracleDbType.Date;
                    break;
                case DbType.DateTime:
                    res = OracleDbType.TimeStamp;
                    break;
                case DbType.Decimal:
                    res = OracleDbType.Decimal;
                    break;
                case DbType.Double:
                    res = OracleDbType.Double;
                    break;
                case DbType.Guid:
                    throw new NotSupportedException();
                case DbType.Int16:
                    res = OracleDbType.Int16;
                    break;
                case DbType.Int32:
                    res = OracleDbType.Int32;
                    break;
                case DbType.Int64:
                    res = OracleDbType.Int64;
                    break;
                case DbType.Object:
                    res = OracleDbType.Object;
                    break;
                case DbType.SByte:
                    throw new NotSupportedException();
                case DbType.Single:
                    res = OracleDbType.Single;
                    break;
                case DbType.String:
                    res = OracleDbType.Varchar2;
                    break;
                case DbType.Time:
                    res = OracleDbType.TimeStamp;
                    break;
                case DbType.UInt16:
                    throw new NotSupportedException();
                case DbType.UInt32:
                    throw new NotSupportedException();
                case DbType.UInt64:
                    throw new NotSupportedException();
                case DbType.VarNumeric:
                    throw new NotSupportedException();
                case DbType.AnsiStringFixedLength:
                    res = OracleDbType.NChar;
                    break;
                case DbType.StringFixedLength:
                    res = OracleDbType.Char;
                    break;
                case DbType.Xml:
                    throw new NotSupportedException();
                case DbType.DateTime2:
                    throw new NotSupportedException();
                case DbType.DateTimeOffset:
                    throw new NotSupportedException();
                default:
                    throw new NotSupportedException();
            }
            return res;
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
            OracleDbType oracleDbType = ConvertDbType2OraDbyType(dbType);
            OracleParameter oraParam = new OracleParameter(parameterName, oracleDbType);
            oraParam.Value = parameterValue;
            return oraParam;
        }

        public override DbParameter CreateParameter(string parameterName, DbType dbType, ParameterDirection parameterDirection)
        {
            OracleDbType oracleDbType = ConvertDbType2OraDbyType(dbType);
            OracleParameter oraParam = new OracleParameter();
            oraParam.ParameterName = parameterName;
            oraParam.OracleDbType = oracleDbType;
            oraParam.Direction = parameterDirection;
            return oraParam;
        }

    }
}
