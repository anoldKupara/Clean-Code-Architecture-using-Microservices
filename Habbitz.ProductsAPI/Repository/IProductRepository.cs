using Habbitz.ProductsAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Habbitz.ProductsAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProductById();
        Task<ProductDto> GetProductById(int productId); 
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);    
        Task<bool> DeleteProduct(int productId);
    }
}
