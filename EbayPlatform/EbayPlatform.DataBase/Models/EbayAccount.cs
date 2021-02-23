using System;
using System.Collections.Generic;

#nullable disable

namespace EbayPlatform.DataBase.Models
{
    public partial class EbayAccount
    {
        public int Id { get; set; }
        public string AccountId { get; set; }
        public string ApiUserId { get; set; }
        public string Currency { get; set; }
        public int? AccountState { get; set; }
        public string AccountStateName { get; set; }
        public string InvoicePaymentCurrenycy { get; set; }
        public double? InvoicePaymentValue { get; set; }
        public string InvoiceCreditCurrency { get; set; }
        public double? InvoiceCreditValue { get; set; }
        public string InvoiceNewFeeCurrenycy { get; set; }
        public double? InvoiceNewFeeValue { get; set; }
        public string AmountPastDueCurrency { get; set; }
        public double? AmountPastDueValue { get; set; }
        public string BankAccountInfo { get; set; }
        public DateTime? BankModifyDate { get; set; }
        public int? BillingCycleDate { get; set; }
        public DateTime? CreditCardExpiration { get; set; }
        public string CreditCardInfo { get; set; }
        public string CurrentBalanceCurrency { get; set; }
        public double? CurrentBalanceValue { get; set; }
        public string Email { get; set; }
        public string InvoiceBalanceCurrency { get; set; }
        public double? InvoiceBalanceValue { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string LastAmountPaidCurrency { get; set; }
        public double? LastAmountPaidValue { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public bool? PastDue { get; set; }
        public int? PaymentMethod { get; set; }
        public string PaymentMethodName { get; set; }
        public DateTime? CreditCardModifyDate { get; set; }
        public string AccountCode { get; set; }
        public string BalanceCurrency { get; set; }
        public double? BalanceValue { get; set; }
        public string AdditionalAccountCurrency { get; set; }
        public DateTime SyncCreateDate { get; set; }
        public DateTime? SyncUpdateDate { get; set; }
    }
}
