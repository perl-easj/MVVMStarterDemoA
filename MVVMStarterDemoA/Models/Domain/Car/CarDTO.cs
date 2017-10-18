using System;
using DTO.Implementation;

namespace MVVMStarterDemoA.Models.Domain.Car
{
    public class CarDTO : DTOBase
    {
        private string _licensePlate;
        private string _brand;
        private string _model;
        private int _year;
        private int _engineSizeCm3;
        private int _horsePower;
        private int _seats;
        private int _price;
        private int _imageKey;

        public string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
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

        public int ImageKey
        {
            get { return _imageKey; }
            set { _imageKey = value; }
        }

        public override void SetDefaultValues()
        {
            Key = NullKey;
            _licensePlate = "(not set)";
            _brand = "(not set)";
            _model = "(not set)";
            _year = 2000;
            _engineSizeCm3 = 0;
            _horsePower = 0;
            _seats = 0;
            _price = 0;
            _imageKey = NullKey;
        }

        public override void SetValuesFromObject(Object obj)
        {
            Car carObj = (obj as Car);
            if (carObj == null)
            {
                throw new ArgumentException(nameof(SetValuesFromObject));
            }

            Key = carObj.Key;
            _licensePlate = carObj.LicensePlate;
            _brand = carObj.Brand;
            _model = carObj.Model;
            _year = carObj.Year;
            _engineSizeCm3 = carObj.EngineSizeCm3;
            _horsePower = carObj.HorsePower;
            _seats = carObj.Seats;
            _price = carObj.Price;
            _imageKey = carObj.ImageKey;
        }
    }
}