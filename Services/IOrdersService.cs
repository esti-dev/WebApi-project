using Entities;

namespace Services
{
    public interface IOrdersService
    {
        Task<Order> GetById(int id);
        Task<Order> Post(Order order);
    }
}