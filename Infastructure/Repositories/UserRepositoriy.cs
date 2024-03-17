

using Domain;
using Domain.Entities;
using Infastructure.Interfaces;

namespace Infastructure.Repositories
{
    public class UserRepositoriy(AppDbContext dbContext) : Repository<User>(dbContext), IUserInterface
    {
    }
}
