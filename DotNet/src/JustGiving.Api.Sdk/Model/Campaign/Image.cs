using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace JustGiving.Api.Sdk.Model.Campaign
{
    [DataContract(Name = "campaignImage", Namespace = "http://schemas.datacontract.org/2004/07/GG.Api.Services.Dto.Campaign")]
    public class Image
    {
        [DataMember(Name = "alt")]
        public string Alt { get; set; }

        [DataMember(Name = "caption")]
        public string Caption { get; set; }

        [DataMember(Name = "filename")]
        public string Filename { get; set; }

        [DataMember(Name = "isHeroImage")]
        public bool IsHeroImage { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }
    }
}
