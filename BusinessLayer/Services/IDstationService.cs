using BusinessLayer.Interfaces;
using DataLayer.Repository;
using Models.Models;

namespace BusinessLayer.Services
{
    public class IDstationService : IDstationInterface
    {
        private readonly IDstationRepository idStationRepository;

        public IDstationService(IDstationRepository idStationRepository)
        {
            this.idStationRepository = idStationRepository;
        }

        public IDstation Add(IDstation idStation, Distributor distributor = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IDstation> FindByCity(string cityName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IDstation> GetByDistributorId(int distributorId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IDstation> GetByDistributorId_storeLocator(int distributorId)
        {
            throw new NotImplementedException();
        }

        public IDstation GetIDstationById(string idStationId)
        {
            return idStationRepository.GetIDstationById(idStationId);
        }

        public IEnumerable<IDstation> GetByIDstationOwnerId(int iDstationOwnerId)
        {
            throw new NotImplementedException();
        }

        public IDstation GetbyStoreID(int storeid)
        {
            throw new NotImplementedException();
        }

        public IDstation GetIDstationByLicenseCode(string licenseCode)
        {
            throw new NotImplementedException();
        }

        public int GetTotalUploadCounts(string IDstationID)
        {
            throw new NotImplementedException();
        }

        public bool IsIDstationRegistered(string idStationId, string macAddress)
        {
            throw new NotImplementedException();
        }

        public bool IsIDstationRelatedToIDstationOwner(string authenticateDataDstationId, string authenticateDataUsername)
        {
            throw new NotImplementedException();
        }

        public IDstation Remove(IDstation idStation)
        {
            throw new NotImplementedException();
        }

        public IDstation Update(IDstation idStation)
        {
            throw new NotImplementedException();
        }
    }
}
