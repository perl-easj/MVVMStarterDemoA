using ExtensionsViewModel.Implementation;
using MVVMStarterDemoA.DataTransformations.Domain.Employee;

namespace MVVMStarterDemoA.ViewModels.Domain.Employee
{
    public class ItemViewModel : ItemViewModelWithImage<EmployeeVMO>
    {
        public override int ImageKey
        {
            get { return DataObject.ImageKey; }
        }

        public override string Description
        {
            get { return DataObject.FullName; }
        }

        public ItemViewModel(EmployeeVMO obj) : base(obj)
        {
        }
    }
}