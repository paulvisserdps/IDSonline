using AutoMapper;
using BusinessLayer.Services;
using Web.Utils;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using Web.Models;

namespace Web.Controllers.Api
{
    public class ActivateLicenseController
    {
        private readonly LicenseService LicenseService;
        private readonly IDstationService IDstationService;
        private readonly IDstationOwnerService IDstationOwnerService;
        private readonly IMapper mapper;
        private PostDataClass postDataClass;

        public ActivateLicenseController(LicenseService licenseService, IDstationService idStationService, IDstationOwnerService idStationOwnerService)
        {
            this.LicenseService = licenseService;
            this.IDstationService = idStationService;
            this.IDstationOwnerService = idStationOwnerService;
            postDataClass = new PostDataClass();
        }

        [RequireHttps]
        public string Post([FromBody] PostDataClass.LicenseData input)
        {
            if (!LicenseService.IsLicenseValid(input.LicenseString))
            {
                return "error: invalid license code";
            }

            var license = LicenseService.GetLicenseByCode(input.LicenseString);
            var loggedIDstationOwner = IDstationOwnerService.GetByAppUsername(input.AuthenticateData.username);
            var loggedIDstation = IDstationService.GetIDstationById(input.AuthenticateData.IDstationID);

            if (loggedIDstation.License != null)
            if (loggedIDstation.License != null)
            {
                if (loggedIDstation.License.Id == license.Id)
                {
                    return "error: this ID station already has this license";
                }
                else
                {
                    try
                    {
                        var OldLicense = loggedIDstation.License;
                        var NewLicense = license;
                        var updatedLicense = Helper.UpgradeLicense(OldLicense, NewLicense, LicenseService, loggedIDstationOwner, loggedIDstation);
                        var returnData = mapper.Map<PostDataClass.ActivateLicenseReturnData>(updatedLicense);
                        string licenseInfoData = postDataClass.SaveActivateLicenseInfoDataToString(returnData);
                        return licenseInfoData;
                    }
                    catch (Exception e)
                    {
                        // CreateLogs.Write("Exception in ActivateLicense_upgrade, message: " + e.Message);
                        return "error: an unknown error has occured";
                    }
                }
            }
            
            try
            {
                string errorMsg;
                License updatedLicense = TryUpdateLicense(license, loggedIDstationOwner, loggedIDstation, out errorMsg);
                if (updatedLicense == null)
                {
                    return errorMsg;
                }

                var returnData = mapper.Map<PostDataClass.ActivateLicenseReturnData>(updatedLicense);
                return postDataClass.SaveActivateLicenseInfoDataToString(returnData);
            }
            catch (Exception e)
            {
                // CreateLogs.Write(String.Format("Source: {0}; Message: {1}; Exception thrown at ActivateLicenseController_Post", e.Source, e.Message));
                return "error internal server exception";
            }
        }

        private License TryUpdateLicense(License license, IDstationOwner loggedIDstationOwner, IDstation loggedIDstation, out string errorMsg)
        {
            if (license.IDstationOwnerId != 0 && license.IDstationOwnerId != loggedIDstationOwner.IDstationOwnerID)
            {
                errorMsg = "error license assigned to another IDstation owner";
                return null;
            }

            license.IDstationOwnerId = loggedIDstationOwner.IDstationOwnerID;
            license.IDstation = loggedIDstation;
            license.ActivationDate = DateTime.UtcNow;

            var updatedLicense = LicenseService.UpdateLicense(license);

            errorMsg = null;
            return updatedLicense;
        }
    }
}
