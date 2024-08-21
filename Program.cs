using System.Security.Cryptography.X509Certificates;

namespace CarLab;

class Program
{
    static void Main(string[] args)
    {;
        Car.cars.Add(new Car("Toyota", "Prius", 2020, 2000m));
        Car.cars.Add(new Car("Tesla", "Cybertruck", 2024, 500000m));
        Car.cars.Add(new Car("Honda", "Accord", 2021, 35000m));


    }
}
