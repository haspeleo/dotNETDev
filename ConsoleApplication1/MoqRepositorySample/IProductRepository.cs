using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqRepositorySample
{
    public interface IProductRepository
    {
        IList<Product> findAll();

        Product findByName(string productName);
        
        Product findById(int productId);
        
        bool save(Product target);

    }
}
