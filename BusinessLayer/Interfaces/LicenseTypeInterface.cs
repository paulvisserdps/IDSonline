using Models.Models;

namespace BusinessLayer.Interfaces
{
    public interface LicenseTypeInterface
    {
        LicenseType GetByType(int type);

        LicenseType Add(LicenseType licenseType);

        void Update(LicenseType licenseType);

        void Delete(LicenseType licenseType);
    }
}
