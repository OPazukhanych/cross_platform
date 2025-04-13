using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlaneLibrary;

namespace PlaneTest
{
    [TestClass]
    public class AirplaneTests
    {
        [TestMethod]
        public void TestAirplaneInitialization()
        {
            // Arrange
            var airplane = new Airplane("Jet", "FL123", 35.0, "SkyWings", 12000, 900);

            // Assert
            Assert.AreEqual("Jet", airplane.Type);
            Assert.AreEqual("FL123", airplane.FlightNumber);
            Assert.AreEqual(35.0, airplane.WingSpan);
            Assert.AreEqual("SkyWings", airplane.Company);
            Assert.AreEqual(12000, airplane.MaxAltitude);
            Assert.AreEqual(900, airplane.MaxSpeed);
            Assert.AreEqual(0, airplane.GetCurrentSpeed());
        }

        [TestMethod]
        public void TestChangeSpeed()
        {
            // Arrange
            var airplane = new Airplane("Jet", "FL456", 28.5, "FlyNow", 11000, 850);

            // Act
            airplane.ChangeSpeed(400); // Should go to 400
            airplane.ChangeSpeed(600); // Should cap at 850 (max)
            airplane.ChangeSpeed(-900); // Should drop to 0, not below

            // Assert
            Assert.AreEqual(0, airplane.GetCurrentSpeed());
        }

        [TestMethod]
        public void TestPassengerAirplaneInitialization()
        {
            // Arrange
            var passenger = new PassengerAirplane("Passenger", "PS101", 36.0, "AirJet", 11500, 880, 200);

            // Assert
            Assert.AreEqual("Passenger", passenger.Type);
            Assert.AreEqual("PS101", passenger.FlightNumber);
            Assert.AreEqual(200, passenger.PassengerCapacity);
        }

        [TestMethod]
        public void TestCargoAirplaneInitialization()
        {
            // Arrange
            var cargo = new CargoAirplane("Cargo", "CG202", 42.5, "CargoFly", 9500, 800, 30000);

            // Assert
            Assert.AreEqual("Cargo", cargo.Type);
            Assert.AreEqual("CG202", cargo.FlightNumber);
            Assert.AreEqual(30000, cargo.CargoCapacity);
        }
    }
}
