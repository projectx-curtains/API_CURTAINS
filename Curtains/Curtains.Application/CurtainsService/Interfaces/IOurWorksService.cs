using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsServices.Interfaces
{
    public interface IOurWorksService
    {
        public IEnumerable<OurWorksDTO> GetAll();
    }
}
