using DataTransformation.Interfaces;
using MVVMStarterDemoA.DataTransformations.Domain.Sale;
using ViewModel.Implementation;

namespace MVVMStarterDemoA.ViewModels.Domain.Sale
{
    public class ViewModelFactory : ViewModelFactoryBase<SaleViewModel>
    {
        public override ITransformedDataWrapper CreateDetailsViewModel(ITransformedData obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ITransformedDataWrapper CreateItemViewModel(ITransformedData obj)
        {
            return new ItemViewModel(obj);
        }
    }
}