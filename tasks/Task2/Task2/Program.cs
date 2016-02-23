using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;


namespace Task2
{ 
    class programm
    { 
        static void Main(string[] args)
        {
            var ronaldo = new footballplayer("ronaldo", "POR");
            var messi = new footballplayer("messi", "ARG");
            Console.WriteLine("Nationalitaet Ronaldo: {0}", ronaldo.nationality);
            Console.WriteLine("{0}", messi);

            int tore = 200;
            messi.UpdateGoals(tore);
            Console.WriteLine("{0}", messi);
        }
    }
}