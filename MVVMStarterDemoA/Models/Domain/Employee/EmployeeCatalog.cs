using ExtensionsModel.Implementation;
using MVVMStarterDemoA.DataTransformations.Domain.Employee;

namespace MVVMStarterDemoA.Models.Domain.Employee
{
    public class EmployeeCatalog : FilePersistableCatalog<Employee, EmployeeVMO, Employee>
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

        private EmployeeCatalog()
        {
        }
        #endregion

        #region Transformation methods
        public override Employee CreateDomainObjectFromDTO(Employee obj)
        {
            return obj;
        }

        public override Employee CreateDTO(Employee obj)
        {
            return obj;
        }

        public override Employee CreateDomainObjectFromVMO(EmployeeVMO vmObj)
        {
            return new Employee(
                vmObj.Key,
                vmObj.ImageKey,
                vmObj.FullName,
                vmObj.Phone,
                vmObj.Email,
                vmObj.Title,
                vmObj.EmployedDate);
        }

        public override EmployeeVMO CreateVMO(Employee obj)
        {
            EmployeeVMO vmoObj = new EmployeeVMO();

            vmoObj.Key = obj.Key;
            vmoObj.FullName = obj.FullName;
            vmoObj.Phone = obj.Phone;
            vmoObj.Email = obj.Email;
            vmoObj.Title = obj.Title;
            vmoObj.EmployedDate = obj.EmployedDate;
            vmoObj.ImageKey = obj.ImageKey;

            return vmoObj;
        } 
        #endregion
    }
}