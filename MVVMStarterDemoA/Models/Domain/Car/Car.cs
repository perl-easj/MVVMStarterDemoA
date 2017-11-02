using MVVMStarterDemoA.Models.Base;

namespace MVVMStarterDemoA.Models.Domain.Car
{
    public class Car : DomainBaseWithImage<Car>
    {
        public Car(int key, int imageKey, string licensePlate, string brand, string model, int year, int engineSizeCm3,
            int horsePower, int seats, int price)
            : base(key, imageKey)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Model = model;
            Year = year;
            EngineSizeCm3 = engineSizeCm3;
            HorsePower = horsePower;
            Seats = seats;
            Price = price;
        }

        public Car() : base(NullKey, NullKey)
        {
        }

        public string LicensePlate { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int EngineSizeCm3 { get; set; }

        public int HorsePower { get; set; }

        public int Seats { get; set; }

        public int Price { get; set; }
    }
}