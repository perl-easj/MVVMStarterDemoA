using System;
using DTO.Implementation;
using MVVMStarterDemoA.Models.App;

namespace MVVMStarterDemoA.Models.Domain.Employee
{
    public class EmployeeDTO : DTOBase
    {
        private string _fullName;
        private string _phone;
        private string _email;
        private string _title;
        private DateTimeOffset _employedDate;
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

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public DateTimeOffset EmployedDate
        {
            get { return _employedDate; }
            set { _employedDate = value; }
        }

        public int ImageKey
        {
            get { return _imageKey; }
            set { _imageKey = value; }
        }

        public int CarsSold
        {
            get { return ObjectProvider.SaleCatalog.CarsSoldByEmployee(Key); }
        }

        public override void SetDefaultValues()
        {
            Key = NullKey;
            _fullName = "(not set)";
            _phone = "(not set)";
            _email = "(not set)";
            _title = "(not set)";
            _employedDate = DateTimeOffset.Now;
            _imageKey = NullKey;
        }

        public override void SetValuesFromObject(Object obj)
        {
            Employee employeeObj = (obj as Employee);
            if (employeeObj == null)
            {
                throw new ArgumentException(nameof(SetValuesFromObject));
            }

            Key = employeeObj.Key;
            _fullName = employeeObj.FullName;
            _phone = employeeObj.Phone;
            _email = employeeObj.Email;
            _title = employeeObj.Title;
            _employedDate = employeeObj.EmployedDate;
            _imageKey = employeeObj.ImageKey;
        }
    }
}