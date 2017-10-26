﻿using DataTransformation.Interfaces;
using MVVMStarterDemoA.DataTransformations.Domain.Car;
using ViewModel.Implementation;

namespace MVVMStarterDemoA.ViewModels.Domain.Car
{
    public class ViewModelFactory : ViewModelFactoryBase<CarViewModel>
    {
        public override ITransformedDataWrapper CreateDetailsViewModel(ITransformedData obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ITransformedDataWrapper CreateItemViewModel(ITransformedData obj)
        {
            return new ItemViewModel(obj);
        }
    }
}