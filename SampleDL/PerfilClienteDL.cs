using SampleBE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace SampleDL
{
    public class PerfilClienteDL : DataWorker
    {
        public List<PerfilClienteBE> LoadProfile()
        {
            List<PerfilClienteBE> res = new List<PerfilClienteBE>();

            using (DbConnection connection = database.CreateOpenConnection())
            {
                using (DbCommand command = database.CreateCommand("SELECT * FROM CL_AMBPERFIL", connection))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["DES_PERFIL"]);
                            PerfilClienteBE pcBe = new PerfilClienteBE();
                            pcBe.CodPerfilN = Convert.ToInt32(reader["COD_PERFIL_N"]);
                            pcBe.DesPerfil = Convert.ToString(reader["DES_PERFIL"]);
                            pcBe.CodRegistroN = Convert.ToDecimal(reader["COD_REGISTRO_N"]);
                            pcBe.CodEstadoN = Convert.ToInt32(reader["COD_ESTADO_N"]);
                            res.Add(pcBe);
                        }
                    }
                }
            }
            return res;
        }


        public int Suma(int a, int b)
        {
            int res = 0;
            using (DbConnection connection = database.CreateOpenConnection())
            {
                // using (DbCommand command = database.CreateStoredProcCommand("Pruebas_varias.suma", connection))
                using (DbCommand command = database.CreateStoredProcCommand("Suma", connection))
                {
                    try
                    {
                        DbParameter param = database.CreateParameter("p1", DbType.Int32, 10);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("p2", DbType.Int32, 30);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("p3", DbType.Int32, ParameterDirection.Output);
                        command.Parameters.Add(param);
                        command.ExecuteNonQuery();
                        res = int.Parse(command.Parameters["p3"].Value.ToString());
                        // string scrap = string.Format("Resultado de la suma {0}", res);
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
            }
            return res;

        }

        public int Suma2(int a, int b)
        {
            int res = 0;
            using (DbConnection connection = database.CreateOpenConnection())
            {
                // using (DbCommand command = database.CreateStoredProcCommand("Pruebas_varias.suma", connection))
                using (DbCommand command = database.CreateStoredProcCommand("Suma2", connection))
                {
                    try
                    {
                        DbParameter param = database.CreateParameter("v1", DbType.Int32, 10);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("v2", DbType.Int32, 30);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("return_value", DbType.Int32, ParameterDirection.ReturnValue);
                        command.Parameters.Add(param);
                        command.ExecuteNonQuery();
                        res = int.Parse(command.Parameters["return_value"].Value.ToString());
                        // string scrap = string.Format("Resultado de la suma {0}", res);
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }
            }
            return res;
        }


        /*
        public DbDataReader GetDataCursor()
        {
            DbDataReader res = null;
            using (DbConnection connection = database.CreateOpenConnection())
            {
                using (DbCommand command = database.CreateStoredProcCommand("Pruebas_varias.get_datosCursor", connection))
                {
                    try
                    {
                        DbParameter param = database.CreateParameter("p1", DbType.Int32, 10);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("p2", DbType.Int32, 30);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("p3", DbType.Int32, ParameterDirection.Output);
                        command.Parameters.Add(param);
                        command.ExecuteNonQuery();
                        res = int.Parse(command.Parameters["p3"].Value.ToString());
                        // string scrap = string.Format("Resultado de la suma {0}", res);
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
            }
            return res;
        }*/
    }
        
}
