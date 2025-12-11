using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class License
    {
        public int Id { get; set; }

        public DateTime GenerationDate { get; set; }

        public int SalesPriceExclVAT { get; set; }

        public int LicenseType { get; set; }

        public int DistributorId { get; set; }

        public DateTime ActivationDate { get; set; }

        public DateTime LastUsedDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int RemainingUploadCredits { get; set; }

        public int RemainingPrintCredits { get; set; }

        public String LicenseString { get; set; }

        public int IDstationOwnerId { get; set; }

        public virtual IDstationOwner IDstationOwner { get; set; }

        public virtual IDstation IDstation { get; set; }

        public String AppUserId { get; set; }

        public String AppUserEmail { get; set; }
    }
}

//public class LicenseModel
//{
//    public int Id { get; set; }


//    [Display(Name = "Generation Date")]
//    public DateTime GenerationDate { get; set; }

//    [Display(Name = "Sales Price")]
//    public float SalesPriceExclVAT { get; set; }

//    public LicenseTypes LicenseType { get; set; }


//    [Display(Name = "Activation Date")]
//    public DateTime? ActivationDate { get; set; }

//    // last time the license was used
//    [Display(Name = "Last Used")]
//    public DateTime? LastUsedDate { get; set; }

//    // date when the license will expire. null if NA
//    [Display(Name = "Expiration Date")]
//    public DateTime? ExpirationDate { get; set; }

//    // number of remaining credits for uploading
//    [Display(Name = "Remaining Upload Credits")]
//    public int RemainingUploadCredits { get; set; }

//    // number of remaining credits for printing    (may not be used right now)
//    [Display(Name = "Remaining Print Credits")]
//    public int RemainingPrintCredits { get; set; }

//    // code that was entered during the activation
//    [Display(Name = "License Code")]
//    public string LicenseString { get; set; }

//    public int DistributorId { get; set; }
//    public virtual DistributorModel Distributor { get; set; }

//    // a license can only be purchased by 1 ID station Owner!
//    public int? IDstationOwnerId { get; set; }
//    public virtual IDstationOwnerModel IDstationOwner { get; set; }

//    // a license can only be installed on 1 ID station! (may be re-assigned though)
//    public virtual IDstationModel IDstation { get; set; }

//    public string AppUserId { get; set; }

//    [Display(Name = "WebUser")]
//    public string AppUserEmail { get; set; }

//    public LicenseStatuses LicenseStatus
//    {
//        get
//        {
//            LicenseStatuses status;
//            if (ExpirationDate < DateTime.UtcNow || RemainingPrintCredits == 0 || RemainingUploadCredits == 0)
//            {
//                status = LicenseStatuses.Expired;
//            }
//            else if (IDstationOwnerId.HasValue && IDstation != null)
//            {
//                status = LicenseStatuses.Activated;
//            }
//            else if (IDstationOwnerId.HasValue)
//            {
//                status = LicenseStatuses.DeActivated;
//            }
//            else
//            {
//                status = LicenseStatuses.NewlyGenerated;
//            }
//            return status;
//        }
//    }
//}
//public class LicenseTypeModel
//{
//    public string LicenseType { get; set; }
//    public string UploadCredits { get; set; }
//    // Price is in cents, convert this into Euros
//    public string Price { get; set; }
//}
