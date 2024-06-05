namespace ARCerp.Data.Order
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public string? OrderNumber { get; set; }
        public string? Description { get; set; }
        public Order(int orderId, int quantity, string orderNumber, string description)
        {
            OrderId = orderId;
            Quantity = quantity;
            OrderNumber = orderNumber;
            Description = description;
        }
    }
}
