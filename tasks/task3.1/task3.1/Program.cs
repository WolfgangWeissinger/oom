using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalObjects_bouncer[] bouncerarray = new RentalObjects_bouncer[5];
            bouncerarray[0] = new RentalObjects_bouncer ( "Babytreff", 73, 79, 119, 20 );
            bouncerarray[1] = new RentalObjects_bouncer("Happy Train", 73, 79, 119, 15);
            bouncerarray[2] = new RentalObjects_bouncer("SkyKids", 73, 79, 119, 30);
            bouncerarray[3] = new RentalObjects_bouncer("Fantasia", 91, 99, 146, 80);
            bouncerarray[4] = new RentalObjects_bouncer("Schwammerl", 91, 99, 146, 80);

            RentalObjects_bouncer babytreff = new RentalObjects_bouncer("Babytreff Luftburg", 73, 79, 119, 20);
            RentalObjects_bouncer happytrain = new RentalObjects_bouncer("Happy Train", 73, 79, 119, 15);

            Console.WriteLine("Name von Babytreff: {0}", bouncerarray[0].prop_name);
            Console.WriteLine("Wochentagspreis von Babytreff: Euro {0},-", bouncerarray[1].prop_price_weekdays);
            Console.WriteLine("Name von HappyTrain: {0}", bouncerarray[2].prop_name);
            Console.WriteLine("Wochenendpreis von HappyTrain: {0} Euro ", bouncerarray[3].prop_price_weekends);  

            var preis = bouncerarray[0].price_calculation_pickup(bouncerarray[0].prop_price_weekdays, 5);
            var preis3 = bouncerarray[3].price_calculation_pickup(bouncerarray[3].prop_price_weekdays, 5);

            Console.WriteLine("Ihr Preis für 5 Wochentage Babytreff: {0}", preis);
            Console.WriteLine("Ihr Preis für 5 Wochentage {1}: {0}", preis3, bouncerarray[3].prop_name);


        }
    }
}
