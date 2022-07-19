using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle , ICompany
    {
        public SUV()
        {
        }

        bool IVehicle.HasEngine { get; set; } = true;
        int IVehicle.HowManyWheels { get; set; } = 6;
        int IVehicle.HowManyDoors { get; set; } = 6;
        int IVehicle.DoesDriveFast { get; set; } = 12;
        bool ICompany.HasLogo { get; set; } = true;
        string ICompany.Name { get; set; } = "Hummer";

        public void Drive()
        {
            Console.WriteLine($" {GetType().Name} Drive forward");
        }

        public void Park()
        {
            Console.WriteLine($" {GetType().Name} Park the car");
        }

        public void Reverse()
        {
            Console.WriteLine($" {GetType().Name} Drive backwards");
        }
    }
}



//In each of your car, truck, and suv classes

/*Create 2 members that are specific to each class
 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
 *
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
 * 
 */