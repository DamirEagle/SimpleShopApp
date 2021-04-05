using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskFromNikita.Repositories.PaymentsRepository.Models;

namespace TestTaskFromNikita.Repositories.PaymentsRepository
{
    class PaymentsRepository : IPaymentsRepository
    {
        public void InsertPayment(payments payment)
        {
            using (OrdersPaymentsDBEntities db = new OrdersPaymentsDBEntities())
            {
                db.Database.ExecuteSqlCommand($@"insert into payments(money_id, order_id, payment_sum)
                values ({payment.money_id}, {payment.order_id}, {payment.payment_sum})");
            }
        }


        public IEnumerable<payments> GetPayments()
        {
            using (OrdersPaymentsDBEntities db = new OrdersPaymentsDBEntities())
            {
                return db.payments.ToList();
            }
        }

        public bool GetPaymentInfoByOrderId(int orderId)
        {
            using (OrdersPaymentsDBEntities db = new OrdersPaymentsDBEntities())
            {
                return db.payments.Any(p=>p.order_id == orderId);
            }
        }
    }
}
