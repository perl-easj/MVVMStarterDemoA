using DTO.Interfaces;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoA.Models.Domain.Car;

namespace MVVMStarterDemoA.ViewModels.Domain.Car
{
    public class ItemViewModel : ItemViewModelWithImage<CarDTO>
    {
        public override int ImageKey
        {
            get { return TypedDataObject.ImageKey; }
        }

        public override string Description
        {
            get { return TypedDataObject.LicensePlate; }
        }

        public ItemViewModel(IDTO obj) : base(obj)
        {
        }
    }
}