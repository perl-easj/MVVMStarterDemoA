﻿using DataTransformation.Interfaces;
using MVVMStarterDemoA.DataTransformations.Domain.Sale;
using ViewModel.Implementation;

namespace MVVMStarterDemoA.ViewModels.Domain.Sale
{
    public class ViewModelFactory : ViewModelFactoryBase<Models.Domain.Sale.Sale, SaleViewModel>
    {
        public override IDataWrapper<SaleViewModel> CreateDetailsViewModel(SaleViewModel obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDataWrapper<SaleViewModel> CreateItemViewModel(SaleViewModel obj)
        {
            return new ItemViewModel(obj);
        }
    }
}