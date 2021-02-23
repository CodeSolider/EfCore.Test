using System;
using System.Collections.Generic;

#nullable disable

namespace EbayPlatform.DataBase.Models
{
    public partial class EbayProduct
    {
        public string ItemId { get; set; }
        public string ApiUserId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ParentSku { get; set; }
        public string Ycsku { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ListingStatus { get; set; }
        public string ProductPriceCurrency { get; set; }
        public decimal? ProductPrice { get; set; }
        public int? StockNum { get; set; }
        public decimal? PackageLength { get; set; }
        public string PackageLengthUnit { get; set; }
        public decimal? PackageWidth { get; set; }
        public string PackageWidthUnit { get; set; }
        public decimal? PackageHeight { get; set; }
        public string PackageHeightUnit { get; set; }
        public decimal? GrossWeight { get; set; }
        public string GrossWeightUnit { get; set; }
        public string ProductViewUrl { get; set; }
        public string ListingType { get; set; }
        public string ShippingDiscountProfileId { get; set; }
        public string InternationalShippingDiscountProfileId { get; set; }
        public int QuantitySold { get; set; }
        public long WatchCount { get; set; }
        public long HitCount { get; set; }
        public string SiteCode { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int ValidDays { get; set; }
        public DateTime? OfflineDate { get; set; }
        public string OfflineReason { get; set; }
        public string ListingDuration { get; set; }
        public string PayPalEmailAddress { get; set; }
        public string Location { get; set; }
        public string ShippingService { get; set; }
        public string ShippingServiceCostCurrency { get; set; }
        public decimal? ShippingServiceCostValue { get; set; }
        public string ShippingServiceAdditionalCostCurrency { get; set; }
        public decimal? ShippingServiceAdditionalCostValue { get; set; }
        public int? ShippingServicePriority { get; set; }
        public DateTime SyncCreateDate { get; set; }
        public DateTime? SyncUpdateDate { get; set; }
    }
}
