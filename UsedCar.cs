namespace CarLab
{
    internal class UsedCar : Car
    {
        public double Mileage { get; set; }
        public UsedCar(string make, string model, int year, decimal price, double mileage) : 
            base(make, model, year, price)  
        {
            Mileage = mileage;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\t{Mileage}";
        }
    }
}
