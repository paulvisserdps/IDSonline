using Models.Models;

namespace DataLayer.Repository
{
    public interface IDstationRepository
    {
        IDstation GetIDstationById(string id);
    }
}
