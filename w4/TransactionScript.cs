namespace KmaOoad18.Samples.Week4
{
    public class Discounter
    {
        public void ApplyDiscount(int orderId)
        {
            using (var db = new DiscountContext())
            {
                var order = db.Orders.Single(c => c.Id = orderId);

                foreach (var orderItem in order.Items)
                {
                    var discount = db.Discounts.Where(d => d.Product.Id == orderItem.Product.Id).ToList();
                    
                    foreach(var discount in discounts)
                    {
                        orderItem.Total = orderItem.Qty * orderItem.Product.Price * (1 - discount.Value / 100);
                    }
                }
                
                db.SaveChanges();
            }
        }
    }

    

}
