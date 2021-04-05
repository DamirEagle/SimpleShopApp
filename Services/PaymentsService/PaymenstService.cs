using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskFromNikita.Forms.Models;
using TestTaskFromNikita.Repositories.MoneyRepository;
using TestTaskFromNikita.Repositories.OrdersRepository;
using TestTaskFromNikita.Repositories.PaymentsRepository;
using TestTaskFromNikita.Services.LogService;

namespace TestTaskFromNikita.Services.PaymentsService
{
    public class PaymentsService : IPaymentsService
    {
        private readonly IPaymentsRepository _paymentsRepository;
        private readonly IOrdersRepository _ordersRepository;
        private readonly IMoneyRepository _moneyRepository;

        public PaymentsService(IPaymentsRepository paymentsRepository, IOrdersRepository ordersRepository, IMoneyRepository moneyRepository)
        {
            _paymentsRepository = paymentsRepository;
            _ordersRepository = ordersRepository;
            _moneyRepository = moneyRepository;
        }

        public void InsertPayment(payments payment)
        {
            _paymentsRepository.InsertPayment(payment);
        }
        public bool CheckPaymentsList(int orderId)
        {
            return _paymentsRepository.GetPaymentInfoByOrderId(orderId);
        }
        public IEnumerable<money> GetMoneyAccounts()
        {
            return _moneyRepository.GetMoney();
        }
        public IEnumerable<orders> GetOrdersList()
        {
            return _ordersRepository.GetOrders();
        }
        public IEnumerable<payments> GetPaymentsList()
        {
            return _paymentsRepository.GetPayments();
        }
    }
}
