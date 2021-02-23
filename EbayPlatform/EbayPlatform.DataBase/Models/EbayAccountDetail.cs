using System;
using System.Collections.Generic;

#nullable disable

namespace EbayPlatform.DataBase.Models
{
    public partial class EbayAccountDetail
    {
        public int Id { get; set; }
        public int EbayAccountId { get; set; }
        public string RefNumber { get; set; }
        public int? AccountDetailsType { get; set; }
        public string AccountDetailsName { get; set; }
        public string Description { get; set; }
        public string GrossDetailAmountCurrency { get; set; }
        public double? GrossDetailAmountValue { get; set; }
        public string ItemId { get; set; }
        public string Memo { get; set; }
        public string ConversionRateCurrency { get; set; }
        public double? ConversionRateValue { get; set; }
        public string NetDetailAmountCurrency { get; set; }
        public double? NetDetailAmountValue { get; set; }
        public decimal? Vatpercent { get; set; }
        public string Title { get; set; }
        public string OrderLineItemId { get; set; }
        public string TransactionId { get; set; }
        public string OrderId { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime SyncCreateDate { get; set; }
        public DateTime? SyncUpdateDate { get; set; }
    }
}
