using Entities;

namespace Repository
{
    public interface ICategoriesRepository
    {
        Task<IEnumerable<Category>> Get();
    }
}