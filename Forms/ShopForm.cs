using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTaskFromNikita.Forms.Models;
using TestTaskFromNikita.Repositories.MoneyRepository;
using TestTaskFromNikita.Repositories.OrdersRepository;
using TestTaskFromNikita.Repositories.PaymentsRepository;
using TestTaskFromNikita.Services.LogService;
using TestTaskFromNikita.Services.PaymentsService;


namespace TestTaskFromNikita.Forms
{
    public partial class ShopForm : Form
    {
        private readonly ILogService _logService;
        private readonly IPaymentsService _paymentsService;

        public ShopForm(ILogService logService, IPaymentsService paymentsService)
        {
            _logService = logService;
            _paymentsService = paymentsService;
            InitializeComponent();
        }
        private void ShopForm_Load(object sender, EventArgs e)
        {
            dgvOrders.AutoGenerateColumns = false;
            dgvMoney.AutoGenerateColumns = false;
            dgvPayments.AutoGenerateColumns = false;
            ShowDataInGridDataView();
        }
        private void buttonPayment_Click(object sender, EventArgs e)
        {
            _logService.Info("Попытка провести платеж");
            if (!AreMoneySelected())
            {
                MessageBox.Show("Не выбраны деньги");
                _logService.Error("Не выбраны деньги");
                return;
            }
            if (!AreOrdersSelected())
            {
                MessageBox.Show("Не выбраны заказы");
                _logService.Error("Не выбраны заказы");

                return;
            }

            var orderExistingResult = IsOrderAlreadyInPayments();
            if (orderExistingResult.IsOrderAlreadyInPayments)
            {
                MessageBox.Show("Заказ номер "+ orderExistingResult.OrderId + " уже в платежах");
                _logService.Error("Заказ номер " + orderExistingResult.OrderId + " уже в платежах");
                return;
            }

            if (!IsThereEnoughMoney())
            {
                MessageBox.Show("Недостаточно средств");
                _logService.Error("Недостаточно средств");
                return;
            }

            try
            {
                InsertPayment();
            }
            catch (Exception exception)
            {
                _logService.Error("Произошла ошибка при попытке внести платеж : " + exception.Message);
            }
            ShowDataInGridDataView();
        }

        private void InsertPayment()
        {
            foreach (DataGridViewRow dgvOrdersSelectedRow in dgvOrders.SelectedRows)
            {
                _paymentsService.InsertPayment(new payments
                {
                    order_id = (int)dgvOrdersSelectedRow.Cells[0].Value,
                    money_id = (int)dgvMoney.SelectedRows[0].Cells[0].Value,
                    payment_sum = (int)dgvMoney.SelectedRows[0].Cells[3].Value
                });
            }

        }

        private bool AreOrdersSelected()
        {
            if (dgvOrders.SelectedRows.Count == 0)
                return false;
            return true;
        }

        private bool AreMoneySelected()
        {
            if (dgvMoney.SelectedRows.Count == 0) 
                return false;
            return true;
        }

        private bool IsThereEnoughMoney()
        {
            int total = 0;
            foreach (DataGridViewRow dgvOrdersSelectedRow in dgvOrders.SelectedRows)
            {
                total += (int)dgvOrdersSelectedRow.Cells[2].Value;
            }

            return ((int) dgvMoney.SelectedRows[0].Cells[3].Value) >= total;
        }

        private IsOrderAlreadyInPaymentsResponse IsOrderAlreadyInPayments()
        {
            foreach (DataGridViewRow dgvOrdersSelectedRow in dgvOrders.SelectedRows)
            {
                if (_paymentsService.CheckPaymentsList((int)dgvOrdersSelectedRow.Cells[0].Value))
                    return new IsOrderAlreadyInPaymentsResponse{IsOrderAlreadyInPayments = true,
                        OrderId = (int)dgvOrdersSelectedRow.Cells[0].Value};
            }

            return new IsOrderAlreadyInPaymentsResponse {IsOrderAlreadyInPayments = false};
        }

        private void ShowDataInGridDataView()
        {
            dgvMoney.DataSource = _paymentsService.GetMoneyAccounts();
            dgvOrders.DataSource = _paymentsService.GetOrdersList();
            dgvPayments.DataSource = _paymentsService.GetPaymentsList();
        }
    }
}
