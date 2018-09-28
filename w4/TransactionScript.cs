namespace KmaOoad18.Samples.Week4
{
    public class Discounter
    {
        public void ApplyDiscount(int orderId)
        {
            using (var db = new DiscountContext())
            {
                var order = db.Orders.Single(c => c.Id = orderId);


            }
        }
    }

    

}