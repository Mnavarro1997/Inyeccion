using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInyection
{
    public class PaymentProcessorService : IPaymentProcessorService
    {
        public void ChargeCreditCard(string creditCardNumber, string expiryDate)
        {
            if (string.IsNullOrEmpty(creditCardNumber))
            {
                throw new ArgumentNullException("Invalid credit card");
            }
            if (string.IsNullOrEmpty(expiryDate))
            {
                throw new ArgumentNullException("Invalid expory date");
            }

            Console.WriteLine("Call to credit card api");
        }
    }
}
