using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class CategoryRepository : ICategoriesRepository
    {
        storeDBContext storeDBContext;

        public CategoryRepository(storeDBContext storeDBContext)
        {
            this.storeDBContext = storeDBContext;
        }
        public async Task<IEnumerable<Category>> Get()
        {

            return await storeDBContext.Categories.ToListAsync();
        }
    }
}
