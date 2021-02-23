using System;
using System.Collections.Generic;

#nullable disable

namespace EbayPlatform.DataBase.Models
{
    public partial class EbayOrderDetail
    {
        public string OrderLineItemId { get; set; }
        public string OrderNo { get; set; }
        public string ItemId { get; set; }
        public string TransactionId { get; set; }
        public int QuantityPurchased { get; set; }
        public string TransactionPriceCurrenycy { get; set; }
        public double TransactionPriceValue { get; set; }
        public string TotalPriceCurrenycy { get; set; }
        public double TotalPriceValue { get; set; }
        public DateTime SyncCreateDate { get; set; }
        public DateTime? SyncUpdateDate { get; set; }
    }
}
