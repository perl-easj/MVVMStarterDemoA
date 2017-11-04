using MVVMStarterDemoA.Models.Base;

namespace MVVMStarterDemoA.Models.Domain.Customer
{
    public class Customer : PersonBase<Customer>
    {
        public Customer(int key, int imageKey, string fullName, string phone, string email, string address, int zipCode, string city, int minPrice, int maxPrice, bool newsLetter)
            : base(key, imageKey, fullName, phone, email)
        {
            Address = address;
            ZipCode = zipCode;
            City = city;
            MinPrice = minPrice;
            MaxPrice = maxPrice;
            NewsLetter = newsLetter;
        }

        public Customer() : base(NullKey, NullKey, "", "", "")
        {
        }

        public string Address { get; set; }

        public int ZipCode { get; set; }

        public string City { get; set; }

        public int MinPrice { get; set; }

        public int MaxPrice { get; set; }

        public bool NewsLetter { get; set; }

        public override void SetValuesFromObject(Customer obj)
        {
            Key = obj.Key;
            ImageKey = obj.ImageKey;
            Address = obj.Address;
            ZipCode = obj.ZipCode;
            City = obj.City;
            MinPrice = obj.MinPrice;
            MaxPrice = obj.MaxPrice;
            NewsLetter = obj.NewsLetter;
        }
    }
}
