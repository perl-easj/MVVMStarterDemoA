using DTO.Interfaces;
using MVVMStarterDemoA.Models.Domain.Sale;
using ViewModel.Implementation;

namespace MVVMStarterDemoA.ViewModels.Domain.Sale
{
    public class ViewModelFactory : ViewModelFactoryBase<SaleDTO>
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