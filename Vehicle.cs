﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    internal abstract class Vehicle : ISellable
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Store { get; set; }
        public int Warranty { get; set; }

        public abstract string Operate();

        public string MakeSale()
        {
            return "This is how we make a sale!";
        }

        public abstract double CalculateInterest();

        public Vehicle(string name, string brand, double price, int warranty, string store)
        {
            Name = name;
            Brand = brand;
            Price = price;
            Store = store;
            Warranty = warranty;
        }
    }
}
