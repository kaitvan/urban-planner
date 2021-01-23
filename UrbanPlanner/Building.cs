using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class Building
    {
        private string _designer = "Kaitlyn";
        private DateTime _dateConstructed = new DateTime(1990, 7, 11);
        private string _address = "37 5th Avenue";
        private string _owner = "Warren Buffett";

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public double Volume => Width * Depth * (3 * Stories);

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string owner)
        {
            _owner = owner;
        }

        public void Print()
        {
            Console.WriteLine(_address);
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
            Console.WriteLine();
        }
    }
}
