using System;
using System.Collections.Generic;

#nullable disable

namespace EbayPlatform.DataBase.Models
{
    public partial class SyncJobConfig
    {
        public int Id { get; set; }
        public string ApiUserId { get; set; }
        public string JobName { get; set; }
        public string AssemblyName { get; set; }
        public string ClassName { get; set; }
        public string JobGroup { get; set; }
        public string JobDisplayName { get; set; }
        public string CronString { get; set; }
        public string CronDescription { get; set; }
        public int RunTimes { get; set; }
        public bool IsStart { get; set; }
        public DateTime? NextRunTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
