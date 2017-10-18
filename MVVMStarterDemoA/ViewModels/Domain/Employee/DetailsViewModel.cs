﻿using System;
using DTO.Interfaces;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoA.Models.Domain.Employee;

namespace MVVMStarterDemoA.ViewModels.Domain.Employee
{
    public class DetailsViewModel : DetailsViewModelWithSelectableImage<EmployeeDTO>
    {
        public string Name
        {
            get { return TypedDataObject.FullName; }
            set
            {
                TypedDataObject.FullName = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get { return TypedDataObject.Title; }
            set
            {
                TypedDataObject.Title = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get { return TypedDataObject.Phone; }
            set
            {
                TypedDataObject.Phone = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return TypedDataObject.Email; }
            set
            {
                TypedDataObject.Email = value;
                OnPropertyChanged();
            }
        }

        public int CarsSold
        {
            get { return TypedDataObject.CarsSold; }
        }

        public DateTimeOffset Employed
        {
            get { return TypedDataObject.EmployedDate; }
            set
            {
                TypedDataObject.EmployedDate = value;
                OnPropertyChanged();
            }
        }

        public override int ImageKey
        {
            get { return TypedDataObject.ImageKey; }
            set
            {
                TypedDataObject.ImageKey = value;
                OnPropertyChanged();
            }
        }

        public DetailsViewModel(IDTO obj) : base(obj, "Employee")
        {
        }
    }
}