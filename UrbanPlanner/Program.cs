using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building highRise = new Building("500 Sixth Avenue");
            highRise.Width = 34.5;
            highRise.Depth = 40.0;
            highRise.Stories = 30;
            highRise.Construct();
            highRise.Purchase("The Coopers");

            Building offices = new Building("1200 Woodland Street");
            offices.Width = 25.75;
            offices.Depth = 50.0;
            offices.Stories = 3;
            offices.Construct();

            City metroplex = new City("Dallas-Fort Worth");
            metroplex.AddBuilding(highRise);
            metroplex.AddBuilding(offices);

            foreach (Building building in metroplex.Buildings)
            {
                building.Print();
            }
        }
    }

}
