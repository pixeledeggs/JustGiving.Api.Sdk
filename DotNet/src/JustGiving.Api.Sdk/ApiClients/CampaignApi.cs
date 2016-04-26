using JustGiving.Api.Sdk.Http;
using JustGiving.Api.Sdk.Model.Campaign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustGiving.Api.Sdk.ApiClients
{
    public class CampaignApi : ApiClientBase, ICampaignApi
    {
        public override string ResourceBase
        {
            get { return "{apiKey}/v{apiVersion}/charity"; }
        }

        public CampaignApi(HttpChannel channel)
            : base(channel)
        {
        }

        public string RetrieveLocationFormat(string charityName, string campaignName)
        {
            return ResourceBase + "/" + charityName + "/" + campaignName;
        }

        public Campaign Retrieve(string charityName, string campaignName)
        {
            var locationFormat = RetrieveLocationFormat(charityName, campaignName);
            return HttpChannel.PerformRequest<Campaign>("GET", locationFormat);
        }
    }
}
