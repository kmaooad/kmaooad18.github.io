namespace KmaOoad18.Samples.Week6
{
    public class Discounter
    {
		private readonly DiscountContext _db;
		
		public Discounter(DiscountContext db){
			_db = db;
		}
		
        public void ApplyDiscount(int orderId)
        {
			var order = _db.Orders.Single(c => c.Id == orderId);

			foreach (var orderItem in order.Items)
			{
				var discount = _db.Discounts.Where(d => d.Product.Id == orderItem.Product.Id).ToList();
				
				foreach(var discount in discounts)
				{
					orderItem.Total = orderItem.Qty * orderItem.Product.Price * (1 - discount.Value / 100);
				}
			}
			
			_db.SaveChanges();
        }
    }


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
        public decimal Total { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
