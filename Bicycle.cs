using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    internal class Bicycle : Vehicle
    {
        public string Terrain { get; set; }
        public int TireSize { get; set;}

        public Bicycle(string name, string brand, double price, int warranty, string store, int tireSize, string terrain):base(name, brand, price, warranty, store)
        {
            TireSize = tireSize;
            Terrain = terrain;
        }

        public override string Operate()
        {
            return "You need to pedal!";
        }

        public override double CalculateInterest()
        {
            return Price*0.1;
        }
    }
}
