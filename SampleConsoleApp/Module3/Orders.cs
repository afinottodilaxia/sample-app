using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp.Module3
{
    public class OrderDetail
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public List<OrderDetail> Details { get; set; }
        public DateTime OrderDate { get; set; }
        public double DiscountPercent { get; set; }
    }

    public class OrdersProcessor
    {
        public double CalculateTotalMonthlyRevenue(List<Order> orders, int month, int year)
        {
            double monthlyTotal = 0;
            foreach (Order order in orders)
            {
                if (order.OrderDate.Month == month && order.OrderDate.Year == year)
                {
                    double orderTotal = 0;
                    foreach (OrderDetail detail in order.Details)
                    {
                        orderTotal += detail.Price * detail.Quantity;
                    }
                    if (order.DiscountPercent > 0)
                    {
                        orderTotal -= orderTotal * order.DiscountPercent / 100;
                    }
                    monthlyTotal += orderTotal;
                }
            }
            return monthlyTotal;
        }
    }
}
