using System;
using System.Collections.Generic;
using System.Text;

namespace models.ad
{
    public class AdAsset
    {
        public Guid AdAssetId { get; set; }
        public Int64 AdId { get; set; }
        public string Json { get; set; }
    }
}
