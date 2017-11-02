using ExtensionsViewModel.Implementation;
using MVVMStarterDemoA.DataTransformations.Domain.Car;

namespace MVVMStarterDemoA.ViewModels.Domain.Car
{
    public class ItemViewModel : ItemViewModelWithImage<CarViewModel>
    {
        public override int ImageKey
        {
            get { return DataObject.ImageKey; }
        }

        public override string Description
        {
            get { return DataObject.LicensePlate; }
        }

        public ItemViewModel(CarViewModel obj) : base(obj)
        {
        }
    }
}