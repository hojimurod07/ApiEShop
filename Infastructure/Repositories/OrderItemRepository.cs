

using Domain;
using Domain.Entities;
using Infastructure.Interfaces;

namespace Infastructure.Repositories
{
    public class OrderItemRepository(AppDbContext dbContext) : Repository<OrderItem>(dbContext), IOrderItemInterface
    {
    }
}
