using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vroom...");
        }
        public virtual void Turn(string direction)
        {
            Console.Write($"This vehicle is turning {direction} ");
        }
        public virtual void Stop()
        {
            Console.Write("This vehicle has stopped.");
        }
    }
}
