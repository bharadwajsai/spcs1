using System;
using System.Collections.Generic;

namespace Models.Ad.Entities
{
    public class Asset
    {
        public Guid AssetId { get; set; }
        public string Json { get; set; }

        public ICollection<Ad> Ads { get; set; }
    }
}
