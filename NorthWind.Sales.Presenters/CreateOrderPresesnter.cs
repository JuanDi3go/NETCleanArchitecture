
namespace NorthWind.Sales.Presenters
{
    public class CreateOrderPresesnter : ICreateOrderPresenter
    {
        public int OrderId { get; private set; }

        public ValueTask Handle(int orderId)
        {
            OrderId = orderId;
            return ValueTask.CompletedTask;
        }
    }
}
