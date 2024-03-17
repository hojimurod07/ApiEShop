
using Domain;
using Infastructure.Interfaces;

namespace Infastructure.Repositories
{
    public class UnitOfWork(AppDbContext dbContext) : IUnitOfWork
    {
        private readonly AppDbContext _dbContext = dbContext;

        public IOrderInterface Orders => new OrderRepository(_dbContext);

        public ICategoryInterface Categoryies => new CategoryRepository(_dbContext);

        public IProductInterface Products => new ProductRepository(_dbContext);

        public IOrderItemInterface OrderItems => new OrderItemRepository(_dbContext);

        public IUserInterface Users => new UserRepositoriy(_dbContext);
    }
}
