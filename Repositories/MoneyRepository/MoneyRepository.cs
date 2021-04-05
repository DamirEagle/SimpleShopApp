using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskFromNikita.Repositories.MoneyRepository
{
    class MoneyRepository : IMoneyRepository
    {
        public IEnumerable<money> GetMoney()
        {
            using (OrdersPaymentsDBEntities db = new OrdersPaymentsDBEntities())
            {
                return db.money.ToList();
            }
        }
    }
}
