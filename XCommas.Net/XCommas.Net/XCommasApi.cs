using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XCommas.Net.Objects;
using XCommas.Net.Objects.SmartTrades;
using Account = XCommas.Net.Objects.Account;

namespace XCommas.Net
{
    public class XCommasApi : ICredentialsBearer
    {
        private const string BaseAddress = "https://api.3commas.io/public/api";
        private readonly JsonSerializer DefaultSerializer = JsonSerializer.Create(new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore
        });

        private HttpClient HttpClientSingleton => _httpClientSingleton ?? (_httpClientSingleton = new HttpClient());

        private readonly IHttpClientFactory _httpClientFactory;
        private HttpClient _httpClientSingleton;
        public UserMode UserMode { get; set; }
        public string ApiKey { get; set; }
        public string Secret { get; set; }

        public XCommasApi(string apiKey, string secret, IHttpClientFactory httpClientFactory = null, UserMode userMode = UserMode.Real)
        {
            this.ApiKey = apiKey;
            this.Secret = secret;
            this._httpClientFactory = httpClientFactory;
            this.UserMode = userMode;
        }

        #region Deals

        public XCommasResponse<Deal[]> GetDeals(int limit = 50, int? offset = null, int? accountId = null, int? botId = null, DealScope dealScope = DealScope.All, DealOrder dealOrder = DealOrder.CreatedAt) => this.GetDealsAsync(limit, offset, accountId, botId, dealScope, dealOrder).Result;
        public async Task<XCommasResponse<Deal[]>> GetDealsAsync(int limit = 50, int? offset = null, int? accountId = null, int? botId = null, DealScope dealScope = DealScope.All, DealOrder dealOrder = DealOrder.CreatedAt)
        {
            var path = $"{BaseAddress}/ver1/deals?limit={limit}&offset={offset}&account_id={accountId}&bot_id={botId}&scope={dealScope.GetEnumMemberAttrValue()}&order={dealOrder.GetEnumMemberAttrValue()}";
            using (var request = XCommasRequest.Get(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Deal[]>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Deal> UpdateMaxSafetyOrders(int dealId, int maxSafetyOrders) => this.UpdateMaxSafetyOrdersAsync(dealId, maxSafetyOrders).Result;
        public async Task<XCommasResponse<Deal>> UpdateMaxSafetyOrdersAsync(int dealId, int maxSafetyOrders)
        {
            var path = $"{BaseAddress}/ver1/deals/{dealId}/update_max_safety_orders";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(new UpdateMaxSafetyOrderData { MaxSafetyOrders = maxSafetyOrders }).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Deal>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Deal> PanicSellDeal(int dealId) => this.PanicSellDealAsync(dealId).Result;
        public async Task<XCommasResponse<Deal>> PanicSellDealAsync(int dealId)
        {
            var path = $"{BaseAddress}/ver1/deals/{dealId}/panic_sell";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Deal>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Deal> CancelDeal(int dealId) => this.CancelDealAsync(dealId).Result;
        public async Task<XCommasResponse<Deal>> CancelDealAsync(int dealId)
        {
            var path = $"{BaseAddress}/ver1/deals/{dealId}/cancel";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Deal>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Deal> ShowDeal(int dealId) => this.ShowDealAsync(dealId).Result;
        public async Task<XCommasResponse<Deal>> ShowDealAsync(int dealId)
        {
            var path = $"{BaseAddress}/ver1/deals/{dealId}/show";
            using (var request = XCommasRequest.Get(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Deal>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Deal> UpdateDeal(int dealId, DealUpdateData data) => this.UpdateDealAsync(dealId, data).Result;
        public async Task<XCommasResponse<Deal>> UpdateDealAsync(int dealId, DealUpdateData data)
        {
            var path = $"{BaseAddress}/ver1/deals/{dealId}/update_deal";
            using (var request = XCommasRequest.Patch(path).WithSerializedContent(data).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Deal>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Deal> AddFundsToDeal(DealAddFundsParameters data) => this.AddFundsToDealAsync(data).Result;
        public async Task<XCommasResponse<Deal>> AddFundsToDealAsync(DealAddFundsParameters data)
        {
            var path = $"{BaseAddress}/ver1/deals/{data.DealId}/add_funds";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(data).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Deal>(request).ConfigureAwait(false);
            }
        }

        #endregion

        #region Accounts
        public XCommasResponse<Account[]> GetAccounts => this.GetAccountsAsync().Result;
        public async Task<XCommasResponse<Account[]>> GetAccountsAsync()
        {
            var path = $"{BaseAddress}/ver1/accounts";
            using (var request = XCommasRequest.Get(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Account[]>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Market[]> GetMarkets() => this.GetMarketsAsync().Result;
        public async Task<XCommasResponse<Market[]>> GetMarketsAsync()
        {
            var path = $"{BaseAddress}/ver1/accounts/market_list";
            using (var request = XCommasRequest.Get(path))
            {
                return await this.GetResponse<Market[]>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<string[]> GetMarketPairs(string marketCode) => this.GetMarketPairsAsync(marketCode).Result;
        public async Task<XCommasResponse<string[]>> GetMarketPairsAsync(string marketCode)
        {
            var path = $"{BaseAddress}/ver1/accounts/market_pairs?market_code={marketCode}";
            using (var request = XCommasRequest.Get(path))
            {
                return await this.GetResponse<string[]>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<string> CreateAccount(AccountCreateData data) => this.CreateAccountAsync(data).Result;
        public async Task<XCommasResponse<string>> CreateAccountAsync(AccountCreateData data)
        {
            var path = $"{BaseAddress}/ver1/accounts/new";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(data).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<string>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<CurrencyRate> GetCurrencyRate(string pair, string marketcode = "binance") => this.GetCurrencyRateAsync(pair, marketcode).Result;
        public async Task<XCommasResponse<CurrencyRate>> GetCurrencyRateAsync(string pair, string marketcode = "binance")
        {
            var path = $"{BaseAddress}/ver1/accounts/currency_rates?market_code={marketcode}&pair={pair}";
            using (var request = XCommasRequest.Get(path))
            {
                return await this.GetResponse<CurrencyRate>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<string> SellAllToUsd(int accountId) => this.SellAllToUsdAsync(accountId).Result;
        public async Task<XCommasResponse<string>> SellAllToUsdAsync(int accountId)
        {
            var path = $"{BaseAddress}/ver1/accounts/{accountId}/sell_all_to_usd";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<string>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<string> SellAllToBtc(int accountId) => this.SellAllToBtcAsync(accountId).Result;
        public async Task<XCommasResponse<string>> SellAllToBtcAsync(int accountId)
        {
            var path = $"{BaseAddress}/ver1/accounts/{accountId}/sell_all_to_btc";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<string>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Account> LoadBalances(int accountId) => this.LoadBalancesAsync(accountId).Result;
        public async Task<XCommasResponse<Account>> LoadBalancesAsync(int accountId)
        {
            var path = $"{BaseAddress}/ver1/accounts/{accountId}/load_balances";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Account>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Account> RenameAccount(int accountId, string name) => this.RenameAccountAsync(accountId, name).Result;
        public async Task<XCommasResponse<Account>> RenameAccountAsync(int accountId, string name)
        {
            var path = $"{BaseAddress}/ver1/accounts/{accountId}/rename";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(new RenameAccountData { NewName = name }).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Account>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<PieChartPiece[]> GetPieChartData(int accountId) => this.GetPieChartDataAsync(accountId).Result;
        public async Task<XCommasResponse<PieChartPiece[]>> GetPieChartDataAsync(int accountId)
        {
            var path = $"{BaseAddress}/ver1/accounts/{accountId}/pie_chart_data";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<PieChartPiece[]>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<AccountTableData[]> GetAccountTableData(int accountId) => this.GetAccountTableDataAsync(accountId).Result;
        public async Task<XCommasResponse<AccountTableData[]>> GetAccountTableDataAsync(int accountId)
        {
            var path = $"{BaseAddress}/ver1/accounts/{accountId}/account_table_data";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<AccountTableData[]>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<string> RemoveAccount(int accountId) => this.RemoveAccountAsync(accountId).Result;
        public async Task<XCommasResponse<string>> RemoveAccountAsync(int accountId)
        {
            var path = $"{BaseAddress}/ver1/accounts/{accountId}/remove";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<string>(request).ConfigureAwait(false);
            }
        }

        #endregion

        #region Grid Bots

        public XCommasResponse<GridBot[]> GetGridBots(int limit = 10, int? offset = null, int[] accountIds = null, string accountTypes = null, BotScope? botState = null, string sortBy = "bot_id", string sortDirection = "asc") => this.GetGridBotsAsync(limit, offset, accountIds, accountTypes, botState, sortBy, sortDirection).Result;
        public async Task<XCommasResponse<GridBot[]>> GetGridBotsAsync(int limit = 10, int? offset = null, int[] accountIds = null, string accountTypes = null, BotScope? botState = null, string sortBy = "bot_id", string sortDirection = "asc")
        {
            var path = $"{BaseAddress}/ver1/grid_bots?limit={limit}&offset={offset}&sort_by={sortBy}&sort_direction={sortDirection}";
            if (botState.HasValue) path += $"&state={botState.GetEnumMemberAttrValue()}";

            using (var request = XCommasRequest.Get(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<GridBot[]>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<GridBot> CreateGridBot(int accountId, GridBotData data) => this.CreateGridBotAsync(accountId, data).Result;
        public async Task<XCommasResponse<GridBot>> CreateGridBotAsync(int accountId, GridBotData data)
        {
            var path = $"{BaseAddress}/ver1/grid_bots/manual";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(new GridBotCreateData(accountId, data)).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<GridBot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<GridBot> UpdateGridBot(int gridBotId, GridBotData data) => this.UpdateGridBotAsync(gridBotId, data).Result;
        public async Task<XCommasResponse<GridBot>> UpdateGridBotAsync(int gridBotId, GridBotData data)
        {
            var path = $"{BaseAddress}/ver1/grid_bots/{gridBotId}/manual";
            using (var request = XCommasRequest.Patch(path).WithSerializedContent(new GridBotUpdateData(gridBotId, data)).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<GridBot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<GridBot> DisableGridBot(int gridBotId) => this.DisableGridBotAsync(gridBotId).Result;
        public async Task<XCommasResponse<GridBot>> DisableGridBotAsync(int gridBotId)
        {
            var path = $"{BaseAddress}/ver1/grid_bots/{gridBotId}/disable";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<GridBot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<GridBot> EnableGridBot(int gridBotId) => this.EnableGridBotAsync(gridBotId).Result;
        public async Task<XCommasResponse<GridBot>> EnableGridBotAsync(int gridBotId)
        {
            var path = $"{BaseAddress}/ver1/grid_bots/{gridBotId}/enable";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<GridBot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<bool> DeleteGridBot(int gridBotId) => this.DeleteGridBotAsync(gridBotId).Result;
        public async Task<XCommasResponse<bool>> DeleteGridBotAsync(int gridBotId)
        {
            var path = $"{BaseAddress}/ver1/grid_bots/{gridBotId}/delete";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<bool>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<GridBot> ShowGridBot(int botId) => this.ShowGridBotAsync(botId).Result;
        public async Task<XCommasResponse<GridBot>> ShowGridBotAsync(int botId)
        {
            var path = $"{BaseAddress}/ver1/grid_bots/{botId}";
            using (var request = XCommasRequest.Get(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<GridBot>(request).ConfigureAwait(false);
            }
        }

        #endregion

        #region Bots

        public XCommasResponse<BotPairsBlackListData> GetBotPairsBlackList => this.GetBotPairsBlackListAsync().Result;
        public async Task<XCommasResponse<BotPairsBlackListData>> GetBotPairsBlackListAsync()
        {
            var path = $"{BaseAddress}/ver1/bots/pairs_black_list";
            using (var request = XCommasRequest.Get(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<BotPairsBlackListData>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<bool> SetBotPairsBlackList(BotPairsBlackListData data) => this.SetBotPairsBlackListAsync(data).Result;
        public async Task<XCommasResponse<bool>> SetBotPairsBlackListAsync(BotPairsBlackListData data)
        {
            var path = $"{BaseAddress}/ver1/bots/update_pairs_black_list";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(data).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<bool>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot> CreateBot(int accountId, Strategy strategy, BotData data) => this.CreateBotAsync(accountId, strategy, data).Result;
        public async Task<XCommasResponse<Bot>> CreateBotAsync(int accountId, Strategy strategy, BotData data)
        {
            var path = $"{BaseAddress}/ver1/bots/create_bot";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(new BotCreateData(accountId, strategy, data)).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Bot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot[]> GetBots(int limit = 50, int? offset = null, int? accountId = null, int? botId = null, BotScope? botScope = null, Strategy? strategy = null) => this.GetBotsAsync(limit, offset, accountId, botId, botScope, strategy).Result;
        public async Task<XCommasResponse<Bot[]>> GetBotsAsync(int limit = 50, int? offset = null, int? accountId = null, int? botId = null, BotScope? botScope = null, Strategy? strategy = null)
        {
            var path = $"{BaseAddress}/ver1/bots?limit={limit}&offset={offset}&account_id={accountId}&bot_id={botId}";
            if (botScope.HasValue) path += $"&scope={botScope.GetEnumMemberAttrValue()}";
            if (strategy.HasValue) path += $"&strategy={strategy.GetEnumMemberAttrValue()}";

            using (var request = XCommasRequest.Get(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Bot[]>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<BotStats> GetBotStats() => this.GetBotStatsAsync().Result;
        public async Task<XCommasResponse<BotStats>> GetBotStatsAsync()
        {
            var path = $"{BaseAddress}/ver1/bots/stats";
            using (var request = XCommasRequest.Get(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<BotStats>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot> UpdateBot(int botId, BotUpdateData data) => this.UpdateBotAsync(botId, data).Result;
        public async Task<XCommasResponse<Bot>> UpdateBotAsync(int botId, BotUpdateData data)
        {
            var path = $"{BaseAddress}/ver1/bots/{botId}/update";
            using (var request = XCommasRequest.Patch(path).WithSerializedContent(data).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Bot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot> DisableBot(int botId) => this.DisableBotAsync(botId).Result;
        public async Task<XCommasResponse<Bot>> DisableBotAsync(int botId)
        {
            var path = $"{BaseAddress}/ver1/bots/{botId}/disable";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Bot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot> EnableBot(int botId) => this.EnableBotAsync(botId).Result;
        public async Task<XCommasResponse<Bot>> EnableBotAsync(int botId)
        {
            var path = $"{BaseAddress}/ver1/bots/{botId}/enable";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Bot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot> StartNewDeal(int botId) => this.StartNewDealAsync(botId).Result;
        public async Task<XCommasResponse<Bot>> StartNewDealAsync(int botId, string pair = null, bool skipSignalChecks = false, bool skipOpenDealsChecks = false)
        {
            var path = $"{BaseAddress}/ver1/bots/{botId}/start_new_deal";
            using (var request = XCommasRequest.Post(path)
                .WithSerializedContent(new StartNewDealData { Pair = pair, SkipOpenDealsChecks = skipOpenDealsChecks, SkipSignalChecks = skipSignalChecks }).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Bot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<bool> DeleteBot(int botId) => this.DeleteBotAsync(botId).Result;
        public async Task<XCommasResponse<bool>> DeleteBotAsync(int botId)
        {
            var path = $"{BaseAddress}/ver1/bots/{botId}/delete";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<bool>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot> PanicSellAllBotDeals(int botId) => this.PanicSellAllBotDealsAsync(botId).Result;
        public async Task<XCommasResponse<Bot>> PanicSellAllBotDealsAsync(int botId)
        {
            var path = $"{BaseAddress}/ver1/bots/{botId}/panic_sell_all_deals";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Bot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot> CancelAllBotDeals(int botId) => this.CancelAllBotDealsAsync(botId).Result;
        public async Task<XCommasResponse<Bot>> CancelAllBotDealsAsync(int botId)
        {
            var path = $"{BaseAddress}/ver1/bots/{botId}/cancel_all_deals";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Bot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot> ShowBot(int botId) => this.ShowBotAsync(botId).Result;
        public async Task<XCommasResponse<Bot>> ShowBotAsync(int botId)
        {
            var path = $"{BaseAddress}/ver1/bots/{botId}/show";
            using (var request = XCommasRequest.Get(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<Bot>(request).ConfigureAwait(false);
            }
        }

        #endregion

        #region Marketplace

        public XCommasResponse<MarketplaceItem[]> GetMarketplaceItems(int limit = 50, int? offset = null, SignalProviders scope = SignalProviders.All) => this.GetMarketplaceItemsAsync(limit, offset, scope).Result;
        public async Task<XCommasResponse<MarketplaceItem[]>> GetMarketplaceItemsAsync(int limit = 50, int? offset = null, SignalProviders scope = SignalProviders.All)
        {
            var path = $"{BaseAddress}/ver1/marketplace/items?limit={limit}&offset={offset}&scope={scope.GetEnumMemberAttrValue()}";
            using (var request = XCommasRequest.Get(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<MarketplaceItem[]>(request).ConfigureAwait(false);
            }
        }

        #endregion

        #region Smart trades

        private static string BuildQueryString(Dictionary<string, string> param)
        {
            var qStringBuilder = new StringBuilder();

            if (param != null && param.Count > 0)
            {
                qStringBuilder.Append("?");
                foreach (var p in param)
                {
                    qStringBuilder.Append($"{Uri.EscapeDataString(p.Key)}={Uri.EscapeDataString(p.Value)}&");
                }
                qStringBuilder.Length--;
            }
            return qStringBuilder.ToString();
        }

        private void AddIfHasValue(Dictionary<string, string> dict, string key, string value)
        {
            if (!string.IsNullOrWhiteSpace(value) && !dict.ContainsKey(key))
            {
                dict.Add(key, value);
            }
        }

        public XCommasResponse<SmartTrade[]> GetSmartTrades(int? accountId = null, string pair = null, SmartTradeType? type = null, SmartTradeStatus? status = null, OrderBy? orderBy = null, OrderDirection? orderDirection = null, int? page = null, int? perPage = null) => this.GetSmartTradesAsync(accountId, pair, type, status, orderBy, orderDirection, page, perPage).Result;
        public async Task<XCommasResponse<SmartTrade[]>> GetSmartTradesAsync(int? accountId = null, string pair = null, SmartTradeType? type = null, SmartTradeStatus? status = null, OrderBy? orderBy = null, OrderDirection? orderDirection = null, int? page = null, int? perPage = null)
        {
            var param = new Dictionary<string, string>();
            if (accountId.HasValue)
            {
                param.Add("accountId", accountId.Value.ToString());
            }
            AddIfHasValue(param, "pair", pair);
            AddIfHasValue(param, "type", type?.GetEnumMemberAttrValue());
            AddIfHasValue(param, "status", status?.GetEnumMemberAttrValue());
            AddIfHasValue(param, "order_by", orderBy?.GetEnumMemberAttrValue());
            AddIfHasValue(param, "order_direction", orderDirection?.GetEnumMemberAttrValue());
            AddIfHasValue(param, "page", page.ToString());
            AddIfHasValue(param, "per_page", perPage.ToString());

            var qString = BuildQueryString(param);
            var path = $"{BaseAddress}/v2/smart_trades{qString}";

            using (var request = XCommasRequest.Get(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<SmartTrade[]>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTrade> CreateSmartTrade(SmartTradeCreateRequest request) => this.CreateSmartTradeAsync(request).Result;
        public async Task<XCommasResponse<SmartTrade>> CreateSmartTradeAsync(SmartTradeCreateRequest createRequest)
        {
            var path = $"{BaseAddress}/v2/smart_trades";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(createRequest).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<SmartTrade>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTrade> UpdateSmartTrade(int id, SmartTradeCreateRequest request) => this.UpdateSmartTradeAsync(id, request).Result;
        public async Task<XCommasResponse<SmartTrade>> UpdateSmartTradeAsync(int id, SmartTradeCreateRequest createRequest)
        {
            var path = $"{BaseAddress}/v2/smart_trades/{id}";
            using (var request = XCommasRequest.Patch(path).WithSerializedContent(createRequest).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<SmartTrade>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTrade> GetSmartTrade(int id) => this.GetSmartTradeAsync(id).Result;
        public async Task<XCommasResponse<SmartTrade>> GetSmartTradeAsync(int id)
        {
            var path = $"{BaseAddress}/v2/smart_trades/{id}";
            using (var request = XCommasRequest.Get(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<SmartTrade>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTrade> CancelSmartTrade(int id) => this.CancelSmartTradeAsync(id).Result;
        public async Task<XCommasResponse<SmartTrade>> CancelSmartTradeAsync(int id)
        {
            var path = $"{BaseAddress}/v2/smart_trades/{id}";
            using (var request = XCommasRequest.Delete(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<SmartTrade>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTrade> CloseSmartTradeByMarket(int id) => this.CloseSmartTradeByMarketAsync(id).Result;
        public async Task<XCommasResponse<SmartTrade>> CloseSmartTradeByMarketAsync(int id)
        {
            var path = $"{BaseAddress}/v2/smart_trades/{id}/close_by_market";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<SmartTrade>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTrade> AddFundsToSmartTrade(int id, AddFundsToSmartTradeParams param) => this.AddFundsToSmartTradeAsync(id, param).Result;
        public async Task<XCommasResponse<SmartTrade>> AddFundsToSmartTradeAsync(int id, AddFundsToSmartTradeParams param)
        {
            var path = $"{BaseAddress}/v2/smart_trades/{id}/add_funds";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(param).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<SmartTrade>(request).ConfigureAwait(false);
            }
        }

        #endregion

        #region users

        public XCommasResponse<bool> ChangeUserMode(UserMode userMode) => this.ChangeUserModeAsync(userMode).Result;
        public async Task<XCommasResponse<bool>> ChangeUserModeAsync(UserMode userMode)
        {
            var path = $"{BaseAddress}/ver1/users/change_mode?mode={userMode.GetEnumMemberAttrValue()}";
            using (var request = XCommasRequest.Post(path).Force(UserMode).Sign(this))
            {
                return await this.GetResponse<bool>(request).ConfigureAwait(false);
            }
        }

        #endregion

        #region helper methods
        private async Task<XCommasResponse<T>> GetResponse<T>(XCommasRequest request)
        {
            var validatedResponse = await this.GetValidatedResponse(request).ConfigureAwait(false);

            if (!validatedResponse.IsSuccess) return new XCommasResponse<T>(default(T), validatedResponse.RawData, validatedResponse.Error);

            if (validatedResponse.Data is JObject)
            {
                var wrappedError = validatedResponse.Data["error"]?.Value<string>();
                if (wrappedError != null)
                {
                    var errorMessage = $"{wrappedError} - {validatedResponse.Data["error_description"]?.Value<string>()} - {validatedResponse.Data["error_attributes"]?.ToString()} ";
                    return new XCommasResponse<T>(default(T), validatedResponse.RawData, errorMessage);
                }
            }

            if (typeof(T) == typeof(string)) return new XCommasResponse<T>(default(T), validatedResponse.RawData, null);

            try
            {
                return new XCommasResponse<T>(validatedResponse.Data.ToObject<T>(DefaultSerializer), validatedResponse.RawData, null);
            }
            catch (Exception ex)
            {
                return new XCommasResponse<T>(default(T), validatedResponse.RawData, $"Could not serialize json to {typeof(T).Name} : {ex.ToString()}");
            }
        }

        private async Task<XCommasResponse<JToken>> GetValidatedResponse(XCommasRequest request)
        {
            var rawResponse = await this.GetRawResponse(request).ConfigureAwait(false);

            if (!rawResponse.IsSuccess) return new XCommasResponse<JToken>(null, rawResponse.Data, rawResponse.Error);

            try
            {
                return new XCommasResponse<JToken>(JToken.Parse(rawResponse.Data), rawResponse.Data, null);
            }
            catch (JsonReaderException jre)
            {
                var errorMessage = $"JsonReaderException: {jre.Message}, Path: {jre.Path}, Line: {jre.LineNumber}, Position: {jre.LinePosition}. Raw data: {rawResponse.Data}";
                return new XCommasResponse<JToken>(null, rawResponse.Data, errorMessage);
            }
            catch (JsonSerializationException jse)
            {
                var errorMessage = $"JsonSerializationException: {jse.Message}. Data: {rawResponse.Data}";
                return new XCommasResponse<JToken>(null, rawResponse.Data, errorMessage);
            }
            catch (Exception ex)
            {
                var errorMessage = $"Unexpected Json exception: {ex.Message}. Data: {rawResponse.Data}";
                return new XCommasResponse<JToken>(null, rawResponse.Data, errorMessage);
            }
        }

        private async Task<XCommasResponse<string>> GetRawResponse(XCommasRequest request)
        {
            try
            {
                var httpClient = _httpClientFactory == null ? HttpClientSingleton : _httpClientFactory.CreateClient();
                var response = await httpClient.SendAsync(request.request);
                var content = await response.Content.ReadAsStringAsync();

                return new XCommasResponse<string>(content, null, null);
            }
            catch (Exception ex)
            {
                return new XCommasResponse<string>(null, null, $"Error getting response from server: {ex.ToString()}");
            }
        }

        #endregion
    }
}
