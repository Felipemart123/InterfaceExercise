using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public bool HasEngine { get; set; }
        public int  HowManyWheels { get; set; }
        public int HowManyDoors { get; set; }
        public int DoesDriveFast { get; set; }

        public void Drive();
        public void Park();
        public void Reverse();
        
    }
}

//In your IVehicle

/* Create 4 members that Car, Truck, & SUV all have in common.
 * Example: All vehicles have a number of wheels... for now..
 */
