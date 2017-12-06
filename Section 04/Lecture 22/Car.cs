using System;

namespace Lecture22
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized.");
        }
    }
}