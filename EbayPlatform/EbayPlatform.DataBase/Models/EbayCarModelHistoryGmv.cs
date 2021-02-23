using System;
using System.Collections.Generic;

#nullable disable

namespace EbayPlatform.DataBase.Models
{
    public partial class EbayCarModelHistoryGmv
    {
        public int Id { get; set; }
        public int DataSoure { get; set; }
        public string SiteCode { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int EbaySirank { get; set; }
        public int EbayGmvrank { get; set; }
        public int Gmv { get; set; }
        public int CarParc { get; set; }
        public string Remark { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
