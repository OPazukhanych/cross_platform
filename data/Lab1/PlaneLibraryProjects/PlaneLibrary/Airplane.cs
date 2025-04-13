namespace PlaneLibrary
{
    public class Airplane
    {
        public string Type { get; private set; }
        public string FlightNumber { get; private set; }
        public double WingSpan { get; private set; }
        public string Company { get; private set; }
        public double MaxAltitude { get; private set; }
        public double MaxSpeed { get; private set; }
        public double CurrentSpeed { get; private set; }

        public Airplane(string type, string flightNumber, double wingSpan, string company, double maxAltitude, double maxSpeed)
        {
            Type = type;
            FlightNumber = flightNumber;
            WingSpan = wingSpan;
            Company = company;
            MaxAltitude = maxAltitude;
            MaxSpeed = maxSpeed;
            CurrentSpeed = 0;
        }

        public void ChangeSpeed(double delta)
        {
            double newSpeed = CurrentSpeed + delta;
            if (newSpeed < 0)
                CurrentSpeed = 0;
            else if (newSpeed > MaxSpeed)
                CurrentSpeed = MaxSpeed;
            else
                CurrentSpeed = newSpeed;
        }

        public double GetCurrentSpeed()
        {
            return CurrentSpeed;
        }

        public override string ToString()
        {
            return $"{Type} ({FlightNumber}) by {Company} | Max Speed: {MaxSpeed} km/h, Max Altitude: {MaxAltitude} m";
        }
    }

    public class PassengerAirplane : Airplane
    {
        public int PassengerCapacity { get; private set; }

        public PassengerAirplane(string type, string flightNumber, double wingSpan, string company, double maxAltitude, double maxSpeed, int passengerCapacity)
            : base(type, flightNumber, wingSpan, company, maxAltitude, maxSpeed)
        {
            PassengerCapacity = passengerCapacity;
        }

        public override string ToString()
        {
            return base.ToString() + $", Passenger Capacity: {PassengerCapacity} passengers";
        }
    }

    public class CargoAirplane : Airplane
    {
        public double CargoCapacity { get; private set; }

        public CargoAirplane(string type, string flightNumber, double wingSpan, string company, double maxAltitude, double maxSpeed, double cargoCapacity)
            : base(type, flightNumber, wingSpan, company, maxAltitude, maxSpeed)
        {
            CargoCapacity = cargoCapacity;
        }

        public override string ToString()
        {
            return base.ToString() + $", Cargo Capacity: {CargoCapacity} kg";
        }
    }
}