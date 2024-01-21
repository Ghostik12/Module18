using System;

namespace Module18
{
    class Program
    {
        static void Main(string[] args)
        {
            CarPlant carPlant = new CarPlant();

            Conveyor carConveyor = new CarConveyor();
            carPlant.Construct(carConveyor);
            carConveyor.Product.Show();
        }
    }
}