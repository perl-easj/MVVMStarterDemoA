using System.Collections.Generic;
using Data.Transformed.Interfaces;
using MVVMStarterDemoA.Data.Domain;
using MVVMStarterDemoA.Models.App;
using MVVMStarterDemoA.ViewModels.Base;
using MVVMStarterDemoA.ViewModels.Data;

namespace MVVMStarterDemoA.ViewModels.Page
{
    public class SalePageViewModel : PageViewModelAppBase<Sale>
    {
        public SalePageViewModel()
            : base(DomainModel.Catalogs.Sales,
                new List<string> { "Car", "Customer", "Employee" },
                new List<string> { "Date", "Price" })
        {
        }

        public override IDataWrapper<Sale> CreateDataViewModel(Sale obj)
        {
            return new SaleDataViewModel(obj);
        }
    }
}