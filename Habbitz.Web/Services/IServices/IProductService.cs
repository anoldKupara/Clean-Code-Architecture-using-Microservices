using Habbitz.Web.Models;

namespace Habbitz.Web.Services.IServices
{
    public interface IProductService
    {
        Task<T> GetAllProductAsync<T>();
        Task<T> GetProductByIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDto producto);
        Task<T> UpdateProductAsync<T>(ProductDto productDto);   
        Task DeleteProductAsync<T>(int id);
    }
}
