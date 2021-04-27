using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;

namespace XCommas.Net.Objects.SmartTrades.V2
{
    public enum OrderType
    {
        [EnumMember(Value = "market")]
        Market,
        [EnumMember(Value = "limit")]
        Limit
    }

    public enum PriceType
    {
        //"type":"bid|ask|last"
        [EnumMember(Value = "bid")]
        Bid,
        [EnumMember(Value = "ask")]
        Ask,
        [EnumMember(Value = "last")]
        Last
    }

    public enum SmartTradeType
    {
        [EnumMember(Value = "simple_buy")]
        SimpleBuy,
        [EnumMember(Value = "simple_sell")]
        SimpleSell,
        [EnumMember(Value = "smart_sell")]
        SmartSell,
        [EnumMember(Value = "smart_trade")]
        SmartTrade,
        [EnumMember(Value = "smart_cover")]
        SmartCover
    }

    public enum TradeType
    {
        [EnumMember(Value = "buy")]
        Buy,
        [EnumMember(Value = "sell")]
        Sell
    }

    public class Amount
    {
        //"value": "122.61",
        [JsonProperty("value")]
        public double? Value { get; set; }
        //"value_without_commission": "8.1757",
        [JsonProperty("value_without_commission")]
        public double? ValueWithoutCommission { get; set; }
        //      "editable": false,
        [JsonProperty("editable")]
        public bool? Editable { get; set; }

        // type
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public PriceType? Type { get; set; }
        // percent
        [JsonProperty("percent")]
        public double? Percent { get; set; }
    }

