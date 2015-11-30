using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ACM.BL;
using ACM.DL;
using WebAPISample.Models;

namespace WebAPISample.Controllers
{
    public class CustomerController : ApiController
    {
        public IEnumerable<CustomerModel> Get()
        {
            
            ModelFactory factory = new ModelFactory();
            var customers = Customers.Retrieve().Select(c => factory.CreateCustomerModel(c)).ToList();

            return customers;
        }
    }
}
