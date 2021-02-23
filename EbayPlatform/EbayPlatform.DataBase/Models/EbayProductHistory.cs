using System;
using System.Collections.Generic;

#nullable disable

namespace EbayPlatform.DataBase.Models
{
    public partial class EbayProductHistory
    {
        public int Id { get; set; }
        public string ItemId { get; set; }
        public string ApiUserId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? BidCount { get; set; }
        public string CurrentPriceCurrency { get; set; }
        public double? CurrentPriceValue { get; set; }
        public int? QuantitySold { get; set; }
        public string ListingStatus { get; set; }
        public int? Quantity { get; set; }
        public string Currency { get; set; }
        public string HitCounter { get; set; }
        public long? HitCount { get; set; }
        public bool? EbayPlus { get; set; }
        public bool? EbayPlusEligible { get; set; }
        public string EbayNotes { get; set; }
        public DateTime TimeTo { get; set; }
        public DateTime SyncCreateDate { get; set; }
        public DateTime? SyncUpdateDate { get; set; }
    }
}
