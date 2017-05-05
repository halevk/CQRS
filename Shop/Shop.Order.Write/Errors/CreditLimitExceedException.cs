using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Order.Write.Errors
{
    public class CreditLimitExceedException : Exception
    {
        public CreditLimitExceedException(string message):base(message)
        {

        }
    }
}
