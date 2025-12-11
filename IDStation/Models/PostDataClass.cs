using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml.Serialization;

namespace Web.Models
{
	public class PostDataClass
	{
		public class AuthenticateData
		{
			// username of IDstationOwner
			public string username { get; set; }

			// password of IDstationOwner
			public string password { get; set; }

			// ID stationID indentifies which ID station is making the call. This is already available on the ID station
			public string IDstationID { get; set; }

			// Identifies ID station's mac address of tablet/computer
			public string MACaddress { get; set; }
		}

        public class OwnerData
		{
			// username of IDstationOwner
			public string username { get; set; }

			// ID stationID indentifies which ID station is making the call. This is already available on the ID station
			public string FullName { get; set; }

			public string CellPhoneNumber { get; set; }

			// Identifies ID station's mac address of tablet/computer
			public DateTime DateofBirth { get; set; }
			public PreferredVerificationMode VerificationMode { get; set; }
			public LanguageCode LanguageCode { get; set; }
		}

		public class StoreData
		{

			public string IDstationID { get; set; }

			// store information : where's the IDS installed 
			public int StoreID { get; set; }
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
			//public string StoreContactName { get; set; }
			//public string StoreContactPhone { get; set; }
			//public string StoreContactEmailAdress { get; set; }

		}

		public class RegisterData
		{
			public enum IDStationType
			{
				IDstation, fastID, WebPhotomatic, IDstationBasic, IDstationPro, IDstationPhotomatic, SelfieD, APSbooth, Unknown
			}

			public AuthenticateData AuthenticateData { get; set; }

			public IDStationType IDsystemType { get; set; }                     // Obsolete !!!!!!!!!!!!!!!!!!!!!!
			public string IDstationID { get; set; }

			public string IDstationModel { get; set; }                          // NEW P8
			public string IDstationCameraModel { get; set; }                    // NEW P8
			public string IDstationCameraOwner { get; set; }                    // NEW P8
			public string DistributorName { get; set; }                         // NEW P8
			public string DistributorSupportEmailAddress { get; set; }          // NEW P8
			public string IDstationPrinterModel { get; set; }                   // NEW P8
			public string IDstationPCModel { get; set; }                        // NEW P8
			public DateTime IDstationRegistrationdate { get; set; }             // NEW P8
			public int Printer1TotalPrintsAtRegistration { get; set; }          // NEW P8

			public string MACaddress { get; set; }
			public string IDstationLocation { get; set; }
			public string IDstationSerialnrprinter1 { get; set; }
			public string IDstationSerialnrprinter2 { get; set; }
			public string IDstationSerialnrCamera { get; set; }

			public string IDstationSerialnrPC { get; set; }

			public string IDSdescription { get; set; }
			public DateTime IDstationInstallationdate { get; set; }             // registration date will be filled in by server automatically. NOOOOOO!!!!!

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
			public DateTime? birthDate { get; set; }
			public string FullName { get; set; }
			public string mobilePhone { get; set; }
			//public StoreModel storeModel { get; set; }
		}

		public class AccountInfoData
		{
			// this is what the server sends back to the IDstation returning a LoginCall. It will help the user to decide if it is necessary to register, buy license and so on
			public bool bIDstationIsRegistered { get; set; }         // now we know if there is an IDstation registered already
			public bool bIDstationHasLicense { get; set; }          // now we know if the IDstation registered has a License
			public string CurrentLicenseCode { get; set; }          // code of current license
			public bool bMACaddressOK { get; set; }                 // now we know if the MACadres is OK
			public int RemaininCredits { get; set; }                // if there is a license, we will know how many credits are remaining
			public DateTime? ExperiationDate { get; set; }           // when the license will expire
			public string ErrorMessage { get; set; }                // any feedback

		}
		public class ICAOcheckData
		{
			public AuthenticateData AuthenticateData { get; set; }
			public string CountryTemplate { get; set; }        // name of country template (without .XML) example "Nederland Passport"
			public string PhotoData { get; set; }              // image data stream, base 64 encoded String
			public string IsoLevelsTemplate { get; set; }      // name of IsoLevels template (without .XML) example "Default ISOLevels"
		}
        public class AppAuthenticateData
        {
            public string userName { get; set; }

            public string license { get; set; }

            public string devideID { get; set; }

        }
        public class UploadFromAppData
        {
            public AppAuthenticateData AuthenticateData { get; set; }

            public DateTime UploadDate { get; set; }

            public string EmailAddressReceipient { get; set; }

            public string CellPhoneNumber { get; set; }

