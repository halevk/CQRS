using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Order.Write.Domains
{
    public class PaymentInfo
    {
        public string PaymentMethod { get; set; }
        public string PaidBy { get; set; }
        public DateTime PaidOn { get; set; }
        public decimal TotalAmount { get; set; }       
    }
}
