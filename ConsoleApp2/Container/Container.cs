using DependencyInyection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Container
{
    class Container
    {
        public IServiceProvider Build()
        {
            var container = new ServiceCollection()
                .AddSingleton<IPaymentProcessorService, PaymentProcessorService>()
                .AddSingleton<IProductStockRepositoryService, ProductStockRepositoryService>()
                .AddSingleton<IShippingPorcessorService, ShippingPorcessorService>()
                .AddSingleton<IOrderManagerService, OrderManagerService>()
                .BuildServiceProvider();
            return container;
        }
    }
}