            public string SelectedApplication { get; set; }

            public string SessionID { get; set; }

            public bool bIcaoApproved { get; set; }

            public string PhotoData { get; set; }

            public string SignatureData { get; set; }

            public string FingerprintData { get; set; }

            public string ICAOresultData { get; set; }

            public string EXIFdata { get; set; }

            public string ThumbnailOriginalPhotoData { get; set; }

            public bool bCustomerInformed { get; set; }

            public bool bCustomerHasAccepted { get; set; }

            public bool bCustomerHasDisabilityorMedicalException { get; set; }

            public string ReasonforException { get; set; }

            public int StoreID { get; set; }

            public string UsedCameraID { get; set; }

            public string ICAOTestReport { get; set; }

            public string CertificateUsed { get; set; }

            public bool bDigitallyALtered { get; set; }

            public bool bTwoFactorAuthorised { get; set; }

            public bool bUserConfirmedBeingUser { get; set; }

            public bool bUserConfirmedLiveness { get; set; }

            public string LivenessVideo { get; set; }

            public string HashOfPhotoData { get; set; }

            public string BMPimage { get; set; }

            public string HashOfBMPimage { get; set; }

            public string HashofSignatureData { get; set; }

            public string HashofFingerprintdata { get; set; }
        }
        public class UploadTransactionData
		{
			//
			//  Data that will be uploaded : photo, signature, email address and so on....
			//
			[Required]
			public AuthenticateData AuthenticateData { get; set; }

			public DateTime UploadDate { get; set; }            // date of upload

			[EmailAddress]
			public string EmailAddressReceipient { get; set; }  // email address of the customer
			public string CellPhoneNumber { get; set; }         // cellphone number of the customer (if no email)

			[Required]
			public string SelectedApplication { get; set; }     // country template Will designate for which application it is suitable

			[Required]
			public string SessionID { get; set; }               // internal SessionID from ID station software

			public bool bIcaoApproved { get; set; }             // did the photo pass the tests?

			[Required]
			public string PhotoData { get; set; }               // photo data   base 64 encoded String

			public string SignatureData { get; set; }           // signature data   base 64 encoded String
            public string FingerprintData { get; set; }           // Fingerprint data  
            [Required]
			public string ICAOresultData { get; set; }          // ICAO testresults data as string
            public string EXIFdata { get; set; }                // EXIF information from original image as string
            public string ThumbnailOriginalPhotoData { get; set; }               // thumbnail of original photo data (To prove not morphed)   base 64 encoded String
            public bool bCustomerInformed { get; set; }             // customer has beeninformed about photo save?
            public bool bCustomerHasAccepted { get; set; }             // customer has approved about photo save?
            public bool bCustomerHasDisabilityorMedicalException { get; set; }             // customer is special case for which ICAO specs are beyond hope
            public string ReasonforException { get; set; }    
        }
		public class UploadTransactionDataPh8
		{
			//
			//  Data that will be uploaded : photo, signature, email address and so on....
			//
			[Required]
			public AuthenticateData AuthenticateData { get; set; }

			public DateTime UploadDate { get; set; }            // date of upload

			[EmailAddress]
			public string EmailAddressReceipient { get; set; }  // email address of the customer
			public string CellPhoneNumber { get; set; }         // cellphone number of the customer (if no email)

			[Required]
			public string SelectedApplication { get; set; }     // country template Will designate for which application it is suitable

			[Required]
			public string SessionID { get; set; }               // internal SessionID from ID station software

			public bool bIcaoApproved { get; set; }             // did the photo pass the tests?

			[Required]
			public string PhotoData { get; set; }               // photo data   base 64 encoded String

			public string SignatureData { get; set; }           // signature data   base 64 encoded String
			public string FingerprintData { get; set; }           // Fingerprint data  
			[Required]
			public string ICAOresultData { get; set; }          // ICAO testresults data as string
			public string EXIFdata { get; set; }                // EXIF information from original image as string
			public string ThumbnailOriginalPhotoData { get; set; }               // thumbnail of original photo data (To prove not morphed)   base 64 encoded String
			public bool bCustomerInformed { get; set; }             // customer has beeninformed about photo save?
			public bool bCustomerHasAccepted { get; set; }             // customer has approved about photo save?
			public bool bCustomerHasDisabilityorMedicalException { get; set; }             // customer is special case for which ICAO specs are beyond hope
			public string ReasonforException { get; set; }

			// added for Photomatic8
			// Added new fields for Photomatic-8
			public int StoreID { get; set; }

