using DataTransformation.Interfaces;
using MVVMStarterDemoA.DataTransformations.Domain.Employee;
using ViewModel.Implementation;

namespace MVVMStarterDemoA.ViewModels.Domain.Employee
{
    public class ViewModelFactory : ViewModelFactoryBase<EmployeeViewModel>
    {
        public override ITransformedDataWrapper CreateDetailsViewModel(ITransformedData obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ITransformedDataWrapper CreateItemViewModel(ITransformedData obj)
        {
            return new ItemViewModel(obj);
        }
    }
}