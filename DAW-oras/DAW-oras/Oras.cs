using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAW_oras
{
    public class Oras:Localizare,Atractii
    {
        string nume;
        int populatie;
        public Strada[] strazi { get; set; }
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public int Populatie
        {
            get { return populatie=rnd.Next(1000,1000000); }
        }
        public enum lista_scolilor
        {
            scoala1, scoala2, scoala3
              
        }
        public enum lista_spitalelor
        {
            spital1, spital2, spital3

        }
        public enum lista_cluburilor_sportive
        {
            sport1, sport2, sport3

        }
        public enum lista_fabricilor
        {
            fabrica1, fabrica2, fabrica3

        }
        public enum cartiere
        {
            cartier1, cartier2, cartier3

        }

        public void hoteluri_si_pensiuni()
        {
            Console.WriteLine("hotel1, "+"pret:100$, "+"locatie (prin coordonate): {0},{1}",locatieX,locatieY);
            Console.WriteLine("hotel2, " + "pret:150$, " + "locatie (prin coordonate): {0},{1}", locatieX, locatieY);
            Console.WriteLine("hotel3, " + "pret:80$, " + "locatie (prin coordonate): {0},{1}", locatieX, locatieY);
            Console.WriteLine("pensiune1, " + "pret:50$, " + "locatie (prin coordonate): {0},{1}", locatieX, locatieY);
            Console.WriteLine("pensiune2, " + "pret:50$, " + "locatie (prin coordonate): {0},{1}", locatieX, locatieY);
            Console.WriteLine("pensiune3, " + "pret:25$, " + "locatie (prin coordonate): {0},{1}", locatieX, locatieY);
        }

        public string institutii_de_cultura()
        {
            return ("ex1, ex2, ex3, etc");
        }

        public string monumente_si_cladiri()
        {
            return ("ex1, ex2, ex3, etc");
        }

        public string muzee(int pret, int orar)
        {
            return ("Lista de muzee: muzeul1, muzeul2, muzeul3, etc " +"- de la ora:"+orar + " - pret:" +pret+"lei");
        }

        public string parcuri()
        {
            return ("ex1, ex2, ex3, etc");
        }
    }
}
