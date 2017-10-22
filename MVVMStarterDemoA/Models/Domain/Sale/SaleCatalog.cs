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

        private SaleCatalog() : base(new SaleDTOFactory())
        {
        }
        #endregion
        
        public int CarsSoldByEmployee(int employeeKey)
        {
            SaleDTOFactory dtoFactory = new SaleDTOFactory();
            return AllDTO.FindAll(obj => dtoFactory.CreateT(obj).EmployeeKey == employeeKey).Count;
        }
    }
}