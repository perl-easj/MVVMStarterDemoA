using DTO.Interfaces;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoA.Models.Domain.Employee;

namespace MVVMStarterDemoA.ViewModels.Domain.Employee
{
    public class ItemViewModel : ItemViewModelWithImage<EmployeeDTO>
    {
        public override int ImageKey
        {
            get { return TypedDataObject.ImageKey; }
        }

        public override string Description
        {
            get { return TypedDataObject.FullName; }
        }

        public ItemViewModel(IDTO obj) : base(obj)
        {
        }
    }
}