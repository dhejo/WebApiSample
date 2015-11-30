using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPISample.Models
{
    
    public class CustomerModel
    {
        /// Gets the Id of the customer
        /// </summary>
        public int CustomerId { get; internal set; }

        /// <summary>
        /// Gets or sets the customer type
        /// </summary>
        public string CustomerType { get; set; }

        /// <summary>
        /// Gets or sets the customer's email address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the customer's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the set of invoices associated with this customer.
        /// </summary>
        public List<string> InvoiceList { get; set; }

        /// <summary>
        /// Gets or sets the customer's last name
        /// </summary>
        public string LastName { get; set; }
    }
}