			public string UsedCameraID { get; set; }
			public string ICAOTestReport { get; set; }
			public string CertificateUsed { get; set; }
			public bool bDigitallyALtered { get; set; }
			public bool bTwoFactorAuthorised { get; set; }
			public bool bUserConfirmedBeingUser { get; set; }
			public bool bUserConfirmedLiveness { get; set; }
			public string LivenessVideo { get; set; }

			public string HashOfPhotoData { get; set; }
			public string BMPimage { get; set; }
			public string HashOfBMPimage { get; set; }
			public string HashofSignatureData { get; set; }
			public string HashofFingerprintdata { get; set; }


		}
		public class LicenseData
		{
			[Required]
			public AuthenticateData AuthenticateData { get; set; }

			[Required]
			public string LicenseString { get; set; }
		}

		public class ActivateLicenseReturnData
		{
			public string LicenseString { get; set; }
			public DateTime? ExpirationDate { get; set; }
			public int RemainingUploads { get; set; }
			public int RemainingPrints { get; set; }
			public int LicenseType { get; set; }
		}

        public class DownloadTransactionRequestData
        {
            [Required]
            public string username { get; set; }

            // password of IDstationOwner
            [Required]
            public string password { get; set; }

            [Required]
            public string uniquecode { get; set; }

        }

        private XmlSerializer _xmlserializer = null;
		protected XmlSerializer Serializer
		{
			get
			{
				if (_xmlserializer == null)
					_xmlserializer = new XmlSerializer(typeof(AccountInfoData));
				return _xmlserializer;
			}
		}
		public string SaveAccountInfoDataToString(AccountInfoData session)
		{
			StringWriter string_writer = new StringWriter();
			Serializer.Serialize(string_writer, session);

			return string_writer.ToString();
		}
		public string SaveRegisterDataToString(RegisterData session)
        {
			StringWriter string_writer = new StringWriter();
			Serializer.Serialize(string_writer, session);

			return string_writer.ToString();
		}

		public string SaveDataToString<T>(T dataToSerialize)
		{
			try
			{
				var stringwriter = new StringWriter();
				var serializer = new XmlSerializer(typeof(T));
				serializer.Serialize(stringwriter, dataToSerialize);
				return stringwriter.ToString();
			}
			catch
			{
				throw;
			}
		}


		protected XmlSerializer Serializer2
        {
            get
            {
                if (_xmlserializer == null)
                    _xmlserializer = new XmlSerializer(typeof(ActivateLicenseReturnData));
                return _xmlserializer;
            }
        }
        public string SaveActivateLicenseInfoDataToString(ActivateLicenseReturnData session)
        {
            StringWriter string_writer = new StringWriter();
            Serializer2.Serialize(string_writer, session);

            return string_writer.ToString();
        }
        public class UpgradeLicense
        {
            [Required]
            public AuthenticateData AuthenticateData { get; set; }
            public string OldLicenseString { get; set; }
            public string NewLicenseString { get; set; }
        }
		public class MultiFactorAuthentication
        {
			public string UserName { get; set; }
			public string OTP { get; set; }
			public DateTime GeneratedTime { get; set; }
			public DateTime ExpiredDateTime { get; set; }
			public bool verified { get; set; }
			private DateTime ExpiryDateTime(DateTime GeneratedTime)
			{
				DateTime expiredDateTime = GeneratedTime.AddMinutes(10.00);
				return expiredDateTime;
			}
		}
		public enum PreferredVerificationMode
        {
			Email,
			Phone
        }
		public enum LanguageCode
        {
			en,
			nl,
			de,
			fr
        }
		/*
        public class RegisterDataV2
        {
            public enum IDStationType
            {
                IDstation, fastID, WebPhotomatic, IDstationBasic, IDstationPro, IDstationPhotomatic, SelfieD, APSbooth, Unknown
            }

            [Required]
            public AuthenticateData AuthenticateData { get; set; }

            [Required]
            public string IDstationID { get; set; }
            public IDStationType IDsystemType { get; set; }

            [Required]
            public string MACaddress { get; set; }
            public string IDstationLocation { get; set; }
            public string IDstationSerialnrprinter1 { get; set; }
            public string IDstationSerialnrprinter2 { get; set; }
            public string IDstationSerialnrCamera { get; set; }
            public string IDstationSerialnrPC { get; set; }

            public string IDSdescription { get; set; }
            public DateTime IDstationInstallationdate { get; set; }     // registration date will be filled in by server automatically

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
            public string LicenseCode { get; set; }
        }
		*/
    }
}
