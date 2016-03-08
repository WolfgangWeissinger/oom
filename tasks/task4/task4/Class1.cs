using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3._1
{

    interface calculation
    {
        double price_calculation_pickup(double price, int days);
        double price_calculation_delivery(double price, int days);
    }



    class RentalObjects_bouncer : calculation
    {
        private string name;
        private double price_weekdays;
        private double price_weekends;
        private double price_48h;
        private int weight;
        // Properties
        public string prop_name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Namensfeld ist leer");
                else name = value;
            }
        }
        public double prop_price_weekdays
        {
            get { return price_weekdays; }
            set
            {
                if (value < 0) throw new Exception("Preis darf nicht negativ sein!");
                else price_weekdays = value;
            }
        }
        public double prop_price_weekends
        {
            get { return price_weekends; }
            set
            {
                if (value < price_weekdays) throw new Exception("Preis am Wochenende muss höher sein als unter der Woche");

                else price_weekends = value;
            }
        }
        public double prop_price_48h
        {
            get { return price_48h; }
            set
            {
                if (value < price_weekends) throw new Exception("Preis für 48h müss höher sein als Wochenendpreis (und Wochentagspreis)");

                else price_48h = value;
            }
        }
        public int prop_weight
        {
            get { return weight; }
            set
            {
                if (value < 0) throw new Exception("Gewicht darf nicht negativ sein");
                else weight = value;
            }
        }
        // Methods
        public double price_calculation_pickup(double price, int days)
        {
            if (days < 1) throw new Exception("Buchungsdauer muss mindestens einen Tag betragen!");
            return (price * days) * 0.9;
        }
        public double price_calculation_delivery(double price, int days)
        {
            if (days < 1) throw new Exception("Buchungsdauer muss mindestens einen Tag betragen!");
            return (price * days) * 0.9 + 25;
        }
        // Constructor
        public RentalObjects_bouncer(string newname, double newprice_weekdays, double newprice_weekends, double newprice_48h, int newweight)
        {
            if (string.IsNullOrEmpty(newname)) throw new Exception("Namensfeld ist leer");
            else name = newname;
            if (newprice_weekdays < 0) throw new Exception("Preis darf nicht negativ sein");
            else price_weekdays = newprice_weekdays;
            if (newprice_weekends < price_weekdays) throw new Exception("Preis am Wochenende muss höher sein als an einem Wochentag");
            else price_weekends = newprice_weekends;
            if (newprice_48h < price_weekends) throw new Exception("Preis für 48h muss größer sein als Wochenendpreis");
            else price_48h = newprice_48h;
            if (newweight < 0) throw new Exception("Gewicht darf nicht negativ sein. Fragen Sie Isaac Newton um Hilfe.");
        }
    }


    class RentalObjects_skydancer : calculation
    {
        private string name;
        private double price_weekdays;
        private double price_weekends;
        private double price_48h;
        private int weight;
        // Properties
        public string prop_name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Namensfeld ist leer");
                else name = value;
            }
        }
        public double prop_price_weekdays
        {
            get { return price_weekdays; }
            set
            {
                if (value < 0) throw new Exception("Preis darf nicht negativ sein!");
                else price_weekdays = value;
            }
        }
        public double prop_price_weekends
        {
            get { return price_weekends; }
            set
            {
                if (value < price_weekdays) throw new Exception("Preis am Wochenende muss höher sein als unter der Woche");

                else price_weekends = value;
            }
        }
        public double prop_price_48h
        {
            get { return price_48h; }
            set
            {
                if (value < price_weekends) throw new Exception("Preis für 48h müss höher sein als Wochenendpreis (und Wochentagspreis)");

                else price_48h = value;
            }
        }
        public int prop_weight
        {
            get { return weight; }
            set
            {
                if (value < 0) throw new Exception("Gewicht darf nicht negativ sein");
                else weight = value;
            }
        }
        // Methods
        public double price_calculation_pickup(double price, int days)
        {
            return (price * days) * 0.9;
        }
        public double price_calculation_delivery(double price, int days)
        {
            return (price * days) * 0.9 + 25;
        }
        // Constructor
        public RentalObjects_skydancer(string newname, double newprice_weekdays, double newprice_weekends, double newprice_48h, int newweight)
        {
            if (string.IsNullOrEmpty(newname)) throw new Exception("Namensfeld ist leer");
            else name = newname;
            if (newprice_weekdays < 0) throw new Exception("Preis darf nicht negativ sein");
            else price_weekdays = newprice_weekdays;
            if (newprice_weekends < price_weekdays) throw new Exception("Preis am Wochenende muss höher sein als an einem Wochentag");
            else price_weekends = newprice_weekends;
            if (newprice_48h < price_weekends) throw new Exception("Preis für 48h muss größer sein als Wochenendpreis");
            else price_48h = newprice_48h;
            if (newweight < 0) throw new Exception("Gewicht darf nicht negativ sein. Fragen Sie Isaac Newton um Hilfe.");
        }
    }
}

