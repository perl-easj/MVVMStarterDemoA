using ExtensionsModel.Implementation;

namespace MVVMStarterDemoA.Models.Domain.Car
{
    public class Car : ClassWithImage
    {
        private string _licensePlate;
        private string _brand;
        private string _model;
        private int _year;
        private int _engineSizeCm3;
        private int _horsePower;
        private int _seats;
        private int _price;

        public Car(int key, int imageKey, string licensePlate, string brand, string model, int year, int engineSizeCm3,
            int horsePower, int seats, int price)
            : base(key, imageKey)
        {
            _licensePlate = licensePlate;
            _brand = brand;
            _model = model;
            _year = year;
            _engineSizeCm3 = engineSizeCm3;
            _horsePower = horsePower;
            _seats = seats;
            _price = price;
        }

        public string LicensePlate
        {
            get { return _licensePlate; }
        }

        public string Brand
        {
            get { return _brand; }
        }

        public string Model
        {
            get { return _model; }
        }

        public int Year
        {
            get { return _year; }
        }

        public int EngineSizeCm3
        {
            get { return _engineSizeCm3; }
            set { _engineSizeCm3 = value; }
        }

        public int HorsePower
        {
            get { return _horsePower; }
            set { _horsePower = value; }
        }

        public int Seats
        {
            get { return _seats; }
            set { _seats = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}