using Curtains.Application.DTO;

namespace Curtains.Application.Interfaces
{
    public interface IOurWorksService
    {
        public IEnumerable<OurWorksDTO> GetAll();
    }
}
