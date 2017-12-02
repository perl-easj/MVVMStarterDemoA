﻿using DataTransformation.Interfaces;
using MVVMStarterDemoA.DataTransformations.Domain.Car;
using ViewModel.Implementation;

namespace MVVMStarterDemoA.ViewModels.Domain.Car
{
    public class ViewModelFactory : ViewModelFactoryBase<CarVMO>
    {
        public override IDataWrapper<CarVMO> CreateDetailsViewModel(CarVMO obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDataWrapper<CarVMO> CreateItemViewModel(CarVMO obj)
        {
            return new ItemViewModel(obj);
        }
    }
}