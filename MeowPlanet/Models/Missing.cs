using System;
using System.Collections.Generic;

namespace MeowPlanet.Models
{
    public partial class Missing
    {
        public int MissingId { get; set; }
        public int? CatId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lng { get; set; }
        public int? Reward { get; set; }
        public string? Description { get; set; }
        public bool? Found { get; set; }
    }
}
