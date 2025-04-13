using PlaneLibrary;

class Program
{
    static void Main()
    {
        // Базовий літак
        Airplane airplane = new Airplane("General", "FL001", 28.5, "SkyFly", 11000, 850);
        Console.WriteLine(airplane);
        airplane.ChangeSpeed(300);
        Console.WriteLine($"Current Speed: {airplane.GetCurrentSpeed()} km/h\n");

        // Пасажирський літак
        PassengerAirplane passenger = new PassengerAirplane("Passenger", "PS101", 35.0, "AirWays", 12000, 900, 180);
        Console.WriteLine(passenger);
        passenger.ChangeSpeed(500);
        Console.WriteLine($"Current Speed: {passenger.GetCurrentSpeed()} km/h\n");

        // Транспортний літак
        CargoAirplane cargo = new CargoAirplane("Cargo", "CG999", 40.2, "CargoLine", 10000, 800, 25000);
        Console.WriteLine(cargo);
        cargo.ChangeSpeed(450);
        Console.WriteLine($"Current Speed: {cargo.GetCurrentSpeed()} km/h\n");
    }
}
