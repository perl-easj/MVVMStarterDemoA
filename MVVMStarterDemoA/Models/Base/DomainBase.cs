using DataTransformation.Interfaces;
using InMemoryStorage.Implementation;

namespace MVVMStarterDemoA.Models.Base
{
    public abstract class DomainBase<T> : StorableBase, ITransformed<T>
    {
        protected DomainBase(int key)
        {
            Key = key;
        }

        public virtual void SetValuesFromObject(T obj)
        {
        }

        public ITransformed<T> Clone()
        {
            return (MemberwiseClone() as ITransformed<T>);
        }
    }
}