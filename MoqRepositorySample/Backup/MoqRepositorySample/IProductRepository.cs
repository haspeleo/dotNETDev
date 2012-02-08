namespace MoqRepositorySample
{
    using System.Collections.Generic;

    public interface IProductRepository
    {
        IList<Product> FindAll();

        Product FindByName(string productName);

        Product FindById(int productId);

        bool Save(Product target);
    }
}
