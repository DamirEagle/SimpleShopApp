using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Autofac.Core;
using log4net;
using log4net.Config;
using TestTaskFromNikita.Forms;
using TestTaskFromNikita.Repositories.MoneyRepository;
using TestTaskFromNikita.Repositories.OrdersRepository;
using TestTaskFromNikita.Repositories.PaymentsRepository;
using TestTaskFromNikita.Services.LogService;
using TestTaskFromNikita.Services.PaymentsService;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace TestTaskFromNikita
{

    static class Program
    {
        public static IContainer Container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Container = Configure();
            Application.Run(new Main(Container.Resolve<ShopForm>(), Container.Resolve<ProfileForm>()));
        }
        /// <summary>
        /// Setting dependency injection
        /// </summary>
        /// <returns></returns>
        static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<PaymentsRepository>().As<IPaymentsRepository>();
            builder.RegisterType<OrdersRepository>().As<IOrdersRepository>();
            builder.RegisterType<MoneyRepository>().As<IMoneyRepository>();
            builder.RegisterType<Main>();
            builder.RegisterType<ShopForm>();
            builder.RegisterType<ProfileForm>();
            builder.RegisterType<Log4NetService>().As<ILogService>();
            builder.RegisterType<PaymentsService>().As<IPaymentsService>();
            return builder.Build();
        }
    }
}
