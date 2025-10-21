using BusinessLayer.Interfaces;
using DataLayer.Repository;
using Models.Models;

namespace BusinessLayer.Services
{
    public class DistributorService : DistributorInterface
    {
        private readonly DistributorRepository distributorRepository;

        public DistributorService(DistributorRepository distributorRepo)
        {
            distributorRepository = distributorRepo;
        }

        public Distributor GetById(int id)
        {
            Distributor distributor = distributorRepository.GetById(id);
            return distributor;
        }

        public Distributor GetByAppUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public Distributor GetByIdWithAppUser(int id)
        {
            throw new NotImplementedException();
        }

        public Distributor GetByShortName(string distributor)
        {
            throw new NotImplementedException();
        }

        public Distributor GetDistributorByIDstationId(string idStationID)
        {
            throw new NotImplementedException();
        }

        public string GetDistributorNamebyIDstationID(string idstationID)
        {
            throw new NotImplementedException();
        }

        public Distributor GetByIdStationId(string idStationId)
        {
            throw new NotImplementedException();
        }

        public IList<Distributor> GetAll(bool getuploads = false)
        {
            throw new NotImplementedException();
        }

        public IList<Distributor> GetByCountry(string country)
        {
            throw new NotImplementedException();
        }

        public Distributor Add(Distributor distributor)
        {
            throw new NotImplementedException();
        }

        public void Update(Distributor distributor)
        {
            throw new NotImplementedException();
        }

        public void Delete(Distributor distributor)
        {
            throw new NotImplementedException();
        }

        public int GetTotalUploads(int DistributorID)
        {
            throw new NotImplementedException();
        }

        public bool CanAccessTemplates(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
