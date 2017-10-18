using System;
using DTO.Implementation;

namespace MVVMStarterDemoA.Models.Domain.Customer
{
    public class CustomerDTO : DTOBase
    {
        private string _fullName;
        private string _phone;
        private string _email;
        private string _address;
        private int _zipCode;
        private string _city;
        private int _minPrice;
        private int _maxPrice;
        private bool _newsLetter;
        private int _imageKey;

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public int MinPrice
        {
            get { return _minPrice; }
            set { _minPrice = value; }
        }

        public int MaxPrice
        {
            get { return _maxPrice; }
            set { _maxPrice = value; }
        }

        public bool NewsLetter
        {
            get { return _newsLetter; }
            set { _newsLetter = value; }
        }

        public int ImageKey
        {
            get { return _imageKey; }
            set { _imageKey = value; }
        }

        public override void SetDefaultValues()
        {
            Key = NullKey;
            _fullName = "(not set)";
            _phone = "(not set)";
            _email = "(not set)";
            _address = "(not set)";
            _zipCode = 0;
            _city = "(not set)";
            _minPrice = 0;
            _maxPrice = 0;
            _newsLetter = false;
            _imageKey = NullKey;
        }

        public override void SetValuesFromObject(Object obj)
        {
            Customer customerObj = (obj as Customer);
            if (customerObj == null)
            {
                throw new ArgumentException(nameof(SetValuesFromObject));
            }

            Key = customerObj.Key;
            _fullName = customerObj.FullName;
            _phone = customerObj.Phone;
            _email = customerObj.Email;
            _address = customerObj.Address;
            _zipCode = customerObj.ZipCode;
            _city = customerObj.City;
            _minPrice = customerObj.MinPrice;
            _maxPrice = customerObj.MaxPrice;
            _newsLetter = customerObj.NewsLetter;
            _imageKey = customerObj.ImageKey;
        }
    }
}