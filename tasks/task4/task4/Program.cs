using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


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

            var c = new RentalObjects_bouncer("SkyKids", 73, 79, 119, 20);

            var a = JsonConvert.SerializeObject(c);
            Console.WriteLine(a);

            
            RentalObjects_bouncer b = JsonConvert.DeserializeObject<RentalObjects_bouncer>(a);
            Console.WriteLine(b.prop_name);
            Console.WriteLine(b.prop_price_weekdays);


        }
    }
}
