using System;
using static InterfaceExercise.Interfaces;

namespace InterfaceExercise
{
    class Car : ICompany, IVehicle
    {
        string TrunkSize { get; set; }
        bool Convertible { get; set; }


        int IVehicle.Wheels { get; set; } = 4;
        int IVehicle.Windows { get; set; } = 4;
        int IVehicle.HorsePower { get; set; } = 180;
        bool IVehicle.HasHeadLights { get; set; } = true;

        public string Logo { set; get; } = "Mustang Horse";
        public bool HasCommericals { get; set; } = true;


    }
}

