using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3_4
{
    internal class Beverage
    {
        public enum NutritionalContent
        {
            Calories, Fat, Carbs, Protein
        }

        public string BevName { get; set; }
        public int TemperatureDegF {  get; set; }
        public double Price { get; set; }
        public  NutritionalContent Macros { get; set; }
        public string PackageType { get; set; }
        public double SizeOz { get; set; }
        public DateTime ExpirationDate { get; set; }


    }
}
