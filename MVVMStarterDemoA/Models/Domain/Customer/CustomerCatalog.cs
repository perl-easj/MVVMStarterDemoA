using DTO.Implementation;
using ExtensionsModel.Implementation;

namespace MVVMStarterDemoA.Models.Domain.Customer
{
    public class CustomerCatalog : FilePersistableCatalog<Customer>
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

        private CustomerCatalog() : base(new CustomerDTOFactory())
        {
        }
        #endregion
    }
}