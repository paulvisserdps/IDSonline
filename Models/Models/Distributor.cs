using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Distributor
    {
        public int DistributorID { get; set; }
        [Display(Name = "Distributor Name")]
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Street { get; set; }
        public string ZIPcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string VATnr { get; set; }
        public string Phone { get; set; }
        public string EmailAdress { get; set; }
        public string WebSite { get; set; }

        public DateTime RegisterDate { get; set; }

        // Sales contact info
        public string SalesName { get; set; }
        public string SalesPhone { get; set; }
        public string SalesEmailAdress { get; set; }

        // Support contact info
        public string SupportName { get; set; }
        public string SupportPhone { get; set; }
        public string SupportEmailAdress { get; set; }

        public string ApplicationUserId { get; set; }
        // public virtual AppUser ApplicationUser { get; set; }

        // public virtual ICollection<IDstationOwnerModel> IDstationOwner { get; set; }             // a distributor will have many customers, which are the IDstationOwners
        public bool bIrelandOnlineEnabled { get; set; }
    }
}
