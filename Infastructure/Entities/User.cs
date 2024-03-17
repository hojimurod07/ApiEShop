namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;

        List<Order> Orders = new List<Order>();
    }
}
