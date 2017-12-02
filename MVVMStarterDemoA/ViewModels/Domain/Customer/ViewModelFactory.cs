using DataTransformation.Interfaces;
using MVVMStarterDemoA.DataTransformations.Domain.Customer;
using ViewModel.Implementation;

namespace MVVMStarterDemoA.ViewModels.Domain.Customer
{
    public class ViewModelFactory : ViewModelFactoryBase<CustomerVMO>
    {
        public override IDataWrapper<CustomerVMO> CreateDetailsViewModel(CustomerVMO obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDataWrapper<CustomerVMO> CreateItemViewModel(CustomerVMO obj)
        {
            return new ItemViewModel(obj);
        }
    }
}