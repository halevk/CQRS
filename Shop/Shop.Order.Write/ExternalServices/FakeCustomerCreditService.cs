using Shop.Order.Write.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Order.Write.ExternalServices
{
    public class FakeCustomerCreditService : ICustomerCreditService
    {
        public decimal GetCustomerCreditLimit(int customerId)
        {
            return 500;
        }

        public string GetCustomerName(int customerId)
        {
            return "John Doe";
        }
    }
}
