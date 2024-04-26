using System;
using NUnit.Framework;
namespace AirplaneProject
{
    [TestFixture]
    public class AirplaneTest
    {
        [Test]
        public static void TestRefuelUsingTankerAircraft()
        {
            Airplane plane = new Airplane(100, 1000.0, 100.0);
            MockTankerAircraft tanker = new MockTankerAircraft(800.0);
            double fuelBefore = plane.GetFuel();
            plane.Refuel(tanker);
            Assert.That(plane.GetFuel() - fuelBefore, Is.EqualTo(tanker.GetFuelResult()));
        }
        [Test]
        public static void TestTankerRefuel()
        {
            Airplane plane = new Airplane(100, 400.0, 100.0);
            MockTankerAircraft tanker = new MockTankerAircraft(1400.0);
            while (plane.GetAmount() < tanker.GetFuel())
            {
                double fuelBefore = plane.GetFuel();
                plane.Refuel(tanker);                
                Assert.That(plane.GetFuel() - fuelBefore, Is.EqualTo(tanker.GetFuelResult()));
                plane.Flight();
                Assert.That(plane.GetFuelTankCapacity() - plane.GetFuel(), Is.EqualTo(plane.GetAmount()));
            }
        }
    }
}