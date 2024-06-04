namespace ARCerp.Data.Order
{
    public class OrderService
    {
        public Task<List<Order>> GetOrdersAsync()
        {
            List<Order> orders = new();

            // Adding some orders to the list
            orders.Add(new Order(1,2,"Ref-0012","laptops"));
            orders.Add(new Order(2,5,"Ref-0067","mobiles"));
            orders.Add(new Order(3,7,"Ref-0246","ipads"));
            orders.Add(new Order(4,10,"Ref-0067","tablets"));

            return Task.FromResult(orders.ToList());
        }
    }
}
