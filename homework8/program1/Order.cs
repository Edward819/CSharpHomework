using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Order
    {
        List<OrderDetail> orders;
        public Order()
        {
            orders = new List<OrderDetail>();
        }
        public void addNewOrder(OrderDetail anOrder)
        {
            orders.Add(anOrder);
        }
    }
}
