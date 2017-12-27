using System.Collections.Generic;
using Data.Transformed.Interfaces;
using MVVMStarterDemoA.Data.Domain;
using MVVMStarterDemoA.Models.App;
using MVVMStarterDemoA.ViewModels.Base;
using MVVMStarterDemoA.ViewModels.Data;

namespace MVVMStarterDemoA.ViewModels.Page
{
    public class CarPageViewModel : PageViewModelAppBase<Car>
    {
        public CarPageViewModel()
            : base(DomainModel.Catalogs.Cars,
                new List<string> { "Plate", "Model", "Brand", "Year" },
                new List<string> { "CCM", "HK", "Seats", "Price", "Image" })
        {
        }

        public override IDataWrapper<Car> CreateDataViewModel(Car obj)
        {
            return new CarDataViewModel(obj);
        }
    }
}