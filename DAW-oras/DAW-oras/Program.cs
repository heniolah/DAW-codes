using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAW_oras
{
    class Program
    {
        static void Main(string[] args)
        {
            Oras o = new Oras();
            o.Nume = "Oradea";
            o.Nume_Judet = "Bihor";
            o.Nume_Tara = "Romania";
            Console.WriteLine();
            Console.WriteLine("Se da tara: " +o.Nume_Tara);
            Console.WriteLine();
            Console.WriteLine("Numele orasului: " + o.Nume + "        din judetul: "+o.Nume_Judet);
            Console.WriteLine();
            Console.WriteLine("Populatia orasului:" + o.Populatie);
            Console.WriteLine();
            Console.WriteLine();
            o.Dist_Transport = 10; //km
            List<Strada> s = new List<Strada>();
            Strada strazi_de_transporturi = new Strada("Salami Route");
            s.Add(strazi_de_transporturi);
            strazi_de_transporturi = new Strada("Bulevardul Dacia");
            s.Add(strazi_de_transporturi);
            strazi_de_transporturi = new Strada("Bulevardul Decebal");
            s.Add(strazi_de_transporturi);
            strazi_de_transporturi = new Strada("Avram Iancu");
            s.Add(strazi_de_transporturi);
            strazi_de_transporturi = new Strada("Buna ziua");
            s.Add(strazi_de_transporturi);
            Console.WriteLine("Transporturi interne cu:");
            o.transport(s);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lista cartierelor din oras:");
            foreach (var item in Enum.GetNames(typeof(Oras.cartiere)))
            {
                Console.WriteLine(item + ":"); o.hoteluri_si_pensiuni(); Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lista de scoli din oras:");
            foreach (var item in Enum.GetNames(typeof(Oras.lista_scolilor)))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Lista cluburilor sportive din oras:");
            foreach (var item in Enum.GetNames(typeof(Oras.lista_cluburilor_sportive)))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Lista spitalelor din oras:");
            foreach (var item in Enum.GetNames(typeof(Oras.lista_spitalelor)))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Lista de fabrici din oras:");
            foreach (var item in Enum.GetNames(typeof(Oras.lista_fabricilor)))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Atractii turistice:");
            Console.WriteLine("institutii de cultura: "+o.institutii_de_cultura());
            Console.WriteLine("monumente_si_cladiri: " + o.monumente_si_cladiri());
            Console.WriteLine("parcuri: " +o.parcuri()); 
            Console.Write(o.muzee(15,12));
            Console.ReadKey();
        }
    }
}
