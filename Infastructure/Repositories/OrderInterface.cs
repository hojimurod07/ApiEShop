

using Domain;
using Domain.Entities;
using Infastructure.Interfaces;

namespace Infastructure.Repositories
{
    public class OrderRepository(AppDbContext dbContext) : Repository<Order>(dbContext), IOrderInterface
    {

    }
}
