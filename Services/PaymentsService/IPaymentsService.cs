using System.Collections.Generic;

namespace TestTaskFromNikita.Services.PaymentsService
{
    public interface IPaymentsService
    {
        bool CheckPaymentsList(int orderId);
        IEnumerable<money> GetMoneyAccounts();
        IEnumerable<orders> GetOrdersList();
        void InsertPayment(payments payment);
        IEnumerable<payments> GetPaymentsList();
    }
}