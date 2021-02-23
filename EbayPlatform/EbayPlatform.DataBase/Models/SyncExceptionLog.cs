using System;
using System.Collections.Generic;

#nullable disable

namespace EbayPlatform.DataBase.Models
{
    public partial class SyncExceptionLog
    {
        public int ExceptionId { get; set; }
        public int JobConfigId { get; set; }
        public string Message { get; set; }
        public string StackMessage { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
