using System.Collections.Generic;
using System.Data.Entity;
using TestTaskFromNikita.Repositories.PaymentsRepository.Models;

namespace TestTaskFromNikita.Repositories.PaymentsRepository
{
    public interface IPaymentsRepository
    {
        void InsertPayment(payments payment);
        IEnumerable<payments> GetPayments();
        bool GetPaymentInfoByOrderId(int orderId);
    }
}