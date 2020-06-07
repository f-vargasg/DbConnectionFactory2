using SampleBE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SampleDL
{
    public class PerfilClienteDL : DataWorker
    {
        public List<PerfilClienteBE> LoadProfile()
        {
            List<PerfilClienteBE> res = new List<PerfilClienteBE>();

            using (IDbConnection connection = database.CreateOpenConnection())
            {
                using (IDbCommand command = database.CreateCommand("SELECT * FROM CL_AMBPERFIL", connection))
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
    }
}
