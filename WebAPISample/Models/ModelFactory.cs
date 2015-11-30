using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ACM.BL;

namespace WebAPISample.Models
{
    public class ModelFactory
    {
        public CustomerModel CreateCustomerModel(Customer cust)
        {
            CustomerModel model = new CustomerModel()
            {
                CustomerId = cust.CustomerId,
                CustomerType = cust.CustomerType.ToString(),
                EmailAddress = cust.EmailAddress,
                FirstName = cust.FirstName,
                LastName = cust.LastName,
                InvoiceList = cust.InvoiceList.Select(c => c.InvoiceId.ToString()).ToList()
            };

            return model;
        }
    }
}