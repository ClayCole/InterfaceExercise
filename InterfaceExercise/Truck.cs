using System;
using static InterfaceExercise.Interfaces;

namespace InterfaceExercise
{
    class Truck : ICompany, IVehicle
    {
        string BedSize { get; set; }
        int NumberOfDoors { get; set; }

        int IVehicle.Wheels { get; set; } = 6;
        int IVehicle.Windows { get; set; } = 4;
        int IVehicle.HorsePower { get; set; } = 250;
        bool IVehicle.HasHeadLights { get; set; } = true;

        public string Logo { set; get; } = "F150";
        public bool HasCommericals { get; set; } = true;

    }
}

