using System.Collections.Generic;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoA.DataTransformations.Domain.Car;
using MVVMStarterDemoA.Models.App;

namespace MVVMStarterDemoA.ViewModels.Domain.Car
{
    public class MasterDetailsViewModel : MasterDetailsViewModelCRUD<Models.Domain.Car.Car, CarViewModel, Models.Domain.Car.Car>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), 
                   ObjectProvider.CarCatalog,
                   new List<string> { "Plate", "Model", "Brand", "Year" },
                   new List<string> { "CCM", "HK", "Seats", "Price", "Image" })
        {
        }
    }
}