using DTO.Interfaces;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoA.Models.Domain.Customer;

namespace MVVMStarterDemoA.ViewModels.Domain.Customer
{
    public class ItemViewModel : ItemViewModelWithImage<CustomerDTO>
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