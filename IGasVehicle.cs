
namespace Garage
{
    public interface IGas
    {
        double CurrentTankPercentage { get; set; }

        void RefuelTank();
    }
}

