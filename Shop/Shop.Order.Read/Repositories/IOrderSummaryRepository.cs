using Shop.Order.Read.QueryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Order.Read.Repositories
{
    public interface IOrderSummaryRepository
    {
        OrderSummaryListResult GetOrderSummary();

    }
}
