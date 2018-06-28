using System;
using System.Collections.Generic;
using System.Text;

namespace models.ad.controllerparam
{
    public class PostAd
    {
        public string Name { get; set; }
        public string Occupation { get; set; }

        public object ConvertToAnonymousType(PostAd input)
        {
            return new { Name = input.Name, Occupation = input.Occupation  };
        }
    }
}
