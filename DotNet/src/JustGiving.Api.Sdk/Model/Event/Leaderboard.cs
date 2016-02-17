using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace JustGiving.Api.Sdk.Model.Event
{
    [DataContract(Name = "eventLeaderboard", Namespace = "")]
    public class Leaderboard
    {
        [DataMember(Name = "currency")]
        public string Current { get; set; }

        [DataMember(Name = "eventName")]
        public string EventName { get; set; }

        [DataMember(Name = "pages")]
        public IList<LeaderboardPageSummary> Pages { get; set; }

        [DataMember(Name = "raisedAmount")]
        public decimal RaisedAmount { get; set; }
    }

    [DataContract(Name = "page", Namespace = "")]
    public class LeaderboardPageSummary
    {
        [DataMember(Name = "amount")]
        public decimal Amount { get; set; }

        [DataMember(Name = "defaultImage")]
        public string DefaultImage { get; set; }

        [DataMember(Name = "owner")]
        public string Owner { get; set; }

        [DataMember(Name = "ownerProfileImageUrl")]
        public string OwnerProfileImageUrl { get; set; }

        [DataMember(Name = "pageShortName")]
        public string PageShortName { get; set; }

        [DataMember(Name = "pageTitle")]
        public string PageTitle { get; set; }

        [DataMember(Name = "targetAmount")]
        public string TargetAmount { get; set; }
    }
}
