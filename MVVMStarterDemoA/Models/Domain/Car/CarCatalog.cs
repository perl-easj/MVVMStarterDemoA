using ExtensionsModel.Implementation;
using MVVMStarterDemoA.DataTransformations.Domain.Car;

namespace MVVMStarterDemoA.Models.Domain.Car
{
    public class CarCatalog : FilePersistableCatalogNoDTO<Car, CarViewModel>
    {
        #region Model Singleton implementation
        private static CarCatalog _instance;

        public static CarCatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new CarCatalog();
                return _instance;
            }
        }

        private CarCatalog() : base(new CarViewModelFactory())
        {
        }
        #endregion
    }
}