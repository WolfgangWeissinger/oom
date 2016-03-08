using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.2
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalObjects babytreff = new RentalObjects("Babytreff Luftburg", 73, 79, 119, 20);
            RentalObjects happytrain = new RentalObjects("Happy Train", 73, 79, 119, 15);

            Console.WriteLine("Name von Babytreff: {0}", babytreff.prop_name);
            Console.WriteLine("Wochentagspreis von Babytreff: Euro {0},-", babytreff.prop_price_weekdays);
            Console.WriteLine("Name von HappyTrain: {0}", happytrain.prop_name);
            Console.WriteLine("Wochenendpreis von HappyTrain: {0} Euro ", happytrain.prop_price_weekends);

            var preis = babytreff.price_calculation(babytreff.prop_price_weekdays, 5);

            Console.WriteLine("Ihr Preis für 5 Wochentage Babytreff: {0}", preis);

            

        }
    }
}
