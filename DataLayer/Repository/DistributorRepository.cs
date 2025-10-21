using Models.Models;

namespace DataLayer.Repository
{
    public interface DistributorRepository
    {

        Distributor GetById(int id);

        Distributor GetByShortName(string distributor);

        Distributor GetByAppUserId(int id);

        Distributor GetByIdStationId(string id);

        IList<Distributor> GetAll();

        IList<Distributor> GetByCountry(string country);

        Distributor Add(Distributor distributor);

        void Update(Distributor distributor);

        void Delete(Distributor distributor);
    }
}
