namespace NorthWind.Sales.BusinessObjects.DTOs.CreateOrder
{
    public class CreateOrderDTO
    {
        public string Costumerid { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public string ShipPostalCode { get; set; }

        public List<CreateOrderDetailDTO> OrderDetails { get; set; }
    }
}
