using System;
using DTO.Implementation;
using DTO.Interfaces;
using ExtensionsModel.Implementation;

namespace MVVMStarterDemoA.Models.Domain.Employee
{
    public class EmployeeCatalog : FilePersistableCatalog<Employee>
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

        private EmployeeCatalog() : base(new DTOFactoryBase<Employee, EmployeeDTO>())
        {
        }
        #endregion

        public override Employee ConvertDTO(IDTO obj)
        {
            EmployeeDTO dtoObj = (obj as EmployeeDTO);
            if (dtoObj == null)
            {
                throw new ArgumentException(nameof(InsertDTO));
            }

            return new Employee(
                    dtoObj.Key,
                    dtoObj.ImageKey,
                    dtoObj.FullName,
                    dtoObj.Phone,
                    dtoObj.Email,
                    dtoObj.Title,
                    dtoObj.EmployedDate);
        }
    }
}