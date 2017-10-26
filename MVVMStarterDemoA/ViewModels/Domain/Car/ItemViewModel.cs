using DataTransformation.Interfaces;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoA.DataTransformations.Domain.Car;

namespace MVVMStarterDemoA.ViewModels.Domain.Car
{
    public class ItemViewModel : ItemViewModelWithImage<CarViewModel>
    {
        public override int ImageKey
        {
            get { return TypedDataObject.ImageKey; }
        }

        public override string Description
        {
            get { return TypedDataObject.LicensePlate; }
        }

        public ItemViewModel(ITransformedData obj) : base(obj)
        {
        }
    }
}