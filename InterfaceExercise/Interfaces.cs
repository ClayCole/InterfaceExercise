using System;
namespace InterfaceExercise
{
    public class Interfaces
    {
        public Interfaces()
        {
        }

        //Create 2 Interfaces called IVehicle & ICompany
        public interface IVehicle
        {

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */

            int Wheels { get; set; }
            int Windows { get; set; }
            int HorsePower { get; set; }
            bool HasHeadLights { get; set; }


        }

        public interface ICompany
        {
            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */
            public string Logo { set; get; }
            public bool HasCommericals { get; set; }

        }
    }
}

