﻿using System;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoA.DataTransformations.Domain.Employee;

namespace MVVMStarterDemoA.ViewModels.Domain.Employee
{
    public class DetailsViewModel : DetailsViewModelWithSelectableImage<EmployeeViewModel>
    {
        public string Name
        {
            get { return DataObject.FullName; }
            set
            {
                DataObject.FullName = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get { return DataObject.Title; }
            set
            {
                DataObject.Title = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get { return DataObject.Phone; }
            set
            {
                DataObject.Phone = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return DataObject.Email; }
            set
            {
                DataObject.Email = value;
                OnPropertyChanged();
            }
        }

        public int CarsSold
        {
            get { return DataObject.CarsSold; }
        }

        public DateTimeOffset Employed
        {
            get { return DataObject.EmployedDate; }
            set
            {
                DataObject.EmployedDate = value;
                OnPropertyChanged();
            }
        }

        public override int ImageKey
        {
            get { return DataObject.ImageKey; }
            set
            {
                DataObject.ImageKey = value;
                OnPropertyChanged();
            }
        }

        public DetailsViewModel(EmployeeViewModel obj) : base(obj, "Employee")
        {
        }
    }
}