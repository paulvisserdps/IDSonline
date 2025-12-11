using Models.Models;

namespace BusinessLayer.Interfaces
{
    public interface LicenseInterface
    {
        License GetLicenseById(int id);

        License GetLicenseByCode(string code);

        IList<License> GetAllLicenses();

        License AddLicense(License license);

        License UpdateLicense(License license);

        void DeleteLicense(License license);

        bool IsLicenseValid(string licenseCode);
    }
}
