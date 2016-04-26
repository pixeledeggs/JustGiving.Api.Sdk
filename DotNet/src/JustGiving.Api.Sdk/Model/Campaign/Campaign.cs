using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace JustGiving.Api.Sdk.Model.Campaign
{
    public class Campaign
    {
        [DataMember(Name = "totalRaised")]
        public decimal TotalRaised { get; set; }
    }
}
