using System;
using InMemoryStorage.Implementation;

namespace MVVMStarterDemoA.Models.Domain.Sale
{
    public class Sale : StorableBase
    {
        private int _carKey;
        private int _customerKey;
        private int _employeeKey;

        private DateTimeOffset _salesDate;
        private int _finalPrice;

        public Sale(int key, int carKey, int customerKey, int employeeKey, DateTimeOffset salesDate, int finalPrice)
            : base(key)
        {
            _carKey = carKey;
            _customerKey = customerKey;
            _employeeKey = employeeKey;

            _salesDate = salesDate;
            _finalPrice = finalPrice;
        }

        public int CarKey
        {
            get { return _carKey; }
            set { _carKey = value; }
        }

        public int CustomerKey
        {
            get { return _customerKey; }
            set { _customerKey = value; }
        }

        public int EmployeeKey
        {
            get { return _employeeKey; }
            set { _employeeKey = value; }
        }

        public DateTimeOffset SalesDate
        {
            get { return _salesDate; }
            set { _salesDate = value; }
        }

        public int FinalPrice
        {
            get { return _finalPrice; }
            set { _finalPrice = value; }
        }
    }
}