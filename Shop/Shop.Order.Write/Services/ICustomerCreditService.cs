using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Order.Write.Services
{
    public interface ICustomerCreditService
    {
        decimal GetCustomerCreditLimit(int customerId);
        string GetCustomerName(int customerId);
    }
}
