using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using XCommas.Net.Converters;

namespace XCommas.Net.Objects
{
    public class Bot : BotData
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("active_deals_count")]
        public int ActiveDealsCount { get; set; }
        [JsonProperty("deletable?")]
        public bool IsDeleteable { get; set; }
        [JsonProperty("active_deals")]
        public Deal[] ActiveDeals { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("strategy")]
        public Strategy Strategy { get; set; }
        [JsonProperty("finished_deals_profit_usd")]
        public decimal FinishedDealsProfitUsd { get; set; }
        [JsonProperty("finished_deals_count")]
        public int FinishedDealsCount { get; set; }
        [JsonProperty("account_name")]
        public string AccountName { get; set; }
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        [JsonProperty("is_enabled")]
        public bool IsEnabled { get; set; }
    }

    public class BotUpdateData : BotData
    {
        public BotUpdateData(Bot data)
        {
            this.ActiveSafetyOrdersCount = data.ActiveSafetyOrdersCount;
            this.BaseOrderVolume = data.BaseOrderVolume;
            this.BaseOrderVolumeType = data.BaseOrderVolumeType;
            this.Cooldown = data.Cooldown;
            this.LeverageCustomValue = data.LeverageCustomValue;
            this.LeverageType = data.LeverageType;
            this.MartingaleStepCoefficient = data.MartingaleStepCoefficient;
            this.MartingaleVolumeCoefficient = data.MartingaleVolumeCoefficient;
            this.MaxActiveDeals = data.MaxActiveDeals;
            this.MaxPrice = data.MaxPrice;
            this.MaxSafetyOrders = data.MaxSafetyOrders;
            this.MinPrice = data.MinPrice;
            this.MinVolumeBtc24h = data.MinVolumeBtc24h;
            this.Name = data.Name;
            this.DisableAfterDealsCount = data.DisableAfterDealsCount;
            this.Pairs = data.Pairs;
            this.ProfitCurrency = data.ProfitCurrency;
            this.SafetyOrderStepPercentage = data.SafetyOrderStepPercentage;
            this.SafetyOrderVolume = data.SafetyOrderVolume;
            this.SafetyOrderVolumeType = data.SafetyOrderVolumeType;
            this.StartOrderType = data.StartOrderType;
            this.StopLossPercentage = data.StopLossPercentage;
            this.StopLossTimeoutEnabled = data.StopLossTimeoutEnabled;
            this.StopLossTimeoutInSeconds = data.StopLossTimeoutInSeconds;
            this.StopLossType = data.StopLossType;
            this.Strategies = data.Strategies;
            this.TakeProfit = data.TakeProfit;
            this.TakeProfitType = data.TakeProfitType;
            this.TrailingDeviation = data.TrailingDeviation;
            this.TrailingEnabled = data.TrailingEnabled;
        }
    }

    public class BotCreateData : BotData
    {
        public BotCreateData(int accountId, Strategy strategy, BotData data)
        {
            this.AccountId = accountId;
            this.Strategy = strategy;
            this.ActiveSafetyOrdersCount = data.ActiveSafetyOrdersCount;
            this.BaseOrderVolume = data.BaseOrderVolume;
            this.BaseOrderVolumeType = data.BaseOrderVolumeType;
            this.Cooldown = data.Cooldown;
            this.LeverageCustomValue = data.LeverageCustomValue;
            this.LeverageType = data.LeverageType;
            this.MartingaleStepCoefficient = data.MartingaleStepCoefficient;
            this.MartingaleVolumeCoefficient = data.MartingaleVolumeCoefficient;
            this.MaxActiveDeals = data.MaxActiveDeals;
            this.MaxPrice = data.MaxPrice;
            this.MaxSafetyOrders = data.MaxSafetyOrders;
            this.MinPrice = data.MinPrice;
            this.MinVolumeBtc24h = data.MinVolumeBtc24h;
            this.Name = data.Name;
            this.DisableAfterDealsCount = data.DisableAfterDealsCount;
            this.Pairs = data.Pairs;
            this.ProfitCurrency = data.ProfitCurrency;
            this.SafetyOrderStepPercentage = data.SafetyOrderStepPercentage;
            this.SafetyOrderVolume = data.SafetyOrderVolume;
            this.SafetyOrderVolumeType = data.SafetyOrderVolumeType;
            this.StartOrderType = data.StartOrderType;
            this.StopLossPercentage = data.StopLossPercentage;
            this.StopLossTimeoutEnabled = data.StopLossTimeoutEnabled;
            this.StopLossTimeoutInSeconds = data.StopLossTimeoutInSeconds;
            this.StopLossType = data.StopLossType;
            this.Strategies = data.Strategies;
            this.TakeProfit = data.TakeProfit;
            this.TakeProfitType = data.TakeProfitType;
            this.TrailingDeviation = data.TrailingDeviation;
            this.TrailingEnabled = data.TrailingEnabled;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("strategy")]
        public Strategy Strategy { get; set; }
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
    }


    public class BotData
    {
        [JsonProperty("max_safety_orders")]
        public int MaxSafetyOrders { get; set; }
        [JsonProperty("pairs")]
        public string[] Pairs { get; set; }
        [JsonConverter(typeof(StrategyListConverter))]
        [JsonProperty("strategy_list")]
        public List<BotStrategy> Strategies { get; set; }
        [JsonProperty("max_active_deals")]
        public int MaxActiveDeals { get; set; }
        [JsonProperty("active_safety_orders_count")]
        public int ActiveSafetyOrdersCount { get; set; }
        [JsonProperty("trailing_enabled")]
        public bool TrailingEnabled { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("disable_after_deals_count")]
        public int? DisableAfterDealsCount { get; set; }
        [JsonProperty("take_profit")]
        public decimal TakeProfit { get; set; }
        [JsonProperty("base_order_volume")]
        public decimal BaseOrderVolume { get; set; }
        [JsonProperty("safety_order_volume")]
        public decimal SafetyOrderVolume { get; set; }
        [JsonProperty("safety_order_step_percentage")]
        public decimal SafetyOrderStepPercentage { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("take_profit_type")]
        public TakeProfitType TakeProfitType { get; set; }
        [JsonProperty("martingale_volume_coefficient")]
        public decimal MartingaleVolumeCoefficient { get; set; }
        [JsonProperty("martingale_step_coefficient")]
        public decimal MartingaleStepCoefficient { get; set; }
        [JsonProperty("stop_loss_percentage")]
        public decimal StopLossPercentage { get; set; }
        [JsonProperty("stop_loss_timeout_enabled")]
        public bool StopLossTimeoutEnabled { get; set; }
        [JsonProperty("stop_loss_timeout_in_seconds")]
        public int StopLossTimeoutInSeconds { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("stop_loss_type")]
        public StopLossType StopLossType { get; set; }
        [JsonProperty("cooldown")]
        public int Cooldown { get; set; }
        [JsonProperty("min_volume_btc_24h")]
        public decimal MinVolumeBtc24h { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("profit_currency")]
        public ProfitCurrency ProfitCurrency { get; set; }
        [JsonProperty("min_price")]
        public decimal? MinPrice { get; set; }
        [JsonProperty("max_price")]
        public decimal? MaxPrice { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("safety_order_volume_type")]
        public VolumeType SafetyOrderVolumeType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("base_order_volume_type")]
        public VolumeType BaseOrderVolumeType { get; set; }
        [JsonProperty("trailing_deviation")]
        public decimal TrailingDeviation { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("leverage_type")]
        public LeverageType LeverageType { get; set; }
        [JsonProperty("leverage_custom_value")]
        public decimal? LeverageCustomValue { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("start_order_type")]
        public StartOrderType StartOrderType { get; set; }

    }
}
