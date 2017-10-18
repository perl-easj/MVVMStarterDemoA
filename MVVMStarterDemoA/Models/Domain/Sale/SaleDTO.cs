using System;
using DTO.Implementation;

namespace MVVMStarterDemoA.Models.Domain.Sale
{
    public class SaleDTO : DTOBase
    {
        private int _carKey;
        private int _customerKey;
        private int _employeeKey;

        private DateTimeOffset _salesDate;
        private int _finalPrice;

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

        public override void SetDefaultValues()
        {
            Key = NullKey;
            _carKey = NullKey;
            _customerKey = NullKey;
            _employeeKey = NullKey;

            _salesDate = DateTimeOffset.Now;
            _finalPrice = 0;
        }

        public override void SetValuesFromObject(Object obj)
        {
            Sale saleObj = (obj as Sale);
            if (saleObj == null)
            {
                throw new ArgumentException(nameof(SetValuesFromObject));
            }

            Key = saleObj.Key;
            _carKey = saleObj.CarKey;
            _customerKey = saleObj.CustomerKey;
            _employeeKey = saleObj.EmployeeKey;

            _salesDate = saleObj.SalesDate;
            _finalPrice = saleObj.FinalPrice;
        }
    }
}