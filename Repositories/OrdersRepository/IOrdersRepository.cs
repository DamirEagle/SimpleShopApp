using System.Collections.Generic;
using System.Data.Entity;

namespace TestTaskFromNikita.Repositories.OrdersRepository
{
    public interface IOrdersRepository
    {
        IEnumerable<orders> GetOrders();
    }
}