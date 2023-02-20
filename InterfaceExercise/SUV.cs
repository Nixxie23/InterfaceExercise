using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public double CargoDimensionInFeet { get; set; }
        public int RowsOfSeats { get; set; }
        public int NumOfWheels {get; set; }
        public bool TakesDiesel {get; set; }
        public int NumberOfDoors { get; set; }
        public string VehModel { get; set; }  
        public string CompanyName { get; set; }
        public bool USABased { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"This SUV is a {CompanyName} {VehModel}. The cargo space is {CargoDimensionInFeet} cubic feet. " +
                $"Below find more facts about this SUV.");
            Console.WriteLine($"SUV takes diesel = {TakesDiesel}");
            Console.WriteLine($"SUV was made in the USA = {USABased}");
            Console.WriteLine($"SUV has {RowsOfSeats} rows of seats.");
            Console.WriteLine($"SUV has {NumberOfDoors} doors.");
            Console.WriteLine($"SUV has {NumOfWheels} wheels.");
        }
    }
}
