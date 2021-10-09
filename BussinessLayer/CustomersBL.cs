using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;
using DataAccessLayer;

namespace BussinessLayer
{
    public class CustomersBL
    {
        public bool addCustomer(CustomersBO customersBO)
        {
            DataAccess d = new DataAccess();
            return d.addToCustomer(customersBO);
        }

    }
}