    public class Position
    {
        //"type":"buy|sell",                          /*required*/
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public TradeType Type { get; set; }
        //      "editable": false,
        [JsonProperty("editable")]
        public bool Editable { get; set; }
        //        "units": {                                  /*required*/
        //            "value":"0.1234"                        /*amount of units to buy*/
        //        },
        [JsonProperty("units")]
        public Amount Units { get; set; }
        //        "price": {                                  /*optional. uses for limit orders or price for Smart Sell*/
        //            "value":"0.1234"                        /*required*/
        //        },
        [JsonProperty("price")]
        public Amount Price { get; set; }
        //      "total": {
        [JsonProperty("total")]
        public Amount Total { get; set; }
        //        "order_type":"market|limit|conditional",    /*required*/
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("order_type")]
        public OrderType OrderType { get; set; }
        //      "status": {
        [JsonProperty("status")]
        public Status Status { get; set; }
        
        
        //        "conditional": {                            /*required only if order type is conditional */
        //            "price": {                              /*required*/
        //                "value":"0.1234",                   /*conditional trigger price*/
        //                "type":"bid|ask|last",              /*optional. By default ask for long trades, bid for short trades */
        //            },
        //            "order_type": "market|limit",           /*required*/
        //            "trailing": {                           /*optional. Only for market orders */
        //                "enabled":"true|false",             /*required*/
        //                "percent": "12.12"                  /*required if enabled*/
        //            }
        //        }
    }

    public class SmartTradeCreateRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        //    "account_id": "1",                              /*required*/
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        //    "pair":"USDT_BTC",                              /*required*/
        [JsonProperty("pair")]
        public string Pair { get; set; }
        //    "instant":"true|false",                         /*optional. true for Simple Buy and Simple Sell*/
        [JsonProperty("instant")]
        public bool? Instant { get; set; }
        //    "skip_enter_step": "true|false",                /*optional. true only for Smart Sell*/
        [JsonProperty("skip_enter_step")]
        public bool? SkipEnterStep { get; set; }
        //    "leverage": {                                   /*optional. uses only for contract exchanges*/ 
        //        "enabled": "true|false",                    /*required*/
        //        "type": "custom|cross",                     /*required only if enabled */
        //        "value": "12"                               /*value of custom leverage*/
        //    },    
        //    "position": {                                   /*required*/
        [JsonProperty("position")]
        public Position Position { get; set; }
        //        
        //    },
        //    "take_profit": {                                /*required only when instant is false */
        [JsonProperty("take_profit")]
        public TakeProfit TakeProfit { get; set; }
        //        "enabled":"true|false",                     /*required*/
        //        "steps": [                                  /*required if enabled. Maximum steps is 8 */
        //            {
        //                "order_type": "market|limit",       /*required*/
        //                "price": {                          /*required*/
        //                    "value":"0.123",                /*required only if position has no trailing or position trailing is finished */
        //                    "type":"bid|ask|last",          /*required*/
        //                    "percent":"10.5"                /*required only if position has trailing and position trailing is not finished */
        //                },                
        //                "volume": "25.0",                   /*required. should be 100% in the sum of all steps */
        //                "trailing": {                       /*optional. Only for market orders */
        //                    "enabled":"true|false",         /*required*/
        //                    "percent": "12.12"              /*required if enabled*/
        //                }
        //            },
        //            /* ... */
        //        ]
        //    },
        //    "stop_loss": {                                  /*required only when instant is false */
        [JsonProperty("stop_loss")]
        public StopLoss StopLoss { get; set; }
        //    "enabled":"true|false",                     /*required*/
        //        "order_type": "market|limit",               /*required*/
        //        "price": {                                  /*required only for limit order_type */
        //        "value":"0.1234"
        //        },
        //        "conditional": {                            /*required*/
        //        "price": {                              /*required. SL trigger price */
        //            "value":"0.1234",                   /*required only if position has no trailing or position trailing is finished */
        //                "type":"bid|ask|last",              /*required*/
        //                "percent":"10.5"                    /*required only if position has trailing and position trailing is not finished */
        //            },
        //            "trailing": {                           /* optional. Only for market orders */
        //            "enabled":"true|false",             /*required*/
        //                "percent": "12.12"                  /*required if enabled*/
        //            }
        //    },
        //        "timeout": {                                /* optional. */
        //        "enabled":"true|false",                 /*required*/
        //            "value": "123"                          /*required if enabled. value in seconds*/
        //        }
        //}
        //}
    }

    public class Account
    {
        //      "id": 29516930,
        [JsonProperty("id")]
        public int Id { get; set; }
        //      "type": "paper_trading",
        [JsonProperty("type")]
        public string Type { get; set; }
        //      "name": "Paper Account 353475",
        [JsonProperty("name")]
        public string Name { get; set; }
        //      "market": "Paper trading account",
        [JsonProperty("market")]
        public string Market { get; set; }
        //      "link": "/accounts/29516930"
        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Status
    {
        //    "type": "waiting_targets",
        [JsonProperty("type")]
        public string Type { get; set; }
        //      "title": "Waiting Targets"
        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class Leverage
    {
        //    "type": "waiting_targets",
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class Trailing
    {
        //            "enabled": false,
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        //            "percent": null
        [JsonProperty("percent")]
        public double? Percent { get; set; }
    }

    public class SmartTradeStep
    {
        //"id": 20499063,
        [JsonProperty("id")]
        public int Id { get; set; }
        //          "order_type": "market",
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("order_type")]
        public OrderType OrderType { get; set; }
        //          "editable": true,
        [JsonProperty("editable")]
        public bool Editable { get; set; }

        //          "units": {
        [JsonProperty("units")]
        public Amount Units { get; set; }
        //          "price": {
        [JsonProperty("price")]
        public Amount Price { get; set; }

        //          "volume": "40.0",
        [JsonProperty("volume")]
        public double Volume { get; set; }
        //          "total": "480.076875",
        [JsonProperty("total")]
        public double Total { get; set; }
        //          "trailing": {
        [JsonProperty("trailing")]
        public Trailing Trailing { get; set; }

        //          "status": {
        [JsonProperty("status")]
        public Status Status { get; set; }
        //          "data": {
        [JsonProperty("data")]
        public SmartTradeStepData Data { get; set; }
        //          "position": 1
        [JsonProperty("position")]
        public int Position { get; set; }
    }

    public class SmartTradeStepData
    {
        //            "cancelable": true,
        [JsonProperty("cancelable")]
        public bool Cancelable { get; set; }
        //            "panic_sell_available": true
        [JsonProperty("panic_sell_available")]
        public bool PanicSellAvailable { get; set; }
    }

    public class TakeProfit
    {
        //    "enabled": true,
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        //      "steps": [
        [JsonProperty("steps")]
        public SmartTradeStep[] Steps { get; set; }
    }

    public class Conditional
    {
        //"price": {
        [JsonProperty("price")]
        public Amount Price { get; set; }
        [JsonProperty("trailing")]
        public Trailing Trailing { get; set; }
    }

    public class EnabledValue
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("value")]
        public double? Value { get; set; }
    }

    public class StopLoss
    {
        //"enabled": true,
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        //      "order_type": "market",
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("order_type")]
        public OrderType OrderType { get; set; }
        //      "editable": true,
        [JsonProperty("editable")]
        public bool Editable { get; set; }
        [JsonProperty("price")]
        public Amount Price { get; set; }
        //      "conditional": {
        [JsonProperty("conditional")]
        public Conditional Conditional { get; set; }
        //      "timeout": {
        [JsonProperty("timeout")]
        public EnabledValue Timeout { get; set; }
        //      "status": {
        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public class CurrentPrice
    {
        //        "bid": "8.5729",
        [JsonProperty("bid")]
        public double Bid { get; set; }
        //        "ask": "8.5766",
        [JsonProperty("ask")]
        public double Ask { get; set; }
        //        "last": "8.5729",
        [JsonProperty("last")]
        public double Last { get; set; }
        //        "day_change_percent": "8.814",
        [JsonProperty("day_change_percent")]
        public double DayChangePercent { get; set; }
        //        "quote_volume": "127475410.102959"
        [JsonProperty("quote_volume")]
        public double QuoteVolume { get; set; }
    }

    public class SmartTradeData
    {
        //    "editable": true
        [JsonProperty("editable")]
        public bool Editable { get; set; }
        //      "current_price": {
        [JsonProperty("current_price")]
        public CurrentPrice CurrentPrice { get; set; }
        //      "target_price_type": "price",
        [JsonProperty("target_price_type")]
        public string TargetPriceType { get; set; }
        //      "base_order_finished": true,
        [JsonProperty("base_order_finished")]
        public bool BaseOrderFinished { get; set; }
        //      "missing_funds_to_close": "0.0",
        [JsonProperty("missing_funds_to_close")]
        public double MissingFundsToClose { get; set; }
        //      "liquidation_price": null,
        [JsonProperty("liquidation_price")]
        public double? LiquidationPrice { get; set; }
        //      "average_enter_price": "8.1838",
        [JsonProperty("average_enter_price")]
        public double AverageEnterPrice { get; set; }
        //      "average_close_price": null,
        [JsonProperty("average_close_price")]
        public double? AverageClosePrice { get; set; }
        //      "average_enter_price_without_commission": "8.1757",
        [JsonProperty("average_enter_price_without_commission")]
        public double AverageEnterPriceWithoutCommission { get; set; }
        //      "average_close_price_without_commission": null,
        [JsonProperty("average_close_price_without_commission")]
        public double? AverageClosePriceWithoutCommission { get; set; }
        //      "panic_sell_available": true,
        [JsonProperty("panic_sell_available")]
        public bool PanicSellAvailable { get; set; }
        //      "add_funds_available": true,
        [JsonProperty("add_funds_available")]
        public bool AddFundsAvailable { get; set; }
        //      "force_start_available": false,
        [JsonProperty("force_start_available")]
        public bool ForceStartAvailable { get; set; }
        //      "force_process_available": true,
        [JsonProperty("force_process_available")]
        public bool ForceProcessAvailable { get; set; }
        //      "cancel_available": true,
        [JsonProperty("cancel_available")]
        public bool CancelAvailable { get; set; }
        //      "finished": false,
        [JsonProperty("finished")]
        public bool Finished { get; set; }
        //      "created_at": "2021-04-25T21:09:18.476Z",
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        //      "updated_at": "2021-04-25T21:09:18.476Z",
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        //      "type": "smart_trade"
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public SmartTradeType Type { get; set; }
    }

    public class Profit
    {
        //    "volume": "46.647146154",
        [JsonProperty("volume")]
        public double Volume { get; set; }
        //      "usd": "46.647146154",
        [JsonProperty("usd")]
        public double Usd { get; set; }
        //      "percent": "4.65",
        [JsonProperty("percent")]
        public double Percent { get; set; }
        //      "roe": null
    }

    public class SmartTrade
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        //    "version": 2,
        [JsonProperty("version")]
        public int Version { get; set; }
        //    "account": 
        [JsonProperty("account")]
        public Account Account { get; set; }
        //    "pair": "USDT_ALICE",
        [JsonProperty("pair")]
        public string Pair { get; set; }
        //    "instant": false,
        [JsonProperty("instant")]
        public bool Instant { get; set; }
        //    "status": {
        [JsonProperty("status")]
        public Status Status { get; set; }
        //    "leverage": {
        [JsonProperty("leverage")]
        public Leverage Leverage { get; set; }
        //    "position": {
        [JsonProperty("position")]
        public Position Position { get; set; }
        //    "take_profit": {
        [JsonProperty("take_profit")]
        public TakeProfit TakeProfit { get; set; }
        //    "stop_loss": {
        [JsonProperty("stop_loss")]
        public StopLoss StopLoss { get; set; }
        //    "note": "",
        [JsonProperty("note")]
        public string Note { get; set; }
        //    "skip_enter_step": false,
        [JsonProperty("skip_enter_step")]
        public bool SkipEnterStep { get; set; }
        //    "data": {
        [JsonProperty("data")]
        public SmartTradeData Data { get; set; }
        //    "profit": {
        [JsonProperty("profit")]
        public Profit Profit { get; set; }
        //    "margin": {
        [JsonProperty("margin")]
        public Amount Margin { get; set; }
        //    "is_position_not_filled": false
        [JsonProperty("is_position_not_filled")]
        public bool IsPositionNotFilled { get; set; }
    }
}
