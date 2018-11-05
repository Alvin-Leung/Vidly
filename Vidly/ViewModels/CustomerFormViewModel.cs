using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        public string PageTitle
        {
            get
            {
                if (this.Customer.Id == 0)
                    return "New";
                else
                    return "Edit";
            }
        }
    }
}