namespace DependencyInyection
{
    public interface IPaymentProcessorService
    {
        void ChargeCreditCard(string creditCardNumber, string expiryDate);
    }
}