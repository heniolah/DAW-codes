using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAW_oras
{
    public class Strada
    { string Nume_Strada;
        public Strada(string Nume_Strada)
        {
            this.Nume_Strada = Nume_Strada;
        }
        public override string ToString()
        {
            return Nume_Strada;
        }
    }
}
