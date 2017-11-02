using DataTransformation.Implementation;
using DataTransformation.Interfaces;
using ExtensionsModel.Implementation;

namespace MVVMStarterDemoA.Models.Base
{
    public class FilePersistableCatalogNoDTO<T, TVMO> : FilePersistableCatalog<T, TVMO, T> 
        where T : class, ITransformed<T>, new()
    {
        public FilePersistableCatalogNoDTO(IFactory<T, TVMO> vmFactory) 
            : base(vmFactory, new IdenticalDataFactory<T>())
        {
        }
    }
}