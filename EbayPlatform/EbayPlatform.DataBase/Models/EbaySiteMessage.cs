using System;
using System.Collections.Generic;

#nullable disable

namespace EbayPlatform.DataBase.Models
{
    public partial class EbaySiteMessage
    {
        public string MessageId { get; set; }
        public string ExternalMessageId { get; set; }
        public string ApiUserId { get; set; }
        public string ItemId { get; set; }
        public string ItemTitle { get; set; }
        public DateTime? ItemEndTime { get; set; }
        public string Sender { get; set; }
        public string RecipientUserId { get; set; }
        public string SendToName { get; set; }
        public string Subject { get; set; }
        public string ContentType { get; set; }
        public string Content { get; set; }
        public string Text { get; set; }
        public string QuestionType { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public bool? Read { get; set; }
        public bool? Replied { get; set; }
        public bool? Flagged { get; set; }
        public bool? HighPriority { get; set; }
        public bool? ResponseEnabled { get; set; }
        public string ResponseUrl { get; set; }
        public DateTime? UserResponseDate { get; set; }
        public DateTime SyncCreateDate { get; set; }
        public DateTime? SyncUpdateDate { get; set; }
    }
}
