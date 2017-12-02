using System.Collections.Generic;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoA.DataTransformations.Domain.Employee;
using MVVMStarterDemoA.Models.App;

namespace MVVMStarterDemoA.ViewModels.Domain.Employee
{
    public class MasterDetailsViewModel : MasterDetailsViewModelCRUD<EmployeeVMO>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), ObjectProvider.EmployeeCatalog,
                new List<string> { "Name", "CarsSold" },
                new List<string> { "Image", "Title", "Phone", "Email", "Employed" })
        {
        }
    }
}