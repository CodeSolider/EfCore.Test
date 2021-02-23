using System;
using System.Collections.Generic;

#nullable disable

namespace EbayPlatform.DataBase.Models
{
    public partial class EbayCarModel
    {
        public string Epid { get; set; }
        public string Aspiration { get; set; }
        public string Body { get; set; }
        public string CylinderTypeName { get; set; }
        public string DisplayName { get; set; }
        public string DriveType { get; set; }
        public string Engine { get; set; }
        public string EngineBlockType { get; set; }
        public string EngineCc { get; set; }
        public string EngineCid { get; set; }
        public string EngineCylinders { get; set; }
        public string EngineLiterDisplay { get; set; }
        public string FuelTypeName { get; set; }
        public string KbbModel { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string NumDoors { get; set; }
        public string PartsModel { get; set; }
        public string Submodel { get; set; }
        public string Trim { get; set; }
        public string Year { get; set; }
        public string Region { get; set; }
        public string SiteCode { get; set; }
        public int SkuCount { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
