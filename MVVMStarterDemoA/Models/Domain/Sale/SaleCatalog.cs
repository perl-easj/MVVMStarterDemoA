using ExtensionsModel.Implementation;
using MVVMStarterDemoA.DataTransformations.Domain.Sale;

namespace MVVMStarterDemoA.Models.Domain.Sale
{
    public class SaleCatalog : FilePersistableCatalogNoDTO<Sale, SaleViewModel>
    {
        #region Model Singleton implementation
        private static SaleCatalog _instance;

        public static SaleCatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new SaleCatalog();
                return _instance;
            }
        }

        private SaleCatalog() : base(new SaleViewModelFactory())
        {
        }
        #endregion
        
        public int CarsSoldByEmployee(int employeeKey)
        {
            return All.FindAll(obj => obj.EmployeeKey == employeeKey).Count;
        }
    }
}