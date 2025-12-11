using BusinessLayer.Services;
using Models.Models;

namespace Web.Utils
{
    public class Helper
    {
        public static License UpgradeLicense(License oldLicense, License newLicense, LicenseService licenseService, IDstationOwner loggedIDstationOwner, global::Models.Models.IDstation loggedIDstation)
        {
            bool creditsModified = false;

            if (oldLicense.RemainingUploadCredits > 0)
            {
                newLicense.RemainingUploadCredits += oldLicense.RemainingUploadCredits;
                oldLicense.RemainingUploadCredits = 0; // Reset the old license to zero
                creditsModified = true;
            }

            if (oldLicense.RemainingPrintCredits > 0)
            {
                newLicense.RemainingPrintCredits += oldLicense.RemainingPrintCredits;
                oldLicense.RemainingPrintCredits = 0;
                creditsModified = true;
            }

            if (creditsModified)
            {
                licenseService.UpdateLicense(oldLicense);
            }

            // Update user information with the new license
            newLicense.IDstation = loggedIDstation;
            newLicense.ActivationDate = DateTime.UtcNow;

            if (loggedIDstationOwner != null)
            {
                newLicense.IDstationOwnerId = loggedIDstationOwner.IDstationOwnerID;
            }

            return licenseService.UpdateLicense(newLicense);
        }
    }
}
