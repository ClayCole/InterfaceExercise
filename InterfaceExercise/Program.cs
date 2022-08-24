using System;
using System.Collections.Generic;
using static InterfaceExercise.Interfaces;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var suv = new SUV();
            var truck = new Truck();

            List<IVehicle> vehicles = new List<IVehicle>();

            vehicles.Add(car);
            vehicles.Add(suv);
            vehicles.Add(truck);

            foreach(var item in vehicles)
            {
                Console.WriteLine($" this vehicle has {item.Wheels}, {item.Windows}, {item.HasHeadLights} ");


            }

        }
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces


        //Create 3 classes called Car , Truck , & SUV

      

        List<IVehicle> vehicles = new List<IVehicle>();

        
        
  


        

        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */

        //Now, create objects of your 3 classes and give their members values;
        //Creatively display and organize their values

    }
}
