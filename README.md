# 3Commas.Net
A feature complete and easy to use .Net wrapper of the official 3Commas API. 

Don't forget to visit the [official API docs](https://github.com/3commas-io/3commas-official-api-docs/) or [3Commas support](https://support.3commas.io/hc/en-us) for further reference.

> :penguin: This API wrapper is not an official release from 3Commas team.

## Getting started
XCommas.Net is available as a nuget package for .Net Core, .Net Standard, and various .Net Framework versions.

Install XCommas.net as a `nuget` package from the package manager console:

```Console
PM> Install-Package XCommas.Net
```

You can also clone this repository and add the `XCommas.Net` project directly to your solution.

### Instantiating the client

All you need to instantiate the all-powerful client is to new up an instance of `XCommasApi`. You need to [generate an API key and secret](https://3commas.io/api_access_tokens) before you can use the API. 

```csharp
var apiKey = "YOUR_API_KEY";
var secret = "YOUR_SECRET";

var client = new XCommas.Net.XCommasApi(apiKey, secret);
```

# Methods
The entire API is supported, and each method exists in a synchronous and asynchronous version for your integration pleasure. Most methods return an instance of [`XCommasResponse<T>`](https://github.com/TheKimono/3Commas.Net/blob/master/XCommas.Net/XCommas.Net/XCommasResponse.cs) where `T` is a strongly typed representation of the data returned from 3commas, which can be either a single object or a collection of objects.

You are encouraged to check the `IsSuccess` property before accessing the `Data` property. If an error has occured, the `Error` property will contain the error message. For troubleshooting purposes, the original json reponse from 3commas is included in the `RawData` string property. 

## Account
This section covers the methods described in the official documentation [here](https://github.com/3commas-io/3commas-official-api-docs/blob/master/accounts_api.md).

### `GetAccounts`
```csharp
var response = await client.GetAccountsAsync();

foreach(var account in response.Data)
{
    //Do something with account
    accountId = account.Id;
}
```

### `GetMarkets` 
```csharp
var response = await client.GetMarketsAsync();

foreach(var market in response.Data)
{
    //Do something with market
    Console.WriteLine(market.Name);
}
```

### `CreateAccount` 
```csharp
var account = new AccountCreateData
{
    Name = "My Binance",
    MarketName = "Binance", //Get from markets list
    ApiKey = "MyBinanceApiKey",
};

var response = await client.CreateAccountAsync(account);
```

### `CreateAccount` 
```csharp
var account = new AccountCreateData
{
    Name = "My Binance",
    MarketName = "Binance", //Get from markets list
    ApiKey = "MyBinanceApiKey",
};

var response = await client.CreateAccountAsync(account);
```

### `GetCurrencyRate` 
```csharp
var response = await client.GetCurrencyRateAsync("MCO_BTC");

var mcoAsk = response.Data.Ask;
```

### `SellAllToUsd` 
```csharp
var response = await client.SellAllToUsdAsync(accountId);
```

### `SellAllToBtc` 
```csharp
var response = await client.SellAllToBtcAsync(accountId);
```

### `LoadBalances` 
```csharp
var response = await client.LoadBalancesAsync(accountId);

var totalBtcProfit = response.Data.TotalBtcProfit;
```

### `RenameAccount` 
```csharp
var response = await client.RenameAccountAsync(accountId, "My new shiny account name");
```

### `GetPieChartData` 
```csharp
var response = await client.GetPieChartDataAsync(accountId);
```

### `GetAccountTableData` 
```csharp
var response = await client.GetAccountTableDataAsync(accountId);
```

### `RemoveAccount` 
```csharp
var response = await client.RemoveAccountAsync(accountId);
```

## Smart Trades
This section covers the methods described in the official documentation [here](https://github.com/3commas-io/3commas-official-api-docs/blob/master/smart_trades_api.md).

### `CreateSimpleSell` 
```csharp
var data = new SimpleTradeData
{
    AccountId = accountId,
    Pair = "BTC_XRP",
    Price = 0.001m,
    TradeMethod = SimpleTradeMethod.Limit,
    Units = 1000,
};

var response = await client.CreateSimpleSellAsync(data);
```

### `CreateSimpleBuy` 
```csharp
var data = new SimpleTradeData
{
    AccountId = accountId,
    Pair = "BTC_ETH",
    Price = 0.001m,
    TradeMethod = SimpleTradeMethod.Conditional,
    Units = 1000,
};

var response = await client.CreateSimpleBuyAsync(data);
```

### `CreateSmartSell` 
```csharp
var data = new SmartSellCreateParameters
{
    AccountId = accountId,
    Pair = "BTC_ETH",
    AverageBuyPrice = 0.0004m,
    Note = "Sell moon",
    StopLossEnabled = true,
    StopLossPercentageCondition = 10m,
    StopLossPriceMethod = PriceMethod.Last,
    StopLossTimeoutEnabled = true,
    StopLossTimeoutSeconds = 300,
    TakeProfitEnabled = true,
    TakeProfitType = SmartTradeCompletionType.StepSell,
    TakeProfitStepOrders = new[]
    {
        new TakeProfitStepOrder
        {
            Price = 0.3,
            Percent = 50,
            PriceMethod = PriceMethod.Ask,
        },
        new TakeProfitStepOrder
        {
            Price = 0.4,
            Percent = 50,
            PriceMethod = PriceMethod.Last,
        },
    }.ToList(),
    UnitsToBuy = 500,                
};

var response = await client.CreateSmartSellAsync(data);
```

### `CreateSmartSell` 
```csharp
var data = new SmartCoverCreateParameters
{
    AccountId = accountId,
    Pair = "BTC_ETH",
    Note = "Rebuy later",
    StopLossEnabled = true,
    StopLossPercentageCondition = 10m,
    StopLossPriceMethod = PriceMethod.Last,
    StopLossTimeoutEnabled = true,
    StopLossTimeoutSeconds = 300,
    TakeProfitEnabled = true,
    TakeProfitType = SmartTradeCompletionType.Classic,
    TakeProfitPriceCondition = 0.001m,
    TakeProfitPriceMethod = PriceMethod.Bid,
    UnitsToBuy = 5,                
};

var response = await client.CreateSmartCoverAsync(data);
```

### `CreateSmartTrade` 
```csharp
var data = new SmartTradeCreateParameters
{
    AccountId = accountId,
    Pair = "BTC_ETH",
    Note = "Buy the dip and sell the moon",
    StopLossEnabled = false,
    TakeProfitEnabled = true,
    TakeProfitType = SmartTradeCompletionType.Classic,
    TakeProfitPriceCondition = 0.5m,
    TakeProfitPriceMethod = PriceMethod.Bid,
    UnitsToBuy = 5,        
    TrailingBuyEnabled = true,
    TrailingBuyStep = 1.0m,
    BuyPrice = 0.01m,
    TrailingTakeProfit = true,
    TrailingTakeProfitStep = 5.0m
};

var response = await client.CreateSmartTradeAsync(data);
```

### `GetSmartTrades` 
```csharp
var data = new SmartTradeCreateParameters
{
    AccountId = accountId,
    Pair = "BTC_ETH",
    Note = "Buy the dip and sell the moon",
    StopLossEnabled = false,
    TakeProfitEnabled = true,
    TakeProfitType = SmartTradeCompletionType.Classic,
    TakeProfitPriceCondition = 0.5m,
    TakeProfitPriceMethod = PriceMethod.Bid,
    UnitsToBuy = 5,        
    TrailingBuyEnabled = true,
    TrailingBuyStep = 1.0m,
    BuyPrice = 0.01m,
    TrailingTakeProfit = true,
    TrailingTakeProfitStep = 5.0m
};

var response = await client.CreateSmartTradeAsync(data);
```

### `GetSmartTrades` 
```csharp
var response = await client.GetSmartTradesAsync();

foreach(var smartTrade in response.Data)
{
    //Do something with smart trade
    Console.WriteLine(smartTrade.Note);
}
```

### `PanicSellSmartTradeStep` 
```csharp
var response = await client.PanicSellSmartTradeStepAsync(smartTradeId, stepId);
```

### `UpdateSmartTrade` 
```csharp
var data = new SmartTradeUpdateParameters
{
    Note = "Moon cancelled",
    StopLossEnabled = false,
    TakeProfitEnabled = true,
    TakeProfitType = SmartTradeCompletionType.Classic,
    TakeProfitPriceCondition = 0.04m,
    TakeProfitPriceMethod = PriceMethod.Bid,
    TrailingBuyEnabled = true,
    TrailingBuyStep = 1.0m,
    BuyPrice = 0.01m,
    TrailingTakeProfit = true,
    TrailingTakeProfitStep = 1.0m
};

var response = await client.UpdateSmartTradeAsync(smartTradeId, data);
```

### `CancelSmartTrade` 
```csharp
var response = await client.CancelSmartTradeAsync(smartTradeId);
```

### `PanicSellSmartTrade` 
```csharp
var response = await client.PanicSellSmartTradeAsync(smartTradeId);
```

### `RefreshSmartTrade` 
```csharp
var response = await client.RefreshSmartTradeAsync(smartTradeId);
```

## Bots
This section covers the methods described in the official documentation [here](https://github.com/3commas-io/3commas-official-api-docs/blob/master/bots_api.md).

### `GetBotPairsBlackList` 
```csharp
var response = await client.GetBotPairsBlackListAsync(smartTradeId);
```

### `GetBotPairsBlackList` 
```csharp
var data = new BotPairsBlackListData
{
    Pairs = new[] { "BTC_NPXS", "BTC_XRP" }
};

var response = await client.SetBotPairsBlackListAsync(data);
```

## Deals
This section covers the methods described in the official documentation [here](https://github.com/3commas-io/3commas-official-api-docs/blob/master/deals_api.md).


# :penguin: TIP: 
 If you want to support the continued development of XCommas.Net or just want to leave me a tip, please do so to one of the below cryptocurrency addresses:

 BTC: 1AwfQvdqp7zC4XB5Rg4AMy2JnR1rK6wtR2

 ETH: 0x92526204d90c337786214179699D877e0888bE31
 
 LTC: LhtJNQb1JKAGYQEUQTvKvCvYsnY2QoU4Z2
