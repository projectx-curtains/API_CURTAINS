using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IOurWorksService
    {
        public IEnumerable<OurWorksDTO> GetAll();
    }
}
