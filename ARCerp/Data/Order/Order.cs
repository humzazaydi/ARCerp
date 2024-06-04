namespace ARCerp.Data.Order
{
    public class Order
    {
        public string OrderId { get; set; }
        public int Quantity { get; set; }
        public string? OrderNumber { get; set; }
        public string? Description { get; set; }
    }
}
