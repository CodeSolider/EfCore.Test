using System;
using System.Collections.Generic;

#nullable disable

namespace EbayPlatform.DataBase.Models
{
    public partial class EbayOrder
    {
        public string OrderNo { get; set; }
        public string ExtendedOrderId { get; set; }
        public string ApiUserId { get; set; }
        public string OrderStatus { get; set; }
        public string AdjustmentAmountCurrenycy { get; set; }
        public double AdjustmentAmountValue { get; set; }
        public string AmountPaidCurrenycy { get; set; }
        public double AmountPaidValue { get; set; }
        public string AmountSavedCurrenycy { get; set; }
        public double AmountSavedValue { get; set; }
        public string TotalCurrenycy { get; set; }
        public double TotalValue { get; set; }
        public string BuyerCheckoutMessage { get; set; }
        public string BuyerUserId { get; set; }
        public string CheckoutStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public string RefundAmountCurrenycy { get; set; }
        public double RefundAmountValue { get; set; }
        public string RefundStatus { get; set; }
        public bool IsMultiLegShipping { get; set; }
        public string SellerUserId { get; set; }
        public string CancelReason { get; set; }
        public long OrderLineItemCount { get; set; }
        public string SellerEmail { get; set; }
        public DateTime? PaidTime { get; set; }
        public DateTime? ShippedTime { get; set; }
        public string AddressId { get; set; }
        public string ReferenceId { get; set; }
        public string ReferenceIdtype { get; set; }
        public DateTime? PaymentTime { get; set; }
        public DateTime SyncCreateDate { get; set; }
        public DateTime? SyncUpdateDate { get; set; }
    }
}
