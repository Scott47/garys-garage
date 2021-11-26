using System;

namespace Garage
{
    public class Cessna : Vehicle, IGas // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public double CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine("chop chop chop...");
        }
        public override void Turn(string direction)
        {
            base.Turn(direction);
            Console.WriteLine("and looks like it might be nose-diving.");
        }

    }
}
