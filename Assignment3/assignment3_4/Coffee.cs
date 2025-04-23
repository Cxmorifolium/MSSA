using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3_4
{
    internal class Coffee : Beverage
    {
        public enum Roast
        {
            light, medium, dark
        }

        public bool IsDecaf {  get; set; }
        public string Variety { get; set; }
        public Roast RoastLevel { get; set; }

    }
}
