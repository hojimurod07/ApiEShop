

namespace Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public double Amount { get; set; }
        public double TotalPrice { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();

        public int OrderId { get; set; }
        public Order Order { get; set; } = new Order();

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
