using MVVMStarterDemoA.Models.Base;

namespace MVVMStarterDemoA.Models.Domain.Customer
{
    public class Customer : PersonBase
    {
        private string _address;
        private int _zipCode;
        private string _city;
        private int _minPrice;
        private int _maxPrice;
        private bool _newsLetter;

        public Customer(int key, int imageKey, string fullName, string phone, string email, string address, int zipCode, string city, int minPrice, int maxPrice, bool newsLetter)
            : base(key, imageKey, fullName, phone, email)
        {
            _address = address;
            _zipCode = zipCode;
            _city = city;
            _minPrice = minPrice;
            _maxPrice = maxPrice;
            _newsLetter = newsLetter;
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
    }
}
