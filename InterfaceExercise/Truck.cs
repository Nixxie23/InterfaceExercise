using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public double BedLengthInFeet { get; set; }
        public bool HasTowHitch { get; set; }
        public int NumOfWheels { get; set; }
        public bool TakesDiesel { get; set; }
        public int NumberOfDoors { get; set; }
        public string VehModel { get; set; }
        public string CompanyName { get; set; }
        public bool USABased { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"This truck is a {CompanyName} {VehModel}. The bed is {BedLengthInFeet} ft long. " +
                $"Below find more facts about this truck.");

            Console.WriteLine($"Truck has a tow hitch = {HasTowHitch}.");
            Console.WriteLine($"Truck takes diesel = {TakesDiesel}");
            Console.WriteLine($"Truck was made in the USA = {USABased}");
            Console.WriteLine($"Truck has {NumOfWheels} wheels.");
            Console.WriteLine($"Truck has {NumberOfDoors} doors.");
        }
    }
}
