using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumOfWheels { get; set; }
        public bool TakesDiesel { get; set; }
        public int NumberOfDoors { get; set; }
        public string VehModel { get; set; }

    }
}

 