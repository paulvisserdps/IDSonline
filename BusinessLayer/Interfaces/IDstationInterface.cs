using Models.Models;

namespace BusinessLayer.Interfaces
{
    public interface IDstationInterface
    {
        bool IsIDstationRegistered(string idStationId, string macAddress);

        bool IsIDstationRelatedToIDstationOwner(string authenticateDataDstationId, string authenticateDataUsername);

        IEnumerable<IDstation> GetByIDstationOwnerId(int iDstationOwnerId);

        IEnumerable<IDstation> GetByDistributorId(int distributorId);
        IEnumerable<IDstation> GetByDistributorId_storeLocator(int distributorId);

        IDstation GetIDstationById(string idStationId);

        IDstation GetIDstationByLicenseCode(string licenseCode);

        IDstation GetbyStoreID(int storeid);

        IDstation Update(IDstation idStation);

        IDstation Add(IDstation idStation, Distributor distributor = null);

        //IDstation Add2(IDstation idStation, Distributor distributor = null, StoreModel store = null, Printer printer = null, Camera camera = null, Tablet tablet = null);

        int GetTotalUploadCounts(string IDstationID);
        IDstation Remove(IDstation idStation);
        IEnumerable<IDstation> FindByCity(string cityName);
    }
}
