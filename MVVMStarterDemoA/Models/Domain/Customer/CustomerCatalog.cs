using ExtensionsModel.Implementation;
using MVVMStarterDemoA.DataTransformations.Domain.Customer;

namespace MVVMStarterDemoA.Models.Domain.Customer
{
    public class CustomerCatalog : FilePersistableCatalog<Customer, CustomerVMO, Customer>
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

        private CustomerCatalog()
        {
        }
        #endregion

        #region Transformation methods
        public override Customer CreateDomainObjectFromDTO(Customer obj)
        {
            return obj;
        }

        public override Customer CreateDTO(Customer obj)
        {
            return obj;
        }

        public override Customer CreateDomainObjectFromVMO(CustomerVMO vmObj)
        {
            return new Customer(
                vmObj.Key,
                vmObj.ImageKey,
                vmObj.FullName,
                vmObj.Phone,
                vmObj.Email,
                vmObj.Address,
                vmObj.ZipCode,
                vmObj.City,
                vmObj.MinPrice,
                vmObj.MaxPrice,
                vmObj.NewsLetter);
        }

        public override CustomerVMO CreateVMO(Customer obj)
        {
            CustomerVMO vmoObj = new CustomerVMO();

            vmoObj.Key = obj.Key;
            vmoObj.FullName = obj.FullName;
            vmoObj.Phone = obj.Phone;
            vmoObj.Email = obj.Email;
            vmoObj.Address = obj.Address;
            vmoObj.ZipCode = obj.ZipCode;
            vmoObj.City = obj.City;
            vmoObj.MinPrice = obj.MinPrice;
            vmoObj.MaxPrice = obj.MaxPrice;
            vmoObj.NewsLetter = obj.NewsLetter;
            vmoObj.ImageKey = obj.ImageKey;

            return vmoObj;
        } 
        #endregion
    }
}