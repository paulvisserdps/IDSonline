namespace Models.Models
{
    public class IDstationOwner
    {
        public int IDstationOwnerID { get; set; }
        public string ShortName { get; set; }
        public string CompanyName { get; set; }
        public string Street { get; set; }
        public string ZIPcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string VATnr { get; set; }
        public string Phone { get; set; }
        public string EmailAdress { get; set; }
        public string WebSite { get; set; }

        //// sales contact info
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmailAdress { get; set; }


        public string IPaddress { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public int FailedLoginAttempts { get; set; }

        public int TotalICAOservercalls { get; set; }
        public int TotalPDuploads { get; set; }

        public bool bOEMprinter { get; set; }
        public DateTime RegisterDate { get; set; }

        //// an ID station owner has 1 Distributor
        public int DistributorId { get; set; }
        //public virtual Distributor Distributor { get; set; }

        public string ApplicationUserId { get; set; }
        //public virtual AppUser ApplicationUser { get; set; }

        //// an ID station owner has one or more ID stations
        //public virtual ICollection<IDstation> IDstation { get; set; }

        //// an ID station Owner can have one or more licenses
        //public virtual ICollection<License> License { get; set; }
        public bool bIrelandOnlinePassport { get; set; }
    }
}
