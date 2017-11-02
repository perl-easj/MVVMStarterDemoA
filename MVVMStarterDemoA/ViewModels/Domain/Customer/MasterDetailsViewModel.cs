using System.Collections.Generic;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoA.DataTransformations.Domain.Customer;
using MVVMStarterDemoA.Models.App;

namespace MVVMStarterDemoA.ViewModels.Domain.Customer
{
    public class MasterDetailsViewModel : MasterDetailsViewModelCRUD<Models.Domain.Customer.Customer, CustomerViewModel, Models.Domain.Customer.Customer>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), ObjectProvider.CustomerCatalog,
                new List<string> { "Name" },
                new List<string> { "Image", "Address", "ZipCode", "City", "Phone", "Email", "MaxPrice", "MinPrice", "Newsletter" })
        {
        }
    }
}