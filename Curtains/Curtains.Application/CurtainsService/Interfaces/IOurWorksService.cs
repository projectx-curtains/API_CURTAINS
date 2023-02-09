using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    /// <summary>
    /// This interface describes the interaction model of the data transfer object to the database.
    /// </summary>
    public interface IOurWorksService
    {
        public IEnumerable<OurWorksDTO> GetAll();
        public Task<OurWorksDTO> GetByIdAsync(int Id);
        public Task InsertAsync(OurWorksDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(OurWorksDTO entity);
        public Task RemoveAsync(OurWorksDTO entity);
    }
}
