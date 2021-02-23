using System;
using System.Collections.Generic;

#nullable disable

namespace EbayPlatform.DataBase.Models
{
    public partial class EbayAddress
    {
        public string AddressId { get; set; }
        public string ExternalAddressId { get; set; }
        public string InternationalName { get; set; }
        public string InternationalStateAndCity { get; set; }
        public string InternationalStreet { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Phone2 { get; set; }
        public string ReferenceId { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string CityName { get; set; }
        public string County { get; set; }
        public string StateOrProvince { get; set; }
        public string Country { get; set; }
        public string CountryName { get; set; }
        public string Phone { get; set; }
        public string PhoneCountryCode { get; set; }
        public string PhoneCountryPrefix { get; set; }
        public string PhoneAreaOrCityCode { get; set; }
        public string PhoneLocalNumber { get; set; }
        public DateTime SyncCreateDate { get; set; }
        public DateTime? SyncUpdateDate { get; set; }
    }
}
