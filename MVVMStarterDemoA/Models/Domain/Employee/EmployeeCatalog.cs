using MVVMStarterDemoA.DataTransformations.Domain.Employee;
using MVVMStarterDemoA.Models.Base;

namespace MVVMStarterDemoA.Models.Domain.Employee
{
    public class EmployeeCatalog : FilePersistableCatalogNoDTO<Employee, EmployeeViewModel>
    {
        #region Model Singleton implementation
        private static EmployeeCatalog _instance;

        public static EmployeeCatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new EmployeeCatalog();
                return _instance;
            }
        }

        private EmployeeCatalog() : base(new EmployeeViewModelFactory())
        {
        }
        #endregion
    }
}