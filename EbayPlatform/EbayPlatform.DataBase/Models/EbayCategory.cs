using System;
using System.Collections.Generic;

#nullable disable

namespace EbayPlatform.DataBase.Models
{
    public partial class EbayCategory
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryParentId { get; set; }
        public int CategoryLevel { get; set; }
        public string Keywords { get; set; }
        public bool IntlAutosFixedCat { get; set; }
        public bool AutoPayEnabled { get; set; }
        public bool LeafCategory { get; set; }
        public bool IsFixedSize { get; set; }
        public bool Expired { get; set; }
        public int NumOfItems { get; set; }
        public DateTime SyncCreateDate { get; set; }
        public DateTime? SyncUpdateDate { get; set; }
    }
}
