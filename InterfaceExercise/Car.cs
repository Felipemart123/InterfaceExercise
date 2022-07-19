using System;
namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public Car()
        {
        }

        bool IVehicle.HasEngine { get; set; } = true;
        int IVehicle.HowManyWheels { get; set; } = 4;
        int IVehicle.HowManyDoors { get; set; } = 4;
        int IVehicle.DoesDriveFast { get; set; } = 22;
        bool ICompany.HasLogo { get; set; } = true;
        string ICompany.Name { get; set; } = "KIA";



        public void Drive()
        {
            Console.WriteLine($" {GetType().Name} Drive forward");
        }

        public void Park()
        {
            Console.WriteLine($"{GetType().Name} parks the car");
        }

        public void Reverse()
        {
            Console.WriteLine($" {GetType().Name} drive backwards");
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
