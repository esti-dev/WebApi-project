using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Repository
{
    public class OrdersRepository : IOrdersRepository
    {
        storeDBContext context;
        public OrdersRepository(storeDBContext context)
        {
            this.context = context;
        }
        public async Task<Order> GetById(int id)
        {
            return await context.Orders.FindAsync(id);
        }
        public async Task<Order> Post(Order order)
        {
            await context.Orders.AddAsync(order);
            await context.SaveChangesAsync();
            return order;
        }
    }
}
