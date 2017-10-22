﻿using DTO.Implementation;
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

        private EmployeeCatalog() : base(new EmployeeDTOFactory())
        {
        }
        #endregion
    }
}