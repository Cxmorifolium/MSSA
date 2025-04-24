using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace assignment3_4
{
    internal class Coffee : Beverage
    {
        public bool IsDecaf { get; set; }
        public string Variety { get; set; }
        public Roast RoastLevel { get; set; }

        public string Decaf { get; set; }

        public enum Roast { Light, Medium, Dark, None }

        // Constructor
        public Coffee(string bevName, double price, bool isDecaf, string variety, Roast roastLevel, bool temperature, string brand)
        {
            BevName = bevName;
            Price = price;
            IsDecaf = isDecaf;
            Variety = variety;
            RoastLevel = roastLevel;
            Temperature = temperature;
            Brand = brand;
            Decaf = isDecaf ? "Yes" : "No"; ;
        }
    }

}
