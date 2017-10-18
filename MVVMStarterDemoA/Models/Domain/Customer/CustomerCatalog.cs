using System;
using DTO.Implementation;
using DTO.Interfaces;
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

        private CustomerCatalog() : base(new DTOFactoryBase<Customer, CustomerDTO>())
        {
        }
        #endregion

        public override Customer ConvertDTO(IDTO obj)
        {
            CustomerDTO dtoObj = (obj as CustomerDTO);
            if (dtoObj == null)
            {
                throw new ArgumentException(nameof(InsertDTO));
            }

            return new Customer(
                    dtoObj.Key,
                    dtoObj.ImageKey,
                    dtoObj.FullName,
                    dtoObj.Phone,
                    dtoObj.Email,
                    dtoObj.Address,
                    dtoObj.ZipCode,
                    dtoObj.City,
                    dtoObj.MinPrice,
                    dtoObj.MaxPrice,
                    dtoObj.NewsLetter);
        }
    }
}