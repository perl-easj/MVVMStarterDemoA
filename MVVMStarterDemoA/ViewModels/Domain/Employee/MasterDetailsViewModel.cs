using System.Collections.Generic;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoA.Models.App;

namespace MVVMStarterDemoA.ViewModels.Domain.Employee
{
    public class MasterDetailsViewModel : MasterDetailsViewModelDefault<Models.Domain.Employee.Employee>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), ObjectProvider.EmployeeCatalog,
                new List<string> { "Name", "CarsSold" },
                new List<string> { "Image", "Title", "Phone", "Email", "Employed" })
        {
        }
    }
}