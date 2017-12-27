using System.Collections.Generic;
using Data.Transformed.Interfaces;
using MVVMStarterDemoA.Data.Domain;
using MVVMStarterDemoA.Models.App;
using MVVMStarterDemoA.ViewModels.Base;
using MVVMStarterDemoA.ViewModels.Data;

namespace MVVMStarterDemoA.ViewModels.Page
{
    public class CustomerPageViewModel : PageViewModelAppBase<Customer>
    {
        public CustomerPageViewModel()
            : base(DomainModel.Catalogs.Customers,
                new List<string> { "Name" },
                new List<string> { "Image", "Address", "ZipCode", "City", "Phone", "Email", "MaxPrice", "MinPrice", "Newsletter" })
        {
        }

        public override IDataWrapper<Customer> CreateDataViewModel(Customer obj)
        {
            return new CustomerDataViewModel(obj);
        }
    }
}