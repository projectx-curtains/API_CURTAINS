using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IOrderService
    {
        public IEnumerable<OrderDTO> GetAll();
        public Task InsertAsync(OrderDTO entity, CancellationToken cancelationToken);
    }
}
