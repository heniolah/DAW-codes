using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAW_oras
{
    public class Localizare
    {
        public Random rnd = new Random();
        string tara, judet;
        int distanta_transport;
        int x, y;

        public string Nume_Tara
        {
            get { return tara; }
            set { tara = value; }
        }
        public string Nume_Judet
        {
            get { return judet; }
            set { judet = value; }
        }
        public int locatieX
        {
            get { return x=rnd.Next(180); }
        }
        public int locatieY
        {
            get { return y = rnd.Next(180); }
        }
        public int Dist_Transport
        {
            get { return distanta_transport; }
            set { distanta_transport = value; }
        }
        enum transporturi
        {
            intern, ext
        }
        transporturi t;
        public void transport(List<Strada> s)
        {
            string combindedString1 = string.Join(", ", s.Take(2));
            string combindedString2 = string.Join(", ", s.Take(5));
            switch (t)
            {
                case transporturi.intern:
                    Console.WriteLine("bus1, tramvai1, taxi1"+ "\n"+ "prin strazile:"+ "\n" + combindedString1);
                    break;
                case transporturi.ext:
                    if(distanta_transport<300)
                    Console.WriteLine("bus2, tren2, taxi2" + "\n" + "prin strazile:" + "\n" + combindedString2);
                    else Console.WriteLine("avion -> ...");
                    break;
            }
        }
    }
}
