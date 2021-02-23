using System;
using System.Collections.Generic;

#nullable disable

namespace EbayPlatform.DataBase.Models
{
    public partial class EbaySkuCarModelDetail
    {
        public int DetailId { get; set; }
        public string Sku { get; set; }
        public string Epid { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Trim { get; set; }
        public string Engine { get; set; }
        public string Year { get; set; }
        public string CompRemark { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime SyncCreateDate { get; set; }
        public DateTime? SyncUpdateDate { get; set; }
    }
}
