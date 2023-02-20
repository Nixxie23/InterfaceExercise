using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces         

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car redCar = new Car()
            {
                CompanyName = "Toyota",
                USABased = false,
                NumOfWheels = 4,
                TakesDiesel = false,
                NumberOfDoors = 4,
                VehModel = "Camry",
                TrunkDimensionInFeet = 15.1,
                HasFourWheelDrive = true,
            };
            Truck blueTruck = new Truck()
            {
                CompanyName = "Ford",
                USABased = true,
                NumOfWheels = 4,
                TakesDiesel = false,
                NumberOfDoors = 2,
                VehModel = "F-150",
                BedLengthInFeet = 6.5,
                HasTowHitch = true,

            };
            SUV pinkSUV = new SUV()
            {
                CompanyName = "Kia",
                USABased = true,
                NumOfWheels = 4,
                TakesDiesel = false,
                NumberOfDoors = 4,
                VehModel = "Sorento",
                CargoDimensionInFeet = 45,
                RowsOfSeats = 3,
            };
            redCar.PrintInfo();
            blueTruck.PrintInfo();
            pinkSUV.PrintInfo();

        }
    }
}
