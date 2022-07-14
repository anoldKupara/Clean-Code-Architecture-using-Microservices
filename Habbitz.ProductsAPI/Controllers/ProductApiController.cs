using Habbitz.ProductsAPI.Models;
using Habbitz.ProductsAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Habbitz.ProductsAPI.Controllers
{
    [Route("api/products")]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        protected ResponseDto _responseDto;

        public ProductApiController(IProductRepository productRepository)
        {
            this._responseDto = new ResponseDto();
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<ProductDto> productDtos = await _productRepository.GetProductById();
                _responseDto.Result = productDtos;
            }
            catch(Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.ErrorMessages = 
                    new List<string>()
                {
                    ex.ToString()
                };
            }

            return _responseDto;
        }
        [HttpGet]
        [Route("id")]
        public async Task<object> Get(int id)
        {
            try
            {
                ProductDto product = await _productRepository.GetProductById(id);
                _responseDto.Result = product;
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.ErrorMessages =
                    new List<string>()
                {
                    ex.ToString()
                };
            }

            return _responseDto;
        }

        [HttpPost]
        public async Task<object> Post([FromBody] ProductDto productDto)
        {
            try
            {
                ProductDto product = await _productRepository.CreateUpdateProduct(productDto);
                _responseDto.Result = product;
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.ErrorMessages =
                    new List<string>()
                {
                    ex.ToString()
                };
            }

            return _responseDto;
        }

        [HttpPut]
        public async Task<object> Put([FromBody] ProductDto productDto)
        {
            try
            {
                ProductDto product = await _productRepository.CreateUpdateProduct(productDto);
                _responseDto.Result = product;
            }
            catch (Exception ex)
            {   
                _responseDto.IsSuccess = false;
                _responseDto.ErrorMessages =
                    new List<string>()
                {
                    ex.ToString()
                };
            }

            return _responseDto;
        }

        [HttpDelete]
        public async Task<object> Delete(int id)
        {
            try
            {
                 bool isSuccess = await _productRepository.DeleteProduct(id);
                _responseDto.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.ErrorMessages =
                    new List<string>()
                {
                    ex.ToString()
                };
            }

            return _responseDto;
        }
    }
}
