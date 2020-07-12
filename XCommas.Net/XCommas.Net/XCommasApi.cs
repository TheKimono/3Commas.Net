using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using XCommas.Net.Objects;

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

        public string ApiKey { get; set; }
        public string Secret { get; set; }
        public XCommasApi(string apiKey, string secret)
        {
            this.ApiKey = apiKey;
            this.Secret = secret;
        }

        #region Deals

        public XCommasResponse<Deal[]> GetDeals(int limit = 50, int? offset = null, int? accountId = null, int? botId = null, DealScope dealScope = DealScope.All, DealOrder dealOrder = DealOrder.CreatedAt) => this.GetDealsAsync(limit, offset, accountId, botId, dealScope, dealOrder).Result;
        public async Task<XCommasResponse<Deal[]>> GetDealsAsync(int limit = 50, int? offset = null, int? accountId = null, int? botId = null, DealScope dealScope = DealScope.All, DealOrder dealOrder = DealOrder.CreatedAt)
        {
            var path = $"{BaseAddress}/ver1/deals?limit={limit}&offset={offset}&account_id={accountId}&bot_id={botId}&scope={dealScope.GetEnumMemberAttrValue()}&order={dealOrder.GetEnumMemberAttrValue()}";
            using (var request = XCommasRequest.Get(path).Sign(this))
            {
                return await this.GetResponse<Deal[]>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Deal> UpdateMaxSafetyOrders(int dealId, int maxSafetyOrders) => this.UpdateMaxSafetyOrdersAsync(dealId, maxSafetyOrders).Result;
        public async Task<XCommasResponse<Deal>> UpdateMaxSafetyOrdersAsync(int dealId, int maxSafetyOrders)
        {
            var path = $"{BaseAddress}/ver1/deals/{dealId}/update_max_safety_orders";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(new UpdateMaxSafetyOrderData { MaxSafetyOrders = maxSafetyOrders }).Sign(this))
            {
                return await this.GetResponse<Deal>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Deal> PanicSellDeal(int dealId) => this.PanicSellDealAsync(dealId).Result;
        public async Task<XCommasResponse<Deal>> PanicSellDealAsync(int dealId)
        {
            var path = $"{BaseAddress}/ver1/deals/{dealId}/panic_sell";
            using (var request = XCommasRequest.Post(path).Sign(this))
            {
                return await this.GetResponse<Deal>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Deal> CancelDeal(int dealId) => this.CancelDealAsync(dealId).Result;
        public async Task<XCommasResponse<Deal>> CancelDealAsync(int dealId)
        {
            var path = $"{BaseAddress}/ver1/deals/{dealId}/cancel";
            using (var request = XCommasRequest.Post(path).Sign(this))
            {
                return await this.GetResponse<Deal>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Deal> ShowDeal(int dealId) => this.ShowDealAsync(dealId).Result;
        public async Task<XCommasResponse<Deal>> ShowDealAsync(int dealId)
        {
            var path = $"{BaseAddress}/ver1/deals/{dealId}/show";
            using (var request = XCommasRequest.Get(path).Sign(this))
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
            using (var request = XCommasRequest.Get(path).Sign(this))
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

        public XCommasResponse<string> CreateAccount(AccountCreateData data) => this.CreateAccountAsync(data).Result;
        public async Task<XCommasResponse<string>> CreateAccountAsync(AccountCreateData data)
        {
            var path = $"{BaseAddress}/ver1/accounts/new";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(data).Sign(this))
            {
                return await this.GetResponse<string>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<CurrencyRate> GetCurrencyRate(string pair, string prettyDisplayType = "Binance") => this.GetCurrencyRateAsync(pair, prettyDisplayType).Result;
        public async Task<XCommasResponse<CurrencyRate>> GetCurrencyRateAsync(string pair, string prettyDisplayType = "Binance")
        {
            var path = $"{BaseAddress}/ver1/accounts/currency_rates?pretty_display_type={prettyDisplayType}&pair={pair}";
            using (var request = XCommasRequest.Get(path))
            {
                return await this.GetResponse<CurrencyRate>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<string> SellAllToUsd(int accountId) => this.SellAllToUsdAsync(accountId).Result;
        public async Task<XCommasResponse<string>> SellAllToUsdAsync(int accountId)
        {
            var path = $"{BaseAddress}/ver1/accounts/{accountId}/sell_all_to_usd";
            using (var request = XCommasRequest.Post(path).Sign(this))
            {
                return await this.GetResponse<string>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<string> SellAllToBtc(int accountId) => this.SellAllToBtcAsync(accountId).Result;
        public async Task<XCommasResponse<string>> SellAllToBtcAsync(int accountId)
        {
            var path = $"{BaseAddress}/ver1/accounts/{accountId}/sell_all_to_btc";
            using (var request = XCommasRequest.Post(path).Sign(this))
            {
                return await this.GetResponse<string>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Account> LoadBalances(int accountId) => this.LoadBalancesAsync(accountId).Result;
        public async Task<XCommasResponse<Account>> LoadBalancesAsync(int accountId)
        {
            var path = $"{BaseAddress}/ver1/accounts/{accountId}/load_balances";
            using (var request = XCommasRequest.Post(path).Sign(this))
            {
                return await this.GetResponse<Account>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Account> RenameAccount(int accountId, string name) => this.RenameAccountAsync(accountId, name).Result;
        public async Task<XCommasResponse<Account>> RenameAccountAsync(int accountId, string name)
        {
            var path = $"{BaseAddress}/ver1/accounts/{accountId}/rename";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(new RenameAccountData { NewName = name }).Sign(this))
            {
                return await this.GetResponse<Account>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<PieChartPiece[]> GetPieChartData(int accountId) => this.GetPieChartDataAsync(accountId).Result;
        public async Task<XCommasResponse<PieChartPiece[]>> GetPieChartDataAsync(int accountId)
        {
            var path = $"{BaseAddress}/ver1/accounts/{accountId}/pie_chart_data";
            using (var request = XCommasRequest.Post(path).Sign(this))
            {
                return await this.GetResponse<PieChartPiece[]>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<AccountTableData[]> GetAccountTableData(int accountId) => this.GetAccountTableDataAsync(accountId).Result;
        public async Task<XCommasResponse<AccountTableData[]>> GetAccountTableDataAsync(int accountId)
        {
            var path = $"{BaseAddress}/ver1/accounts/{accountId}/account_table_data";
            using (var request = XCommasRequest.Post(path).Sign(this))
            {
                return await this.GetResponse<AccountTableData[]>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<string> RemoveAccount(int accountId) => this.RemoveAccountAsync(accountId).Result;
        public async Task<XCommasResponse<string>> RemoveAccountAsync(int accountId)
        {
            var path = $"{BaseAddress}/ver1/accounts/{accountId}/remove";
            using (var request = XCommasRequest.Post(path).Sign(this))
            {
                return await this.GetResponse<string>(request).ConfigureAwait(false);
            }
        }

        #endregion

        #region Bots

        public XCommasResponse<BotPairsBlackListData> GetBotPairsBlackList => this.GetBotPairsBlackListAsync().Result;
        public async Task<XCommasResponse<BotPairsBlackListData>> GetBotPairsBlackListAsync()
        {
            var path = $"{BaseAddress}/ver1/bots/pairs_black_list";
            using (var request = XCommasRequest.Get(path).Sign(this))
            {
                return await this.GetResponse<BotPairsBlackListData>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<bool> SetBotPairsBlackList(BotPairsBlackListData data) => this.SetBotPairsBlackListAsync(data).Result;
        public async Task<XCommasResponse<bool>> SetBotPairsBlackListAsync(BotPairsBlackListData data)
        {
            var path = $"{BaseAddress}/ver1/bots/update_pairs_black_list";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(data).Sign(this))
            {
                return await this.GetResponse<bool>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot> CreateBot(int accountId, Strategy strategy, BotData data) => this.CreateBotAsync(accountId, strategy, data).Result;
        public async Task<XCommasResponse<Bot>> CreateBotAsync(int accountId, Strategy strategy, BotData data)
        {
            var path = $"{BaseAddress}/ver1/bots/create_bot";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(new BotCreateData(accountId, strategy, data)).Sign(this))
            {
                return await this.GetResponse<Bot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot[]> GetBots(int limit = 50, int? offset = null, int? accountId = null, int? botId = null, BotScope botScope = BotScope.Enabled, Strategy strategy = Strategy.Long) => this.GetBotsAsync(limit, offset, accountId, botId, botScope, strategy).Result;
        public async Task<XCommasResponse<Bot[]>> GetBotsAsync(int limit = 50, int? offset = null, int? accountId = null, int? botId = null, BotScope botScope = BotScope.Enabled, Strategy strategy = Strategy.Long)
        {
            var path = $"{BaseAddress}/ver1/bots?limit={limit}&offset={offset}&account_id={accountId}&bot_id={botId}&scope={botScope.GetEnumMemberAttrValue()}&strategy={strategy.GetEnumMemberAttrValue()}";
            using (var request = XCommasRequest.Get(path).Sign(this))
            {
                return await this.GetResponse<Bot[]>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<BotStats> GetBotStats() => this.GetBotStatsAsync().Result;
        public async Task<XCommasResponse<BotStats>> GetBotStatsAsync()
        {
            var path = $"{BaseAddress}/ver1/bots/stats";
            using (var request = XCommasRequest.Get(path).Sign(this))
            {
                return await this.GetResponse<BotStats>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot> UpdateBot(int botId, BotUpdateData data) => this.UpdateBotAsync(botId, data).Result;
        public async Task<XCommasResponse<Bot>> UpdateBotAsync(int botId, BotUpdateData data)
        {
            var path = $"{BaseAddress}/ver1/bots/{botId}/update";
            using (var request = XCommasRequest.Patch(path).WithSerializedContent(data).Sign(this))
            {
                return await this.GetResponse<Bot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot> DisableBot(int botId) => this.DisableBotAsync(botId).Result;
        public async Task<XCommasResponse<Bot>> DisableBotAsync(int botId)
        {
            var path = $"{BaseAddress}/ver1/bots/{botId}/disable";
            using (var request = XCommasRequest.Post(path).Sign(this))
            {
                return await this.GetResponse<Bot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot> EnableBot(int botId) => this.EnableBotAsync(botId).Result;
        public async Task<XCommasResponse<Bot>> EnableBotAsync(int botId)
        {
            var path = $"{BaseAddress}/ver1/bots/{botId}/enable";
            using (var request = XCommasRequest.Post(path).Sign(this))
            {
                return await this.GetResponse<Bot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot> StartNewDeal(int botId) => this.StartNewDealAsync(botId).Result;
        public async Task<XCommasResponse<Bot>> StartNewDealAsync(int botId, string pair = null, bool skipSignalChecks = false, bool skipOpenDealsChecks = false)
        {
            var path = $"{BaseAddress}/ver1/bots/{botId}/start_new_deal";
            using (var request = XCommasRequest.Post(path)
                .WithSerializedContent(new StartNewDealData { Pair = pair, SkipOpenDealsChecks = skipOpenDealsChecks, SkipSignalChecks = skipSignalChecks }).Sign(this))
            {
                return await this.GetResponse<Bot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<bool> DeleteBot(int botId) => this.DeleteBotAsync(botId).Result;
        public async Task<XCommasResponse<bool>> DeleteBotAsync(int botId)
        {
            var path = $"{BaseAddress}/ver1/bots/{botId}/delete";
            using (var request = XCommasRequest.Post(path).Sign(this))
            {
                return await this.GetResponse<bool>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot> PanicSellAllBotDeals(int botId) => this.PanicSellAllBotDealsAsync(botId).Result;
        public async Task<XCommasResponse<Bot>> PanicSellAllBotDealsAsync(int botId)
        {
            var path = $"{BaseAddress}/ver1/bots/{botId}/panic_sell_all_deals";
            using (var request = XCommasRequest.Post(path).Sign(this))
            {
                return await this.GetResponse<Bot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot> CancelAllBotDeals(int botId) => this.CancelAllBotDealsAsync(botId).Result;
        public async Task<XCommasResponse<Bot>> CancelAllBotDealsAsync(int botId)
        {
            var path = $"{BaseAddress}/ver1/bots/{botId}/cancel_all_deals";
            using (var request = XCommasRequest.Post(path).Sign(this))
            {
                return await this.GetResponse<Bot>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Bot> ShowBot(int botId) => this.ShowBotAsync(botId).Result;
        public async Task<XCommasResponse<Bot>> ShowBotAsync(int botId)
        {
            var path = $"{BaseAddress}/ver1/bots/{botId}/show";
            using (var request = XCommasRequest.Get(path).Sign(this))
            {
                return await this.GetResponse<Bot>(request).ConfigureAwait(false);
            }
        }

        #endregion

        #region Smart trades

        public XCommasResponse<SmartTrade> CreateSimpleSell(SimpleTradeData data) => this.CreateSimpleSellAsync(data).Result;
        public async Task<XCommasResponse<SmartTrade>> CreateSimpleSellAsync(SimpleTradeData data)
        {
            var path = $"{BaseAddress}/ver1/smart_trades/create_simple_sell";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(data).Sign(this))
            {
                return await this.GetResponse<SmartTrade>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTrade> CreateSimpleBuy(SimpleTradeData data) => this.CreateSimpleBuyAsync(data).Result;
        public async Task<XCommasResponse<SmartTrade>> CreateSimpleBuyAsync(SimpleTradeData data)
        {
            var path = $"{BaseAddress}/ver1/smart_trades/create_simple_buy";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(data).Sign(this))
            {
                return await this.GetResponse<SmartTrade>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTrade> CreateSmartSell(SmartSellCreateParameters data) => this.CreateSmartSellAsync(data).Result;
        public async Task<XCommasResponse<SmartTrade>> CreateSmartSellAsync(SmartSellCreateParameters data)
        {
            var path = $"{BaseAddress}/ver1/smart_trades/create_smart_sell";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(data).Sign(this))
            {
                return await this.GetResponse<SmartTrade>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTrade> CreateSmartCover(SmartCoverCreateParameters data) => this.CreateSmartCoverAsync(data).Result;
        public async Task<XCommasResponse<SmartTrade>> CreateSmartCoverAsync(SmartCoverCreateParameters data)
        {
            var path = $"{BaseAddress}/ver1/smart_trades/create_smart_cover";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(data).Sign(this))
            {
                return await this.GetResponse<SmartTrade>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTrade> CreateSmartTrade(SmartTradeCreateParameters data) => this.CreateSmartTradeAsync(data).Result;
        public async Task<XCommasResponse<SmartTrade>> CreateSmartTradeAsync(SmartTradeCreateParameters data)
        {
            var path = $"{BaseAddress}/ver1/smart_trades/create_smart_trade";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(data).Sign(this))
            {
                return await this.GetResponse<SmartTrade>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTrade[]> GetSmartTrades(int limit = 50, int? offset = null, int? accountId = null, SmartTradeScope smartTradeScope = SmartTradeScope.All, string type = null) => this.GetSmartTradesAsync(limit, offset, accountId, smartTradeScope, type).Result;
        public async Task<XCommasResponse<SmartTrade[]>> GetSmartTradesAsync(int limit = 50, int? offset = null, int? accountId = null, SmartTradeScope smartTradeScope = SmartTradeScope.All, string type = null)
        {
            var path = $"{BaseAddress}/ver1/smart_trades?limit={limit}&offset={offset}&account_id={accountId}&scope={smartTradeScope.GetEnumMemberAttrValue()}&type={type}";
            using (var request = XCommasRequest.Get(path).Sign(this))
            {
                return await this.GetResponse<SmartTrade[]>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<Deal> PanicSellSmartTradeStep(int smartTradeId, int stepId) => this.PanicSellSmartTradeStepAsync(smartTradeId, stepId).Result;
        public async Task<XCommasResponse<Deal>> PanicSellSmartTradeStepAsync(int smartTradeId, int stepId)
        {
            var path = $"{BaseAddress}/ver1/smart_trades/{smartTradeId}/step_panic_sell";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(new PanicSellSmartTradeStepData { StepId = stepId }).Sign(this))
            {
                return await this.GetResponse<Deal>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTrade> UpdateSmartTrade(int smartTradeId, SmartTradeUpdateParameters data) => this.UpdateSmartTradeAsync(smartTradeId, data).Result;
        public async Task<XCommasResponse<SmartTrade>> UpdateSmartTradeAsync(int smartTradeId, SmartTradeUpdateParameters data)
        {
            var path = $"{BaseAddress}/ver1/smart_trades/{smartTradeId}/update";
            using (var request = XCommasRequest.Patch(path).WithSerializedContent(data).Sign(this))
            {
                return await this.GetResponse<SmartTrade>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTrade> CancelSmartTrade(int smartTradeId) => this.CancelSmartTradeAsync(smartTradeId).Result;
        public async Task<XCommasResponse<SmartTrade>> CancelSmartTradeAsync(int smartTradeId)
        {
            var path = $"{BaseAddress}/ver1/smart_trades/{smartTradeId}/cancel";
            using (var request = XCommasRequest.Post(path).Sign(this))
            {
                return await this.GetResponse<SmartTrade>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTrade> PanicSellSmartTrade(int smartTradeId) => this.PanicSellSmartTradeAsync(smartTradeId).Result;
        public async Task<XCommasResponse<SmartTrade>> PanicSellSmartTradeAsync(int smartTradeId)
        {
            var path = $"{BaseAddress}/ver1/smart_trades/{smartTradeId}/panic_sell";
            using (var request = XCommasRequest.Post(path).Sign(this))
            {
                return await this.GetResponse<SmartTrade>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTrade> RefreshSmartTrade(int smartTradeId) => this.RefreshSmartTradeAsync(smartTradeId).Result;
        public async Task<XCommasResponse<SmartTrade>> RefreshSmartTradeAsync(int smartTradeId)
        {
            var path = $"{BaseAddress}/ver1/smart_trades/{smartTradeId}/force_process";
            using (var request = XCommasRequest.Post(path).Sign(this))
            {
                return await this.GetResponse<SmartTrade>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTradeStep> AddFundsToSmartTrade(SmartTradeAddFundsParameters data) => this.AddFundsToSmartTradeAsync(data).Result;
        public async Task<XCommasResponse<SmartTradeStep>> AddFundsToSmartTradeAsync(SmartTradeAddFundsParameters data)
        {
            var path = $"{BaseAddress}/ver1/smart_trades/{data.SmartTradeId}/add_funds";
            using (var request = XCommasRequest.Post(path).WithSerializedContent(data).Sign(this))
            {
                return await this.GetResponse<SmartTradeStep>(request).ConfigureAwait(false);
            }
        }

        public XCommasResponse<SmartTrade> CancelSmartTradeOrder(int smartTradeId, int stepId) => this.CancelSmartTradeOrderAsync(smartTradeId, stepId).Result;
        public async Task<XCommasResponse<SmartTrade>> CancelSmartTradeOrderAsync(int smartTradeId, int stepId)
        {
            var path = $"{BaseAddress}/ver1/smart_trades/{smartTradeId}/cancel_order?step_id={stepId}";
            using (var request = XCommasRequest.Post(path).Sign(this))
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
            using (var request = XCommasRequest.Post(path).Sign(this))
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
            catch(Exception ex)
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
                using (var client = new HttpClient())
                {
                    var response = await client.SendAsync(request.request);
                    var content = await response.Content.ReadAsStringAsync();

                    return new XCommasResponse<string>(content, null, null);
                }
            }
            catch (Exception ex)
            {
                return new XCommasResponse<string>(null, null, $"Error getting response from server: {ex.ToString()}");
            }
        }

        #endregion
    }
}
