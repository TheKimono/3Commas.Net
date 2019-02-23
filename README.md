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

## Bots
This section covers the methods described in the official documentation [here](https://github.com/3commas-io/3commas-official-api-docs/blob/master/bots_api.md).

## Deals
This section covers the methods described in the official documentation [here](https://github.com/3commas-io/3commas-official-api-docs/blob/master/deals_api.md).


# :penguin: TIP: 
 If you want to support the continued development of XCommas.Net or just want to leave me a tip, please do so to one of the below cryptocurrency addresses:

 BTC: 1AwfQvdqp7zC4XB5Rg4AMy2JnR1rK6wtR2

 ETH: 0x92526204d90c337786214179699D877e0888bE31
 
 LTC: LhtJNQb1JKAGYQEUQTvKvCvYsnY2QoU4Z2
