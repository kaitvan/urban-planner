using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class City
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public int Established { get; set; }
        public List<Building> Buildings { get; set; } = new List<Building>();

        public City(string name)
        {
            Name = name;
        }

        public void AddBuilding(Building building) => Buildings.Add(building);

    }
}
