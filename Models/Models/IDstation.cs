namespace Models.Models
{
    public enum IDStationType
    {
        IDstation, fastID, WebPhotomatic, IDstationBasic, IDstationPro, IDstationPhotomatic, SelfieD, APSbooth, Unknown
    }

    public class IDstation
    {
        public string IDstationID { get; set; }
        public int IDsystemID { get; set; }

        // IDS information, what kind of system is it?
        public string MACaddress { get; set; }
        public string MACaddress_2 { get; set; }

        public IDStationType IDsystemType { get; set; }
        public string IDstationLocation { get; set; }
        public string IDstationSerialnrprinter1 { get; set; }
        public string IDstationSerialnrprinter2 { get; set; }
        public string IDstationSerialnrCamera { get; set; }
        public string IDstationSerialnrPC { get; set; }

        // textual description about system: camfi, eyefi type printer, type tablet, etc etc
        public string IDSdescription { get; set; }

        public DateTime IDstationRegistrationdate { get; set; }
        public DateTime IDstationInstallationdate { get; set; }

        public int IDstationTotalNrofPrinted { get; set; }
        public int IDstationTotalNrofUploaded { get; set; }
        public int IDstationTotalNrofOutofOrder { get; set; }

        public int Printer1RemainingPrintsprinter1 { get; set; }
        public int Printer1RemainingPrintsprinter2 { get; set; }

        // store information : where's the IDS installed 
        public string StoreName { get; set; }
        public virtual string StoreNumber { get; set; }
        public string StoreStreet { get; set; }
        public string StoreZIPcode { get; set; }
        public string StoreCity { get; set; }
        public string StoreCountry { get; set; }
        public string StorePhone { get; set; }
        public string StoreEmailAdress { get; set; }
        public string StoreWebSite { get; set; }
        // sales contact info
        public string StoreContactName { get; set; }
        public string StoreContactPhone { get; set; }
        public string StoreContactEmailAdress { get; set; }


        // an ID station has just 1 owner 
        // Nullable, to make the IDstation available for another owner.
        public int? IDstationOwnerId { get; set; }
        public virtual IDstationOwner IDstationOwner { get; set; }

        // an ID station has just 1 active License
        public virtual License License { get; set; }

        // an ID station will upload many transactions 
        // public virtual ICollection<UploadTransaction> UploadTransaction { get; set; }
        // Store coordinates as returned by google Geo-coding API
        // format: "LAT;LONG"
        public virtual string Coordinates { get; set; }
        public int DistributorID { get; set; }
        public string IDstationCameraModel { get; set; }
        //public string IDstationCameraOwner { get; set; }

        public string DistributorSupportEmailAddress { get; set; }
        public string IDstationPrinterModel { get; set; }
        public string IDstationPCModel { get; set; }
        public int Printer1TotalPrintsAtRegistration { get; set; }

        // new PV 6-1-2021 : we need to add a ref to Store table, Camera table, Printer table and TabletPC table for Photomatic 8
        public int StoreID { get; set; }
        public string PrinterSN { get; set; }
        public string CameraSN { get; set; }
        public string tabletSN { get; set; }
    }
}
