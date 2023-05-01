using NorthWind.EFCore.Repositories.Context;
using NorthWind.Sales.BusinessObjects.Aggregate;
using NorthWind.Sales.BusinessObjects.Interfaces.Repositories;

namespace NorthWind.EFCore.Repositories.Repositories
{
    public class NothWindSalesCommandsRepository : INorthWindSalesCommandsRepository
    {
        readonly NorthWindSalesContext _DbContext;

        public NothWindSalesCommandsRepository(NorthWindSalesContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async ValueTask CreateOrder(OrderAggregate order)
        {
            await _DbContext.AddAsync(order);

            foreach (var item in order.OrderDetails)
            {
                await _DbContext.AddAsync(new OrderDetail
                {
                    Order = order,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice
                });
            }
        }

        public async ValueTask SaveChanges()
        {
            await _DbContext.SaveChangesAsync();

        }
    }
}
