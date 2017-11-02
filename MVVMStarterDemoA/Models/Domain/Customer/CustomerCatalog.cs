using MVVMStarterDemoA.DataTransformations.Domain.Customer;
using MVVMStarterDemoA.Models.Base;

namespace MVVMStarterDemoA.Models.Domain.Customer
{
    public class CustomerCatalog : FilePersistableCatalogNoDTO<Customer, CustomerViewModel>
    {
        #region Model Singleton implementation
        private static CustomerCatalog _instance;

        public static CustomerCatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new CustomerCatalog();
                return _instance;
            }
        }

        private CustomerCatalog() : base(new CustomerViewModelFactory())
        {
        }
        #endregion
    }
}