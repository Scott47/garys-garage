using System;

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
