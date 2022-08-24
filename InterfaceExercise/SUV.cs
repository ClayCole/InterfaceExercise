using System;
using static InterfaceExercise.Interfaces;

namespace InterfaceExercise
{
    class SUV : ICompany, IVehicle
    {
        string CargoSize { get; set; }
        bool CargoFootSensor { get; set; }

        int IVehicle.Wheels { get; set; } = 4;
        int IVehicle.Windows { get; set; } = 6;
        int IVehicle.HorsePower { get; set; } = 125;
        bool IVehicle.HasHeadLights { get; set; } = true;

        public string Logo { set; get; } = "BMW";
        public bool HasCommericals { get; set; } = true;
    }
}

