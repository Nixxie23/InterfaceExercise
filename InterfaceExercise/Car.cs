using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public double TrunkDimensionInFeet { get; set; }
        public bool HasFourWheelDrive { get; set; }
        public int NumOfWheels { get; set; }
        public bool TakesDiesel { get; set; }
        public int NumberOfDoors { get; set; }
        public string VehModel { get; set; }
        public string CompanyName { get; set; }
        public bool USABased { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"This car is a {CompanyName} {VehModel}. The trunk is {TrunkDimensionInFeet} cubic feet. " +
                $"Below find more facts about this car.");
            Console.WriteLine($"Car takes diesel = {TakesDiesel}");
            Console.WriteLine($"Car was made in the USA = {USABased}");
            Console.WriteLine($"Car has four-wheel drive = {HasFourWheelDrive}");
            Console.WriteLine($"Car has {NumberOfDoors} doors.");
            Console.WriteLine($"Car has {NumOfWheels} wheels.");
        }
        }
}
