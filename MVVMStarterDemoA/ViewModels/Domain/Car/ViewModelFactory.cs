using DTO.Interfaces;
using MVVMStarterDemoA.Models.Domain.Car;
using ViewModel.Implementation;

namespace MVVMStarterDemoA.ViewModels.Domain.Car
{
    public class ViewModelFactory : ViewModelFactoryBase<CarDTO>
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