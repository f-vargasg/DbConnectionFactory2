using SampleBE;
using SampleDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleBL
{
    public class PerfilClienteBL
    {
        PerfilClienteDL perCliDL;

        public PerfilClienteBL()
        {
            this.perCliDL = new PerfilClienteDL();
        }

        public List<PerfilClienteBE> LoadProfile()
        {
            List<PerfilClienteBE> res;
            res = this.perCliDL.LoadProfile();
            return res;
        }

        public int Suma(int a, int b)
        {
            int res = 0;
            try
            {
                res = this.perCliDL.Suma(a, b);
            }
            catch (Exception)
            {

                throw;
            }


            return res;
        }

        public int Suma2(int a, int b)
        {
            int res = 0;
            try
            {
                res = this.perCliDL.Suma2(a, b);
            }
            catch (Exception)
            {

                throw;
            }


            return res;
        }
    }
}
