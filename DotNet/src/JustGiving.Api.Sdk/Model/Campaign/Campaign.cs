using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace JustGiving.Api.Sdk.Model.Campaign
{
    [DataContract(Name = "campaign", Namespace = "http://schemas.datacontract.org/2004/07/GG.Api.Services.Dto.Campaign")]
    public class Campaign
    {
        [DataMember(Name = "campaignPageName")]
        public string CampaignPageName { get; set; }

        [DataMember(Name = "campaignUrl")]
        public string CampaignUrl { get; set; }

        [DataMember(Name = "causeId")]
        public int CauseId { get; set; }

        [DataMember(Name = "charityId")]
        public int CharityId { get; set; }

        [DataMember(Name = "charityLogoUrl")]
        public string CharityLogoUrl { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "fundraisingEnabled")]
        public bool FundraisingEnabled { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "images")]
        public IEnumerable<Image> Images { get; set; }

        [DataMember(Name = "numberOfDirectDonations")]
        public int DirectDonationsCount { get; set; }

        [DataMember(Name = "numberOfFundraisersConnected")]
        public int ConnectedFundraisersCount { get; set; }

        [DataMember(Name = "story")]
        public string Story { get; set; }

        [DataMember(Name = "target")]
        public decimal Target { get; set; }

        [DataMember(Name = "targetPercentage")]
        public decimal TargetPercentage { get; set; }

        [DataMember(Name = "totalDonated")]
        public decimal TotalDonated { get; set; }

        [DataMember(Name = "totalFundraised")]
        public decimal TotalFundraised { get; set; }

        [DataMember(Name = "totalOffline")]
        public decimal TotalOffline { get; set; }

        [DataMember(Name = "totalRaised")]
        public decimal TotalRaised { get; set; }
    }
}
