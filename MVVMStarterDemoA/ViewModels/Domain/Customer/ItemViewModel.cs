using ExtensionsViewModel.Implementation;
using MVVMStarterDemoA.DataTransformations.Domain.Customer;

namespace MVVMStarterDemoA.ViewModels.Domain.Customer
{
    public class ItemViewModel : ItemViewModelWithImage<CustomerVMO>
    {
        public override int ImageKey
        {
            get { return DataObject.ImageKey; }
        }

        public override string Description
        {
            get { return DataObject.FullName; }
        }

        public ItemViewModel(CustomerVMO obj) : base(obj)
        {
        }
    }
}