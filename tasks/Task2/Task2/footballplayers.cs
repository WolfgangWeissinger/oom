using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Erstellt neue Fussballerprofile
    /// </summary>
    class footballplayer
    {
        public string name;
        public string nationality;
        private int goals;


        public string defName
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }

        public footballplayer(string newname, string newnationality, int newgoals=0)
        {
            name = newname;
            nationality = newnationality;
            if (newgoals < 0) throw new Exception("Fehler. Negative Toranzahl");
            goals = newgoals;
        }
        
        public void UpdateGoals(int newgoals)
        {
            if (newgoals > goals) goals = newgoals;
            else throw new Exception();
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", this.name, this.nationality, this.goals);
        }
    }
}
    
        
        
        /*
        /// <summary>
        /// Updates Price of the book
        /// </summary>
        /// <param name="newPrice"></param>

        public void updatePrice(decimal newPrice, Currency newCurrency)
        {
            if (newPrice < 0) throw new Exception();
            price = newPrice;
            Currency = newCurrency;
        } */
    

