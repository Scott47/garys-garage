using System;

namespace Garage
{
    public interface IElectric
    {
        double CurrentChargePercentage { get; set; }
        void ChargeBattery();
    }
}