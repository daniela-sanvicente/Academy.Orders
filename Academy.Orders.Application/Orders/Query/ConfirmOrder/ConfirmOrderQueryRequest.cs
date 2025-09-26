using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Orders.Application.Orders.Query.ConfirmOrder
{
    public class ConfirmOrderQueryRequest
    {
        public int customerId { get; set; }
        public int cartId { get; set; }
        public string paymentMethod { get; set; }
        public string customerAddress { get; set; }
    }
}
