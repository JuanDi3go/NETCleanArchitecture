

namespace NorthWind.Sales.Controllers
{
    public class CreateOrderController : ICreateOrderController
    {
        readonly ICreateOrderInputPort _InputPort;
        readonly ICreateOrderPresenter _Presenter;

        public CreateOrderController(ICreateOrderInputPort inputPort, ICreateOrderPresenter presenter)
        {
            _InputPort = inputPort;
            _Presenter = presenter;
        }

        public async ValueTask<int> CreateOrder(CreateOrderDTO dto)
        {
            await _InputPort.Handle(dto);
            return _Presenter.OrderId;
        }
    }
}
