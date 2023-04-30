
namespace NorthWind.Sales.UseCases.CreateOrder
{
    public class CreateOrderInteractor : ICreateOrderInputPort
    {
        readonly ICreateOrderOutputPort _outPutPort;
        readonly INorthWindSalesCommandsRepository _repository;

        public CreateOrderInteractor(ICreateOrderOutputPort outPutPort, INorthWindSalesCommandsRepository repository)
        {
            _outPutPort = outPutPort;
            _repository = repository;
        }

        public async ValueTask Handle(CreateOrderDTO orderDTO)
        {

            OrderAggregate Order = OrderAggregate.From(orderDTO);

            await _repository.CreateOrder(Order);
            await _repository.SaveChanges();
            await _outPutPort.Handle(Order.Id);

        }
    }
}
