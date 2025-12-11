using Models.Models;

namespace DataLayer.Repository
{
    public interface IDstationOwnerRepository
    {
        IDstationOwner GetById(int id);

        IDstationOwner GetByAppUsername(string username);
        
        IEnumerable<IDstationOwner> GetByDistributorId(int distributorId); // Hiervoor: (int distributorId, Func<IQueryable<IDstationOwner>, IQueryable<IDstationOwner>> querySelector = null);

    }
}
