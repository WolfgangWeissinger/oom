using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// Erstellt neue Fussballerprofile
    /// </summary>
    class footballplayer
    {
        public string name;
        public string nationality;
        private int goals;
        private int yellowcards;
        private bool IsBanned = false;

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

        public footballplayer(string newname, string newnationality, int newgoals = 0)
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

    public interface Profile
    {
        /// <summary>
        /// Gets a description of the basic player information.
        /// </summary>
        string name { get; }

        /// <summary>
        /// Gets the item's price in the specified currency.
        /// </summary>
        decimal GetGoals(int goals);
    }



    class goalkeeper : footballplayer
    {
        private int height;

        /// <summary>
        /// Creates profile of a Goalkeeper.
        /// </summary>
        public goalkeeper(string newname, string newnationality, int newgoals = 0, int newheight)
        {
            name = newname;
            nationality = newnationality;
            if (newgoals < 0) throw new Exception("Fehler. Negative Toranzahl");
            goals = newgoals;
            if (height < 100) throw new Exception("Fehler. Tormann ist ein Zwerg");
            height = newheight;

        }

        /// <summary>
        /// Height of Goalkeeper.
        /// </summary>
        public decimal height { get; }



        /// <summary>
        /// If the Player receives the 5th yellow card, he gets suspended for one match
        /// </summary>
        public void Banned()
        {
            if (IsBanned == true) throw new Exception("Spieler ist bereits gesperrt");
            yellowcards++;
            if (yellowcards == 5) IsBanned = true;
        }

    }


}



