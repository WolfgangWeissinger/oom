using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Windows.Forms;
using System.Threading;



namespace task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 3
            Console.WriteLine("Lesson 3");
            RentalObjects_bouncer[] bouncerarray = new RentalObjects_bouncer[5];
            bouncerarray[0] = new RentalObjects_bouncer("Babytreff", 73, 79, 119, 20);
            bouncerarray[1] = new RentalObjects_bouncer("Happy Train", 73, 79, 119, 15);
            bouncerarray[2] = new RentalObjects_bouncer("SkyKids", 73, 79, 119, 30);
            bouncerarray[3] = new RentalObjects_bouncer("Fantasia", 91, 99, 146, 80);
            bouncerarray[4] = new RentalObjects_bouncer("Schwammerl", 91, 99, 146, 80);

            Console.WriteLine("Name erstes Arrayelement: {0} \n", bouncerarray[0].Name);
            Console.WriteLine("Preis Wochentag erstes Arrayelement: {0} \n", bouncerarray[0].Price_weekdays);
            Console.WriteLine("Preis Wochentag drittes Arrayelement: {0} \n", bouncerarray[2].Price_weekdays);

            var calculated = bouncerarray[2].price_calculation_delivery(bouncerarray[2].Price_weekdays, 3);
            Console.WriteLine("Kalkulierter Preis: {0}", calculated);


            // Lesson 4
            Console.WriteLine("Lesson 4");
            calculation[] calcarray = new calculation[3];
            calcarray[0] = new RentalObjects_bouncer("Babytreff", 73, 79, 119, 20);
            calcarray[1] = new RentalObjects_skydancer("Babytreff", 19, 24, 33, 10);
            calcarray[2] = new RentalObjects_bouncer("Fantasia", 91, 99, 146, 80);

            Console.WriteLine("Preis Lieferung erstes Arrayelement: {0} \n", calcarray[0].price_calculation_delivery(73, 5));


            // Lesson 5
            Console.WriteLine("Lesson 5");
            var c = new RentalObjects_bouncer("SkyKids", 73, 79, 119, 20);
            var a = JsonConvert.SerializeObject(c);
            Console.WriteLine(a);
            File.WriteAllText(@"C:\Users\Lenovo-User\oom\tasks\task4\test.txt", a);

            RentalObjects_bouncer b = JsonConvert.DeserializeObject<RentalObjects_bouncer>(a);
            string d = File.ReadAllText(@"C:\Users\Lenovo-User\oom\tasks\task4\test.txt");
            Console.WriteLine(b.Name);
            Console.WriteLine(b.Price_weekdays);
            Console.WriteLine(d);



            // Lesson 6
            Console.WriteLine("Lesson 6");
            // Task 1
            var fenster = new Form() { Text = "HW Lesson 6", Width = 640, Height = 480 };
            fenster.MouseMove += (sender, eventArgs) => Console.WriteLine($"[MouseMove event] ({eventArgs.X}, {eventArgs.Y})");
            fenster.MouseMove -= (sender, EventArgs) => Console.WriteLine($"[MouseMove event] ({EventArgs.X}, {EventArgs.Y})");


            var producer = new Subject<RentalObjects_bouncer>();
            producer.Subscribe(RentalObjects_bouncer => Console.WriteLine($"received value {RentalObjects_bouncer}"));
            var i = new RentalObjects_bouncer("Drachenhoehle", 91, 99, 146, 80);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            producer.OnNext(i);

            // Task 2


        }
   }
}

