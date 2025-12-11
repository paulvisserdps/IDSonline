using Models.Models;

namespace DataLayer.Repository
{
    public interface LicenseTypeRepository
    {
        LicenseType GetByType(int type);

        LicenseType Add(LicenseType licenseType);

        void Update(LicenseType licenseType);

        void Delete(LicenseType licenseType);
    }
}
