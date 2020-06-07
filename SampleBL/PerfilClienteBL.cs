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
    }
}
