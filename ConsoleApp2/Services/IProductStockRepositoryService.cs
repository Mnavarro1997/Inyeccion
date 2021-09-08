namespace DependencyInyection
{
    public interface IProductStockRepositoryService
    {
        void AddStock(Product product);
        bool IsInStock(Product product);
        void ReduceStock(Product product);
    }
}