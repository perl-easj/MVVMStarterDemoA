using ExtensionsModel.Implementation;
using MVVMStarterDemoA.DataTransformations.Domain.Car;

namespace MVVMStarterDemoA.Models.Domain.Car
{
    public class CarCatalog : FilePersistableCatalog<Car, CarVMO, Car>
    {
        #region Model Singleton implementation
        private static CarCatalog _instance;

        public static CarCatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new CarCatalog();
                return _instance;
            }
        }

        private CarCatalog()
        {
        }
        #endregion

        #region Transformation methods
        public override Car CreateDomainObjectFromDTO(Car obj)
        {
            return obj;
        }

        public override Car CreateDTO(Car obj)
        {
            return obj;
        }

        public override Car CreateDomainObjectFromVMO(CarVMO vmObj)
        {
            return new Car(
                vmObj.Key,
                vmObj.ImageKey,
                vmObj.LicensePlate,
                vmObj.Brand,
                vmObj.Model,
                vmObj.Year,
                vmObj.EngineSizeCm3,
                vmObj.HorsePower,
                vmObj.Seats,
                vmObj.Price);
        }

        public override CarVMO CreateVMO(Car obj)
        {
            CarVMO vmoObj = new CarVMO();

            vmoObj.Key = obj.Key;
            vmoObj.LicensePlate = obj.LicensePlate;
            vmoObj.Brand = obj.Brand;
            vmoObj.Model = obj.Model;
            vmoObj.Year = obj.Year;
            vmoObj.EngineSizeCm3 = obj.EngineSizeCm3;
            vmoObj.HorsePower = obj.HorsePower;
            vmoObj.Seats = obj.Seats;
            vmoObj.Price = obj.Price;
            vmoObj.ImageKey = obj.ImageKey;

            return vmoObj;
        } 
        #endregion
    }
}