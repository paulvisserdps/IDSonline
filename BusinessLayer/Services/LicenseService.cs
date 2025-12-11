using BusinessLayer.Interfaces;
using DataLayer.Repository;
using Models.Models;

namespace BusinessLayer.Services
{
    public class LicenseService : LicenseInterface
    {
        private readonly LicenseRepository licenseRepository;

        public LicenseService(LicenseRepository licenseRepository)
        {
            this.licenseRepository = licenseRepository;
        }

        public License AddLicense(License license)
        {
            throw new NotImplementedException();
        }

        public void DeleteLicense(License license)
        {
            throw new NotImplementedException();
        }

        public IList<License> GetAllLicenses()
        {
            throw new NotImplementedException();
        }

        public License GetLicenseById(int id)
        {
            return licenseRepository.GetLicenseById(id);
        }

        public License GetLicenseByCode(string code)
        {
            return licenseRepository.GetLicenseByCode(code);
        }

        public License UpdateLicense(License license)
        {
            throw new NotImplementedException();
        }

        public bool IsLicenseValid(string licenseString)
        {
            License license = licenseRepository.GetLicenseByCode(licenseString);
            
            if (license == null)
            {
                return false;
            }

            bool isValid = (license.ExpirationDate == null || license.ExpirationDate >= DateTime.UtcNow);

            return isValid;
        }
    }
}
