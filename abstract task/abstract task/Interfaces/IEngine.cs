using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_task.Interfaces
{
    interface IEngine
    {
        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        public int CurrentOil { get; set; }
        public int FuelType { get; set; }
        public void LeftFuelAmount()
        {
            Console.WriteLine(TankSize-CurrentOil);
        }
    }
}
