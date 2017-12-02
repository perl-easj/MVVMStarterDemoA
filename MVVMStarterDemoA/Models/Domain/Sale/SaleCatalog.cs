using ExtensionsModel.Implementation;
using MVVMStarterDemoA.DataTransformations.Domain.Sale;

namespace MVVMStarterDemoA.Models.Domain.Sale
{
    public class SaleCatalog : FilePersistableCatalog<Sale, SaleVMO, Sale>
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

        private SaleCatalog()
        {
        }
        #endregion
        
        public int CarsSoldByEmployee(int employeeKey)
        {
            return All.FindAll(obj => obj.EmployeeKey == employeeKey).Count;
        }

        #region Transformation methods
        public override Sale CreateDomainObjectFromDTO(Sale obj)
        {
            return obj;
        }

        public override Sale CreateDTO(Sale obj)
        {
            return obj;
        }

        public override Sale CreateDomainObjectFromVMO(SaleVMO vmObj)
        {
            return new Sale(
                vmObj.Key,
                vmObj.CarKey,
                vmObj.CustomerKey,
                vmObj.EmployeeKey,
                vmObj.SalesDate,
                vmObj.FinalPrice);
        }

        public override SaleVMO CreateVMO(Sale obj)
        {
            SaleVMO vmObj = new SaleVMO();

            vmObj.Key = obj.Key;
            vmObj.CarKey = obj.CarKey;
            vmObj.CustomerKey = obj.CustomerKey;
            vmObj.EmployeeKey = obj.EmployeeKey;

            vmObj.SalesDate = obj.SalesDate;
            vmObj.FinalPrice = obj.FinalPrice;

            return vmObj;
        } 
        #endregion
    }
}