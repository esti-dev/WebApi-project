using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Repository;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        ICategoriesRepository categoryRepository;

        public CategoryService(ICategoriesRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<Category>> Get()
        {
            return await categoryRepository.Get();
        }

    }
}
