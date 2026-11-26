using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Repository;

namespace Services
{
    public class ProductsService : IProductsService
    {
        IProductsRepository productRepository;

        public ProductsService(IProductsRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<IEnumerable<Product>> Get(string? name, int? maxPrice, int? minPrice, string? desc, int?[] categoryIds)
        {
            return await productRepository.Get(name, maxPrice, minPrice, desc, categoryIds);
        }

        public async Task<Product> GetById(int id)
        {
            return await productRepository.GetById(id);
        }
    }
}
