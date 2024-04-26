using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneProject
{
    public class Airplane
    {
        private byte NumberOfSeats;
        private double FuelTankCapacity;
        private double Fuel;
        private double Amount;
        enum SeatsLimits
        {
            MIN = 10,
            MAX = 200,
        };
        enum FuelTankLimits
        {
            MIN = 300,
            MAX = 5000,
        };
        public Airplane(byte numberOfSeats, double fuelTankCapacity, double fuel)
        {
            this.NumberOfSeats = numberOfSeats;
            this.FuelTankCapacity = fuelTankCapacity;
            if (fuelTankCapacity < (double)FuelTankLimits.MIN || fuelTankCapacity > (double)FuelTankLimits.MAX)
            {
                throw new ArgumentOutOfRangeException("Fuel Tank Capacity out of range");
            }
            if (numberOfSeats < (byte)SeatsLimits.MIN || numberOfSeats > (byte)SeatsLimits.MAX)
            {
                throw new ArgumentOutOfRangeException("Seats number out of range");
            }
            this.Fuel = fuel;
            this.Amount = 0;
        }
        public void Refuel(double amountOfFuel)
        {
            if (amountOfFuel < 0)
            {
                throw new ArgumentException("NegativeFuelValue");
            }
            Fuel += amountOfFuel;
            if (Fuel > FuelTankCapacity)
            {
                Fuel = FuelTankCapacity;
            }
        }
        public void Refuel(MockTankerAircraft aircraft)
        {
            double amount = GetFuelTankCapacity() - GetFuel();
            Fuel += aircraft.RequestFuel(amount);
        }
        public void Flight()
        {
            Random rnd = new Random();
            if (Fuel >= rnd.Next(200, 300))
            {
                Fuel -= rnd.Next(200, 300);
            }
        }
        public double GetAmount()
        {
            this.Amount = GetFuelTankCapacity() - GetFuel();
            return this.Amount;
        }
        public double GetFuel() { return this.Fuel; }
        public double GetNumberOfSeats() { return this.NumberOfSeats; }
        public double GetNumberOfPassengers() { return 0; }
        public double GetNumberOfPilots() { return 0; }
        public double GetNumberOfStewardess() { return 15; }
        public double GetFuelTankCapacity() { return this.FuelTankCapacity; }
    }
}
