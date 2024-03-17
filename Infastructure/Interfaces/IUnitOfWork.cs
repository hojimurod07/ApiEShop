

namespace Infastructure.Interfaces;

public interface IUnitOfWork
{
    IOrderInterface Orders { get; }
    ICategoryInterface Categoryies { get; }
    IProductInterface Products { get; }
    IOrderItemInterface OrderItems { get; }
    IUserInterface Users { get; }

}
