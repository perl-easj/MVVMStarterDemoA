﻿using System;
using MVVMStarterDemoA.Models.Base;

namespace MVVMStarterDemoA.Models.Domain.Sale
{
    public class Sale : DomainBase<Sale>
    {
        public Sale(int key, int carKey, int customerKey, int employeeKey, DateTimeOffset salesDate, int finalPrice)
            : base(key)
        {
            CarKey = carKey;
            CustomerKey = customerKey;
            EmployeeKey = employeeKey;

            SalesDate = salesDate;
            FinalPrice = finalPrice;
        }

        public Sale() : base(NullKey)
        {
        }

        public int CarKey { get; set; }

        public int CustomerKey { get; set; }

        public int EmployeeKey { get; set; }

        public DateTimeOffset SalesDate { get; set; }

        public int FinalPrice { get; set; }

        public override void SetValuesFromObject(Sale obj)
        {
            Key = obj.Key;
            CarKey = obj.CarKey;
            CustomerKey = obj.CustomerKey;
            EmployeeKey = obj.EmployeeKey;
            SalesDate = obj.SalesDate;
            FinalPrice = obj.FinalPrice;
        }
    }
}