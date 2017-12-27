using System.Collections.Generic;
using Data.Transformed.Interfaces;
using MVVMStarterDemoA.Data.Domain;
using MVVMStarterDemoA.Models.App;
using MVVMStarterDemoA.ViewModels.Base;
using MVVMStarterDemoA.ViewModels.Data;

namespace MVVMStarterDemoA.ViewModels.Page
{
    public class EmployeePageViewModel : PageViewModelAppBase<Employee>
    {
        public EmployeePageViewModel()
            : base(DomainModel.Catalogs.Employees,
                new List<string> { "Name", "CarsSold" },
                new List<string> { "Image", "Title", "Phone", "Email", "Employed" })
        {
        }

        public override IDataWrapper<Employee> CreateDataViewModel(Employee obj)
        {
            return new EmployeeDataViewModel(obj);
        }
    }
}