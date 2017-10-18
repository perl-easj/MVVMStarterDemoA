using DTO.Interfaces;
using MVVMStarterDemoA.Models.Domain.Customer;
using ViewModel.Implementation;

namespace MVVMStarterDemoA.ViewModels.Domain.Customer
{
    public class ViewModelFactory : ViewModelFactoryBase<CustomerDTO>
    {
        public override IDTOWrapper CreateDetailsViewModel(IDTO obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDTOWrapper CreateItemViewModel(IDTO obj)
        {
            return new ItemViewModel(obj);
        }
    }
}