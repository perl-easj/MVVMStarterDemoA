using System;
using DTO.Implementation;
using DTO.Interfaces;
using ExtensionsModel.Implementation;

namespace MVVMStarterDemoA.Models.Domain.Car
{
    public class CarCatalog : FilePersistableCatalog<Car>
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

        private CarCatalog() : base(new DTOFactoryBase<Car, CarDTO>())
        {
        }
        #endregion

        public override Car ConvertDTO(IDTO obj)
        {
            CarDTO dtoObj = (obj as CarDTO);
            if (dtoObj == null)
            {
                throw new ArgumentException(nameof(ConvertDTO));
            }

            return new Car(
                    dtoObj.Key,
                    dtoObj.ImageKey,
                    dtoObj.LicensePlate,
                    dtoObj.Brand,
                    dtoObj.Model,
                    dtoObj.Year,
                    dtoObj.EngineSizeCm3,
                    dtoObj.HorsePower,
                    dtoObj.Seats,
                    dtoObj.Price);
        }
    }
}