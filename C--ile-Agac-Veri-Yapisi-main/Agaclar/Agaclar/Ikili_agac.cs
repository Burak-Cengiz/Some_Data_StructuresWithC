using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agaclar
{
    public class Ikili_agac
    {

        public Ikili_agac(object veri)
        {
            this.veri = veri;
            sol = null;
            sag = null;
        }

        public object veri;
        public Ikili_agac sol;
        public Ikili_agac sag;

    }
}
