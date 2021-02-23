using System;
using System.Collections.Generic;

#nullable disable

namespace EbayPlatform.DataBase.Models
{
    public partial class SyncRecord
    {
        public int RecordId { get; set; }
        public string ApiUserId { get; set; }
        public string JobName { get; set; }
        public int? CurrentPage { get; set; }
        public int? CurrentDownloadTotal { get; set; }
        public DateTime SyncLastDate { get; set; }
        public DateTime SyncCreateDate { get; set; }
        public DateTime? SyncUpdateDate { get; set; }
    }
}
