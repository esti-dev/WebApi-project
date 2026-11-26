using Entities;

namespace Repository
{
    public interface IOrdersRepository
    {
        Task<Order> GetById(int id);
        Task<Order> Post(Order order);
    }
}