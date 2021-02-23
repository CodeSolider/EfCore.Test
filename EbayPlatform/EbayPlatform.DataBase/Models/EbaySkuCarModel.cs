using System;
using System.Collections.Generic;

#nullable disable

namespace EbayPlatform.DataBase.Models
{
    public partial class EbaySkuCarModel
    {
        public string Sku { get; set; }
        public string SiteCode { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Total { get; set; }
        public int ModelTotal { get; set; }
        public int MakeTotal { get; set; }
        public int TrimTotal { get; set; }
        public int EngineTotal { get; set; }
        public int YearTotal { get; set; }
        public string Remark { get; set; }
        public DateTime SyncCreateDate { get; set; }
        public DateTime? SyncUpdateDate { get; set; }
    }
}
