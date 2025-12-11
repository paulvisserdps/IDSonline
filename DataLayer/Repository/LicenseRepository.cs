using Models.Models;

namespace DataLayer.Repository
{
    public interface LicenseRepository
    {
        License GetLicenseById(int id);

        License GetLicenseByCode(string licenseCode);

        IList<License> GetAll();

        License Add(License license);

        void Update(License license);

        void Delete(License license);
    }
}
