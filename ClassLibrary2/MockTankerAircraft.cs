using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneProject
{    public class MockTankerAircraft : ITankerAircraft
     {
        double RequestFuelResult;
        double FuelTankCapacity;
        double Fuel;
        public MockTankerAircraft(double fuelTankCapacity)
        {
            RequestFuelResult = 0;
            FuelTankCapacity = fuelTankCapacity;
            Fuel = fuelTankCapacity;
        }
        public double RequestFuel(double amount)
        {
            if (amount <= Fuel)
            {
                RequestFuelResult = amount;
                Fuel -= amount;
            }
            if (amount > Fuel)
            {
                RequestFuelResult = 0;
                Fuel = 0; 
            }
            return RequestFuelResult;
        }
        public double GetFuelTankCapacity()
        {
            return this.FuelTankCapacity;
        }
        public double GetFuelResult()
        {
            return this.RequestFuelResult;
        }
        public double GetFuel() 
        {
            return this.Fuel;
        }
        
    }
}
