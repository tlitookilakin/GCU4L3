namespace CarLab;

class Program
{
    static void Main(string[] args)
    {
        Car.cars.Add(new Car("Toyota", "Prius", 2020, 2000m));
        Car.cars.Add(new Car("Tesla", "Cybertruck", 2024, 500000m));
        Car.cars.Add(new Car("Honda", "Accord", 2021, 35000m));
        Car.cars.Add(new UsedCar("Toyota", "Prius", 2010, 13000m, 150_000.0));
        Car.cars.Add(new UsedCar("Tesla", "Cybertruck", 2023, 100_000m, 0.0));
        Car.cars.Add(new UsedCar("Honda", "CRV", 2020, 15_000m, 30_000.0));
        Car.cars.Add(new Car("Honda", "CBR650R", 2024, 10_000m));

        Car.ListCars();
    }
}
