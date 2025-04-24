using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3_4
{
    internal class Beverage
    {
        public string BevName { get; set; }
        public bool Temperature { get; set; }  // true = Hot, false = Cold
        public double Price { get; set; }
        public string Brand { get; set; }

        // Return Value for Bool
        public string TemperatureString
        {
            get { return Temperature ? "Hot" : "Cold"; }
        }
    }

}
