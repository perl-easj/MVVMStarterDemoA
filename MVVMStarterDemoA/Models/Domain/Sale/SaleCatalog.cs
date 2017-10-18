using System;
using DTO.Implementation;
using DTO.Interfaces;
using ExtensionsModel.Implementation;

namespace MVVMStarterDemoA.Models.Domain.Sale
{
    public class SaleCatalog : FilePersistableCatalog<Sale>
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

        private SaleCatalog() : base(new DTOFactoryBase<Sale, SaleDTO>())
        {
        }
        #endregion

        public override Sale ConvertDTO(IDTO obj)
        {
            SaleDTO dtoObj = (obj as SaleDTO);
            if (dtoObj == null)
            {
                throw new ArgumentException(nameof(InsertDTO));
            }

            return new Sale(
                    dtoObj.Key,
                    dtoObj.CarKey,
                    dtoObj.CustomerKey,
                    dtoObj.EmployeeKey,
                    dtoObj.SalesDate,
                    dtoObj.FinalPrice);
        }
        
        public int CarsSoldByEmployee(int employeeKey)
        {
            return AllDTO.FindAll(obj => ConvertDTO(obj).EmployeeKey == employeeKey).Count;
        }
    }
}