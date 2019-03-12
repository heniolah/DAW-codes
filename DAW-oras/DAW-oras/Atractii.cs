using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAW_oras
{
    public interface Atractii
    {
        string institutii_de_cultura();
        string monumente_si_cladiri();
        string muzee(int preturi, int orar);
        string parcuri();
    }
}
