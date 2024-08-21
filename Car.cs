﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLab
{
    internal class Car
    {
        //properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        //Constructor
        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;

        }

        public Car(string _make,string _model,int _year,decimal _price)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Price = _price;
        }

        public override string ToString()
        {
            return $"{Make}\t{Model}\t{Year}\t{Price}";
        }

    }
}
