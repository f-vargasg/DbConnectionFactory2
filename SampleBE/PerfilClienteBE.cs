using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleBE
{
    public class PerfilClienteBE
    {
        int codPerfilN;

        public int CodPerfilN
        {
            get { return codPerfilN; }
            set { codPerfilN = value; }
        }
        string desPerfil;

        public string DesPerfil
        {
            get { return desPerfil; }
            set { desPerfil = value; }
        }

        decimal codRegistroN;

        public decimal CodRegistroN
        {
            get { return codRegistroN; }
            set { codRegistroN = value; }
        }
        int codEstadoN;

        public int CodEstadoN
        {
            get { return codEstadoN; }
            set { codEstadoN = value; }
        }
    }
}
