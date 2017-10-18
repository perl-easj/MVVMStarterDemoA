using System;
using MVVMStarterDemoA.Models.Base;

namespace MVVMStarterDemoA.Models.Domain.Employee
{
    public class Employee : PersonBase
    {
        private string _title;
        private DateTimeOffset _employedDate;
        private static Sale.SaleCatalog _saleCatalog;

        public Employee(int key, int imageKey, string fullName, string phone, string email, string title, DateTimeOffset employedDate)
            : base(key, imageKey, fullName, phone, email)
        {
            _title = title;
            _employedDate = employedDate;
            _saleCatalog = Sale.SaleCatalog.Instance;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int CarsSold
        {
            get { return _saleCatalog.CarsSoldByEmployee(Key); }
        }

        public DateTimeOffset EmployedDate
        {
            get { return _employedDate; }
            set { _employedDate = value; }
        }
    }
}