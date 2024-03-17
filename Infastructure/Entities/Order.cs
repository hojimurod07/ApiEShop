
namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        public DateTime TimeOfOrder { get; set; }
        public double TotalPrice { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = new User();

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
