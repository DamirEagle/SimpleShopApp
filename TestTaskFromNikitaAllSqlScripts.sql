--Создаем БД
CREATE DATABASE OrdersPaymentsDB
GO
USE [OrdersPaymentsDB]
GO

--Создаем таблицу денег
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[money](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date] [date] NOT NULL,
	[sum] [int] NOT NULL,
	[remainder] [int] NOT NULL,
 CONSTRAINT [PK_money] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

--Создаем таблицу заказов
CREATE TABLE [dbo].[orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date] [date] NOT NULL,
	[sum] [int] NOT NULL,
	[sum_to_pay] [int] NOT NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

--Создаем таблицу платежей
CREATE TABLE [dbo].[payments](
	[order_id] [int] NOT NULL,
	[money_id] [int] NOT NULL,
	[payment_sum] [int] NOT NULL,
 CONSTRAINT [PK_payments] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[payments]  WITH CHECK ADD  CONSTRAINT [FK_Id_MoneyId] FOREIGN KEY([money_id])
REFERENCES [dbo].[money] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[payments] CHECK CONSTRAINT [FK_Id_MoneyId]
GO

ALTER TABLE [dbo].[payments]  WITH CHECK ADD  CONSTRAINT [FK_Id_OrderId] FOREIGN KEY([order_id])
REFERENCES [dbo].[orders] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[payments] CHECK CONSTRAINT [FK_Id_OrderId]
GO

--Создаем триггер для уменьшения денег на счету
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[remainder_reducer]
ON [dbo].[payments]
AFTER INSERT
AS
BEGIN
	IF @@ROWCOUNT = 0
		RETURN

	SET NOCOUNT ON

	UPDATE money
	SET remainder = m.remainder - i.payment_sum
	from money m join inserted i
	ON m.id = i.money_id
END
GO

ALTER TABLE [dbo].[payments] ENABLE TRIGGER [remainder_reducer]
GO
--Создаем триггер автоматического заполнения заказа оплаченной суммой
CREATE TRIGGER [dbo].[sum_to_pay_check]
ON [dbo].[payments]
AFTER INSERT
AS
BEGIN
	IF @@ROWCOUNT = 0
		RETURN

	SET NOCOUNT ON

	UPDATE orders
	SET sum_to_pay = o.sum
	from orders o join inserted i
	ON o.id = i.order_id
END
GO

ALTER TABLE [dbo].[payments] ENABLE TRIGGER [sum_to_pay_check]
GO