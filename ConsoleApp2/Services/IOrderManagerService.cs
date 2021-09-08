namespace DependencyInyection
{
    public interface IOrderManagerService
    {
        void Submit(Product product, string creditCardNumber, string expiryDate);
    }
}