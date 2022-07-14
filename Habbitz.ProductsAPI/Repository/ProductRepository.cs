using AutoMapper;
using Habbitz.ProductsAPI.DbContexts;
using Habbitz.ProductsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Habbitz.ProductsAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private IMapper _mapper;
         
        public ProductRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            Product product = _mapper.Map<ProductDto,Product>(productDto);
            if(product.ProductId > 0)
            {
                _dbContext.Products.Update(product);
            }
            else
            {
                _dbContext.Products.Add(product);
            }
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<Product, ProductDto>(product);
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            try
            {
                Product product = await _dbContext.Products.FirstOrDefaultAsync(p => p.ProductId == productId);
                if (product == null) 
                { 
                    return false;
                }
                _dbContext.Remove(product);
                await _dbContext.SaveChangesAsync(); 
                return true;
            }catch (Exception)
            {
                return false;
            }
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            Product product = await _dbContext.Products.Where(x => x.ProductId == productId).FirstOrDefaultAsync();
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<IEnumerable<ProductDto>> GetProductById()
        {
            List<Product> productList = await _dbContext.Products.ToListAsync();
            return _mapper.Map<List<ProductDto>>(productList);
        }
    }
}
