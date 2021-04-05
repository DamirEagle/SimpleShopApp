
namespace TestTaskFromNikita.Forms
{
    partial class ShopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentsMoneyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.dgvMoney = new System.Windows.Forms.DataGridView();
            this.MoneyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneySum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyRemainder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumToPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.PaymentsMoneyId,
            this.PaymentSum});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayments.Location = new System.Drawing.Point(598, 33);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.RowTemplate.Height = 30;
            this.dgvPayments.Size = new System.Drawing.Size(430, 278);
            this.dgvPayments.TabIndex = 2;
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "order_id";
            this.OrderId.HeaderText = "Заказ";
            this.OrderId.MinimumWidth = 6;
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Width = 80;
            // 
            // PaymentsMoneyId
            // 
            this.PaymentsMoneyId.DataPropertyName = "money_id";
            this.PaymentsMoneyId.HeaderText = "Счет";
            this.PaymentsMoneyId.MinimumWidth = 6;
            this.PaymentsMoneyId.Name = "PaymentsMoneyId";
            this.PaymentsMoneyId.ReadOnly = true;
            this.PaymentsMoneyId.Width = 80;
            // 
            // PaymentSum
            // 
            this.PaymentSum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaymentSum.DataPropertyName = "payment_sum";
            this.PaymentSum.HeaderText = "СуммаПлатежа";
            this.PaymentSum.MinimumWidth = 6;
            this.PaymentSum.Name = "PaymentSum";
            this.PaymentSum.ReadOnly = true;
            // 
            // buttonPayment
            // 
            this.buttonPayment.Location = new System.Drawing.Point(481, 464);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(90, 23);
            this.buttonPayment.TabIndex = 3;
            this.buttonPayment.Text = "Заплатить";
            this.buttonPayment.UseVisualStyleBackColor = true;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // dgvMoney
            // 
            this.dgvMoney.AllowUserToDeleteRows = false;
            this.dgvMoney.BackgroundColor = System.Drawing.Color.White;
            this.dgvMoney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoney.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MoneyId,
            this.MoneyDate,
            this.MoneySum,
            this.MoneyRemainder});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMoney.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMoney.Location = new System.Drawing.Point(12, 249);
            this.dgvMoney.Name = "dgvMoney";
            this.dgvMoney.ReadOnly = true;
            this.dgvMoney.RowHeadersWidth = 51;
            this.dgvMoney.RowTemplate.Height = 30;
            this.dgvMoney.Size = new System.Drawing.Size(559, 196);
            this.dgvMoney.TabIndex = 4;
            // 
            // MoneyId
            // 
            this.MoneyId.DataPropertyName = "id";
            this.MoneyId.HeaderText = "Номер";
            this.MoneyId.MinimumWidth = 6;
            this.MoneyId.Name = "MoneyId";
            this.MoneyId.ReadOnly = true;
            this.MoneyId.Width = 80;
            // 
            // MoneyDate
            // 
            this.MoneyDate.DataPropertyName = "date";
            this.MoneyDate.HeaderText = "Дата";
            this.MoneyDate.MinimumWidth = 6;
            this.MoneyDate.Name = "MoneyDate";
            this.MoneyDate.ReadOnly = true;
            this.MoneyDate.Width = 80;
            // 
            // MoneySum
            // 
            this.MoneySum.DataPropertyName = "sum";
            this.MoneySum.HeaderText = "Сумма";
            this.MoneySum.MinimumWidth = 6;
            this.MoneySum.Name = "MoneySum";
            this.MoneySum.ReadOnly = true;
            this.MoneySum.Width = 80;
            // 
            // MoneyRemainder
            // 
            this.MoneyRemainder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MoneyRemainder.DataPropertyName = "remainder";
            this.MoneyRemainder.HeaderText = "Остаток";
            this.MoneyRemainder.MinimumWidth = 6;
            this.MoneyRemainder.Name = "MoneyRemainder";
            this.MoneyRemainder.ReadOnly = true;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToOrderColumns = true;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Sum,
            this.SumToPay});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrders.Location = new System.Drawing.Point(12, 33);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 30;
            this.dgvOrders.Size = new System.Drawing.Size(559, 196);
            this.dgvOrders.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Номер";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 80;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 80;
            // 
            // Sum
            // 
            this.Sum.DataPropertyName = "sum";
            this.Sum.HeaderText = "Сумма";
            this.Sum.MinimumWidth = 6;
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            this.Sum.Width = 80;
            // 
            // SumToPay
            // 
            this.SumToPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SumToPay.DataPropertyName = "sum_to_pay";
            this.SumToPay.HeaderText = "СуммаОплаты";
            this.SumToPay.MinimumWidth = 6;
            this.SumToPay.Name = "SumToPay";
            this.SumToPay.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Заказы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Деньги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Платежи";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.dgvMoney);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.dgvPayments);
            this.MinimumSize = new System.Drawing.Size(1096, 603);
            this.Name = "ShopForm";
            this.Text = "Shopping";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.DataGridView dgvMoney;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneySum;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyRemainder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumToPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentsMoneyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentSum;
    }
}