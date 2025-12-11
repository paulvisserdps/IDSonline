namespace Models.Models
{
    public class LicenseType
    {
        public int Type { get; set; }
        public int UploadCredits { get; set; }

        public int PrintCredits { get; set; }

        public int PriceInCentVAT { get; set; }

        public int DurationMonths { get; set; }
    }
}
