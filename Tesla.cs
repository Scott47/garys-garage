using System;

namespace Garage
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine("Zip musk, zip musk, crash..");
        }
        public override void Turn(string direction)
        {
            base.Turn(direction);
            Console.WriteLine("and the car behind it is visibly annoyed.");
        }
        public override void Stop()
        {
            Console.WriteLine("The Tesla stopped in the middle of the street. We got out and left it there.");
        }

    }
}

