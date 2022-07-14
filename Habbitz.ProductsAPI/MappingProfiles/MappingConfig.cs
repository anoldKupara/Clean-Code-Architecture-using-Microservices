using AutoMapper;
using Habbitz.ProductsAPI.Models;

namespace Habbitz.ProductsAPI.MappingProfiles
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    }
}
