namespace KmaOoad18.Samples.Week4
{
    public class DiscountContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=discounts.db");
        }
    }


    public class Discount
    {
        public int ProductId { get; set; }
        public int DiscountValue { get; set; } // Discount%
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }

    public class Order
    {
        public List<OrderItem> Items { get; set; }
        public Customer Customer { get; set; }
    }

    public class OrderItem
    {
        public Product Product { get; set; }
        public int Qty { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}