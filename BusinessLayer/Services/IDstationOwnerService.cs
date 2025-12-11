using BusinessLayer.Interfaces;
using DataLayer.Repository;
using Models.Models;

namespace BusinessLayer.Services
{
    public class IDstationOwnerService : IDstationOwnerInterface
    {
        private readonly IDstationOwnerRepository idStationOwnerRepository;

        public IDstationOwnerService(IDstationOwnerRepository idStationOwnerRepository)
        {
            this.idStationOwnerRepository = idStationOwnerRepository;
        }

        public void DeleteIDStationOwner(IDstationOwner map)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IDstationOwner> FindByCity(string cityName)
        {
            throw new NotImplementedException();
        }

        public IDstationOwner GetByAppUserId(string userId, Func<IQueryable<IDstationOwner>, IQueryable<IDstationOwner>> query = null)
        {
            throw new NotImplementedException();
        }

        public IDstationOwner GetByAppUsername(string appUsername)
        {
            return idStationOwnerRepository.GetByAppUsername(appUsername);
        }

        public IEnumerable<IDstationOwner> GetByDistributorId(int distributorId, Func<IQueryable<IDstationOwner>, IQueryable<IDstationOwner>> querySelector = null)
        {
            throw new NotImplementedException();
        }

        public IDstationOwner GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDstationOwner GetWithDistributorByAppUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public bool IsAuthorizedToUpload(string uploader, string selectedApplication)
        {
            throw new NotImplementedException();
        }

        public void UpdateIDstationOwner(IDstationOwner map)
        {
            throw new NotImplementedException();
        }

        public void UpdateLastLoginDate(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
