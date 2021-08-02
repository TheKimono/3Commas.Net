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
        [JsonProperty("value")]
        public double? Value { get; set; }
        [JsonProperty("value_without_commission")]
        public double? ValueWithoutCommission { get; set; }
        [JsonProperty("editable")]
        public bool? Editable { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public PriceType? Type { get; set; }
        [JsonProperty("percent")]
        public double? Percent { get; set; }
    }

    public class Position
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public TradeType Type { get; set; }
        [JsonProperty("editable")]
        public bool Editable { get; set; }
        [JsonProperty("units")]
        public Amount Units { get; set; }
        [JsonProperty("price")]
        public Amount Price { get; set; }
        [JsonProperty("total")]
        public Amount Total { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("order_type")]
        public OrderType OrderType { get; set; }
        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public class SmartTradeCreateRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        [JsonProperty("pair")]
        public string Pair { get; set; }
        [JsonProperty("instant")]
        public bool? Instant { get; set; }
        [JsonProperty("skip_enter_step")]
        public bool? SkipEnterStep { get; set; }
        [JsonProperty("position")]
        public Position Position { get; set; }
        [JsonProperty("take_profit")]
        public TakeProfit TakeProfit { get; set; }
        [JsonProperty("stop_loss")]
        public StopLoss StopLoss { get; set; }
    }

    public class AddFundsToSmartTradeParams
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("order_type")]
        public string OrderType { get; set; }
        [JsonProperty("units")]
        public Amount Units { get; set; }
        [JsonProperty("price")]
        public Amount Price { get; set; }
    }
    public class Account
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("market")]
        public string Market { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Status
    {
        [JsonProperty("type")]
        public string Type { get; set; }
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
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("percent")]
        public double? Percent { get; set; }
    }

    public class SmartTradeStep
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("order_type")]
        public OrderType OrderType { get; set; }
        [JsonProperty("editable")]
        public bool Editable { get; set; }
        [JsonProperty("units")]
        public Amount Units { get; set; }
        [JsonProperty("price")]
        public Amount Price { get; set; }
        [JsonProperty("volume")]
        public double Volume { get; set; }
        [JsonProperty("total")]
        public double Total { get; set; }
        [JsonProperty("trailing")]
        public Trailing Trailing { get; set; }
        [JsonProperty("status")]
        public Status Status { get; set; }
        [JsonProperty("data")]
        public SmartTradeStepData Data { get; set; }
        [JsonProperty("position")]
        public int Position { get; set; }
    }

    public class SmartTradeStepData
    {
        [JsonProperty("cancelable")]
        public bool Cancelable { get; set; }
        [JsonProperty("panic_sell_available")]
        public bool PanicSellAvailable { get; set; }
    }

    public class TakeProfit
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("steps")]
        public SmartTradeStep[] Steps { get; set; }
    }

    public class Conditional
    {
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
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("order_type")]
        public OrderType OrderType { get; set; }
        [JsonProperty("editable")]
        public bool Editable { get; set; }
        [JsonProperty("price")]
        public Amount Price { get; set; }
        [JsonProperty("conditional")]
        public Conditional Conditional { get; set; }
        [JsonProperty("timeout")]
        public EnabledValue Timeout { get; set; }
        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public class CurrentPrice
    {
        [JsonProperty("bid")]
        public double Bid { get; set; }
        [JsonProperty("ask")]
        public double Ask { get; set; }
        [JsonProperty("last")]
        public double Last { get; set; }
        [JsonProperty("day_change_percent")]
        public double DayChangePercent { get; set; }
        [JsonProperty("quote_volume")]
        public double QuoteVolume { get; set; }
    }

    public class SmartTradeData
    {
        [JsonProperty("editable")]
        public bool Editable { get; set; }
        [JsonProperty("current_price")]
        public CurrentPrice CurrentPrice { get; set; }
        [JsonProperty("target_price_type")]
        public string TargetPriceType { get; set; }
        [JsonProperty("base_order_finished")]
        public bool BaseOrderFinished { get; set; }
        [JsonProperty("missing_funds_to_close")]
        public double MissingFundsToClose { get; set; }
        [JsonProperty("liquidation_price")]
        public double? LiquidationPrice { get; set; }
        [JsonProperty("average_enter_price")]
        public double AverageEnterPrice { get; set; }
        [JsonProperty("average_close_price")]
        public double? AverageClosePrice { get; set; }
        [JsonProperty("average_enter_price_without_commission")]
        public double AverageEnterPriceWithoutCommission { get; set; }
        [JsonProperty("average_close_price_without_commission")]
        public double? AverageClosePriceWithoutCommission { get; set; }
        [JsonProperty("panic_sell_available")]
        public bool PanicSellAvailable { get; set; }
        [JsonProperty("add_funds_available")]
        public bool AddFundsAvailable { get; set; }
        [JsonProperty("force_start_available")]
        public bool ForceStartAvailable { get; set; }
        [JsonProperty("force_process_available")]
        public bool ForceProcessAvailable { get; set; }
        [JsonProperty("cancel_available")]
        public bool CancelAvailable { get; set; }
        [JsonProperty("finished")]
        public bool Finished { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public SmartTradeType Type { get; set; }
    }

    public class Profit
    {
        [JsonProperty("volume")]
        public double Volume { get; set; }
        [JsonProperty("usd")]
        public double Usd { get; set; }
        [JsonProperty("percent")]
        public double Percent { get; set; }
    }

    public class SmartTrade
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("version")]
        public int Version { get; set; }
        [JsonProperty("account")]
        public Account Account { get; set; }
        [JsonProperty("pair")]
        public string Pair { get; set; }
        [JsonProperty("instant")]
        public bool Instant { get; set; }
        [JsonProperty("status")]
        public Status Status { get; set; }
        [JsonProperty("leverage")]
        public Leverage Leverage { get; set; }
        [JsonProperty("position")]
        public Position Position { get; set; }
        [JsonProperty("take_profit")]
        public TakeProfit TakeProfit { get; set; }
        [JsonProperty("stop_loss")]
        public StopLoss StopLoss { get; set; }
        [JsonProperty("note")]
        public string Note { get; set; }
        [JsonProperty("skip_enter_step")]
        public bool SkipEnterStep { get; set; }
        [JsonProperty("data")]
        public SmartTradeData Data { get; set; }
        [JsonProperty("profit")]
        public Profit Profit { get; set; }
        [JsonProperty("margin")]
        public Amount Margin { get; set; }
        [JsonProperty("is_position_not_filled")]
        public bool IsPositionNotFilled { get; set; }
    }
}
