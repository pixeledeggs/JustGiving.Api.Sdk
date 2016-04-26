﻿using System;
using JustGiving.Api.Sdk.ApiClients;
using JustGiving.Api.Sdk.Http;

namespace JustGiving.Api.Sdk
{
    public abstract class JustGivingClientBase : IJustGivingClient
    {
        public IAccountApi Account { get; set; }
        public IDonationApi Donation { get; set; }
        public IPageApi Page { get; set; }
        public ISearchApi Search { get; set; }
        public ICharityApi Charity { get; set; }
        public IEventApi Event { get; set; }
        public ITeamApi Team { get; set; }
        public IOneSearchApi OneSearch { get; set; }
        public ICountryApi Country { get; set; }
        public ICurrencyApi Currency { get; set; }
        public IProjectApi Project { get; set; }
        public ICampaignApi Campaign { get; set; }

        public string WhiteLabelDomain { get; private set; }
        public IHttpClient HttpClient { get; private set; }

        protected internal ClientConfiguration Configuration { get; private set; }
        public HttpChannel HttpChannel { get; private set; }

        protected JustGivingClientBase(ClientConfiguration clientConfiguration, IHttpClient httpClient)
            : this(clientConfiguration, httpClient, null, null, null, null, null, null, null, null, null, null, null, null)
        {
        }

        protected JustGivingClientBase(ClientConfiguration clientConfiguration,
                                       IHttpClient httpClient,
                                       IAccountApi accountApi,
                                       IDonationApi donationApi,
                                       IPageApi pageApi,
                                       ISearchApi searchApi,
                                       ICharityApi charityApi,
                                       IEventApi eventApi,
                                       ITeamApi teamApi, IOneSearchApi oneSearch,
                                       ICountryApi country, ICurrencyApi currency,
                                       IProjectApi project, ICampaignApi campaign)
        {
            if (httpClient == null)
            {
                throw new ArgumentNullException("httpClient", "httpClient must not be null to access the api.");
            }

            HttpClient = httpClient;
            HttpClient.ConnectionTimeOut = TimeSpan.FromMinutes(3);

            Account = accountApi;
            Donation = donationApi;
            Page = pageApi;
            Search = searchApi;
            Charity = charityApi;
            Event = eventApi;
            Team = teamApi;
            OneSearch = oneSearch;
            Country = country;
            Currency = currency;
            Project = project;
            Campaign = campaign;

            Configuration = clientConfiguration;

            InitApis(HttpClient, clientConfiguration);
        }

        public void SetWhiteLabelDomain(string domain)
        {
            WhiteLabelDomain = domain;
            Configuration.WhiteLabelDomain = domain;
        }

        public void InitApis(IHttpClient httpClient, ClientConfiguration clientConfiguration)
        {
            HttpChannel = new HttpChannel(clientConfiguration, httpClient);

            Account = Account ?? new AccountApi(HttpChannel);
            Donation = Donation ?? new DonationApi(HttpChannel);
            Page = Page ?? new PageApi(HttpChannel);
            Search = Search ?? new SearchApi(HttpChannel);
            Charity = Charity ?? new CharityApi(HttpChannel);
            Event = Event ?? new EventApi(HttpChannel);
            Team = Team ?? new TeamApi(HttpChannel);
            OneSearch = OneSearch ?? new OneSearchApi(HttpChannel);
            Country = Country ?? new CountryApi(HttpChannel);
            Currency = Currency ?? new CurrencyApi(HttpChannel);
            Project = Project ?? new ProjectApi(HttpChannel);
            Campaign = Campaign ?? new CampaignApi(HttpChannel);
        }

        public void UpdateConfiguration(ClientConfiguration configuration)
        {
            Configuration = configuration;
            InitApis(HttpClient, configuration);
        }
    }
}
