using Models.Models;

namespace BusinessLayer.Interfaces
{
    public interface IDstationOwnerInterface
    {
        IEnumerable<IDstationOwner> GetByDistributorId(int distributorId, Func<IQueryable<IDstationOwner>, IQueryable<IDstationOwner>> querySelector = null);

        IDstationOwner GetById(int id);

        IDstationOwner GetByAppUserId(string userId,
            Func<IQueryable<IDstationOwner>, IQueryable<IDstationOwner>> query = null);

        IDstationOwner GetByAppUsername(string appUsername);
        IDstationOwner GetWithDistributorByAppUserId(string userId);
        void UpdateIDstationOwner(IDstationOwner map);
        void UpdateLastLoginDate(string userId);
        void DeleteIDStationOwner(IDstationOwner map);
        bool IsAuthorizedToUpload(string uploader, string selectedApplication);
        IEnumerable<IDstationOwner> FindByCity(string cityName);
    }
}
