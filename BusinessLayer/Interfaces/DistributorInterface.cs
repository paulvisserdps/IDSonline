using Models.Models;

namespace BusinessLayer.Interfaces
{
    public interface DistributorInterface
    {
        Distributor GetById(int id);

        Distributor GetByShortName(string distributor);

        Distributor GetByAppUserId(string userId);

        Distributor GetByIdStationId(string idStationId);

        IList<Distributor> GetAll(bool getuploads = false);

        IList<Distributor> GetByCountry(string country);

        Distributor Add(Distributor distributor);

        void Update(Distributor distributor);

        void Delete(Distributor distributor);

        string GetDistributorNamebyIDstationID(string idStationId);

        bool CanAccessTemplates(string userId);
    }
}
