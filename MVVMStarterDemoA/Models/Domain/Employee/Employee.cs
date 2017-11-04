using System;
using MVVMStarterDemoA.Models.Base;
// ReSharper disable UnusedMember.Local

namespace MVVMStarterDemoA.Models.Domain.Employee
{
    public class Employee : PersonBase<Employee>
    {
        private static Sale.SaleCatalog _saleCatalog;

        public Employee(int key, int imageKey, string fullName, string phone, string email, string title, DateTimeOffset employedDate)
            : base(key, imageKey, fullName, phone, email)
        {
            Title = title;
            EmployedDate = employedDate;
            _saleCatalog = Sale.SaleCatalog.Instance;
        }

        public Employee() : base(NullKey, NullKey, "", "", "")
        {
        }

        public string Title { get; set; }

        public DateTimeOffset EmployedDate { get; set; }

        private int CarsSold
        {
            get { return _saleCatalog.CarsSoldByEmployee(Key); }
        }

        public override void SetValuesFromObject(Employee obj)
        {
            Key = obj.Key;
            ImageKey = obj.ImageKey;
            Title = obj.Title;
            EmployedDate = obj.EmployedDate;
            _saleCatalog = Sale.SaleCatalog.Instance;
        }
    }
}