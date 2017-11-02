using DataTransformation.Interfaces;
using MVVMStarterDemoA.DataTransformations.Domain.Employee;
using ViewModel.Implementation;

namespace MVVMStarterDemoA.ViewModels.Domain.Employee
{
    public class ViewModelFactory : ViewModelFactoryBase<Models.Domain.Employee.Employee, EmployeeViewModel>
    {
        public override IDataWrapper<EmployeeViewModel> CreateDetailsViewModel(EmployeeViewModel obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDataWrapper<EmployeeViewModel> CreateItemViewModel(EmployeeViewModel obj)
        {
            return new ItemViewModel(obj);
        }
    }
}