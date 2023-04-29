
namespace NorthWind.Sales.BusinessObjects.PocoEntities
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public string ShipPostalCode { get; set; }
        public ShippignType ShippingType { get; set; } = ShippignType.Road;
        public DiscountType DiscountType { get; set; } = DiscountType.Percentage;
        public double Discount { get; set; } = 10;
        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
