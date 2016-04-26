using JustGiving.Api.Sdk.Model.Campaign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustGiving.Api.Sdk.ApiClients
{
    public interface ICampaignApi
    {
        Campaign Retrieve(string charityName, string campaignName);
    }
}
