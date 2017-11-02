using System.Collections.Generic;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoA.DataTransformations.Domain.Sale;
using MVVMStarterDemoA.Models.App;

namespace MVVMStarterDemoA.ViewModels.Domain.Sale
{
    public class MasterDetailsViewModel : MasterDetailsViewModelCRUD<Models.Domain.Sale.Sale, SaleViewModel, Models.Domain.Sale.Sale>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), ObjectProvider.SaleCatalog,
                new List<string> { "Car", "Customer", "Employee" },
                new List<string> { "Date", "Price" })
        {
        }
    }
}