using Data.InMemory.Interfaces;
using Extensions.Model.Implementation;
using MVVMStarterDemoA.Data.Persistent;

namespace MVVMStarterDemoA.Models.Base
{
    /// <summary>
    /// File-based persistency
    /// </summary>
    public class CatalogAppBase<T> : FilePersistableCatalogWithoutTransformation<T>
        where T : class, IStorable, ICopyable, new()
    {
        public CatalogAppBase() : base(true)
        {
        }
    }

    ///// <summary>
    ///// Entity Framework Core-based persistency
    ///// </summary>
    //public class CatalogAppBase<T> : EFCorePersistableCatalog<CarRetailDBContext, T, T, T>
    //    where T : class, IStorable, ICopyable, new()
    //{
    //    public CatalogAppBase()
    //    {
    //        Load();
    //    }

    //    public override T CreateDomainObjectFromViewDataObject(T obj)
    //    {
    //        return obj;
    //    }

    //    public override T CreateViewDataObject(T obj)
    //    {
    //        return obj;
    //    }

    //    public override T CreatePersistentDataObject(T obj)
    //    {
    //        return obj;
    //    }

    //    public override T CreateDomainObjectFromPersistentDataObject(T obj)
    //    {
    //        return obj;
    //    }
}
}