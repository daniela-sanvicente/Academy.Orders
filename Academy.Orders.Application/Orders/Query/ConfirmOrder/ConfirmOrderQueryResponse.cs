using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Orders.Application.Orders.Query.ConfirmOrder
{
    public class ConfirmOrderQueryResponse
    {
        public int orderId { get; set; }
        public string status { get; set; } =  string.Empty;
        public DateTime createdAt { get; set; }
        public List<string> product { get; set; }
        public float total { get; set; }
    }
}
