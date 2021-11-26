using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram trx1500 = new Ram();

            List<IElectric> electricVehicles = new List<IElectric>()
            {
                fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"Current Charge: {ev.CurrentChargePercentage}%");
            }

            foreach (IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($" You vehicle is {ev.CurrentChargePercentage}% charged.");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGas> gasVehicles = new List<IGas>()
            {
                ram, trx1500, cessna150
              };

            Console.WriteLine("Gas Vehicles");
            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"Current Tank Level: {gv.CurrentTankPercentage}%");
            }

            foreach (IGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"You vehicle's gas tank is {gv.CurrentTankPercentage}% full.");
            }


            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            trx1500.Drive();

            fxs.Turn("left");
            modelS.Turn("right");
            mx410.Turn("left");
            trx1500.Turn("left");

            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            trx1500.Stop();
        }
    }

}
