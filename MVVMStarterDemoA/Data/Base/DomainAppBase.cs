using Data.Transformed.Implementation;

namespace MVVMStarterDemoA.Data.Base
{
    public abstract class DomainAppBase : CopyableWithDefaultValuesBase
    {
        public int Id
        {
            get { return Key; }
            set { Key = value; }
        }

        public int ImageKey { get; set; }

        protected DomainAppBase(int imageKey) : base()
        {
            ImageKey = imageKey;
        }
    }
}