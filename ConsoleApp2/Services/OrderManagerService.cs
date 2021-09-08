using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInyection
{
    public class OrderManagerService : IOrderManagerService
    {
        public void Submit(Product product, string creditCardNumber, string expiryDate)
        {
            //stock del producto
            var productStockRepository = new ProductStockRepositoryService();
            if (!productStockRepository.IsInStock(product))
            {
                throw new Exception($"{product.ToString()} currently not in stock");
            }

            //aqui se gestiona el pago
            PaymentProcessorService paymentProcessor = new PaymentProcessorService();
            paymentProcessor.ChargeCreditCard(creditCardNumber, expiryDate);

            ShippingPorcessorService shippingPorcessor = new ShippingPorcessorService();
            shippingPorcessor.MailProduct(product);
        }
    }
}
