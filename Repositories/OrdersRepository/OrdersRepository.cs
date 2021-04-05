using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskFromNikita.Repositories.OrdersRepository
{
    class OrdersRepository : IOrdersRepository
    {
        public IEnumerable<orders> GetOrders()
        {
            using (OrdersPaymentsDBEntities db = new OrdersPaymentsDBEntities())
            {
                return db.orders.ToList();
            }
        }
    }
}
