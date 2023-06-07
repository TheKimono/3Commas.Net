using Newtonsoft.Json;
using System;
using Newtonsoft.Json.Converters;

namespace XCommas.Net.Objects
{
    public class GridBot : GridBotData
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        [JsonProperty("account_name")]
        public string AccountName { get; set; }
        [JsonProperty("is_enabled")]
        public bool IsEnabled { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("start_price")]
        public decimal StartPrice { get; set; }
        [JsonProperty("grid_price_step")]
        public decimal GridPriceStep { get; set; }
        [JsonProperty("current_profit")]
        public decimal CurrentProfit { get; set; }
        [JsonProperty("current_profit_usd")]
        public decimal CurrentProfitUsd { get; set; }
        [JsonProperty("bought_volume")]
        public decimal BoughtVolume { get; set; }
        [JsonProperty("sold_volume")]
        public decimal SoldVolume { get; set; }
        [JsonProperty("profit_percentage")]
        public decimal ProfitPercentage { get; set; }
        [JsonProperty("current_price")]
        public decimal CurrentPrice { get; set; }
        [JsonProperty("investment_base_currency")]
        public decimal InvestmentBaseCurrency { get; set; }
        [JsonProperty("investment_quote_currency")]
        public decimal InvestmentQuoteCurrency { get; set; }
    }

    public class GridBotData
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("pair")]
        public string Pair { get; set; }
        [JsonProperty("upper_price")]
        public decimal UpperLimitPrice { get; set; }
        [JsonProperty("lower_price")]
        public decimal LowerLimitPrice { get; set; }
        [JsonProperty("quantity_per_grid")]
        public decimal QuantityPerGrid { get; set; }
        [JsonProperty("grids_quantity")]
        public int GridsQuantity { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("leverage_type")]
        public LeverageType? LeverageType { get; set; }
        [JsonProperty("leverage_custom_value")]
        public decimal? LeverageCustomValue { get; set; }
    }

    public class GridBotCreateData : GridBotData
    {
        public GridBotCreateData(int accountId, GridBotData data)
        {
            AccountId = accountId;
            QuantityPerGrid = data.QuantityPerGrid;
            GridsQuantity = data.GridsQuantity;
            LowerLimitPrice = data.LowerLimitPrice;
            UpperLimitPrice = data.UpperLimitPrice;
            LeverageCustomValue = data.LeverageCustomValue;
            LeverageType = data.LeverageType;
            Pair = data.Pair;
        }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("is_enabled")]
        public bool? IsEnabled { get; set; }
    }

    public class GridBotUpdateData : GridBotData
    {
        public GridBotUpdateData(int id, GridBotData data)
        {
            Id = id;
            Name = data.Name;
            QuantityPerGrid = data.QuantityPerGrid;
            GridsQuantity = data.GridsQuantity;
            LowerLimitPrice = data.LowerLimitPrice;
            UpperLimitPrice = data.UpperLimitPrice;
            LeverageCustomValue = data.LeverageCustomValue;
            LeverageType = data.LeverageType;
            Pair = data.Pair;
        }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
    
    public class AIGridBot : GridBotData
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        [JsonProperty("account_name")]
        public string AccountName { get; set; }
        [JsonProperty("is_enabled")]
        public bool IsEnabled { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("start_price")]
        public decimal StartPrice { get; set; }
        [JsonProperty("grid_price_step")]
        public decimal GridPriceStep { get; set; }
        [JsonProperty("current_profit")]
        public decimal CurrentProfit { get; set; }
        [JsonProperty("current_profit_usd")]
        public decimal CurrentProfitUsd { get; set; }
        [JsonProperty("bought_volume")]
        public decimal BoughtVolume { get; set; }
        [JsonProperty("sold_volume")]
        public decimal SoldVolume { get; set; }
        [JsonProperty("profit_percentage")]
        public decimal ProfitPercentage { get; set; }
        [JsonProperty("current_price")]
        public decimal CurrentPrice { get; set; }
        [JsonProperty("investment_base_currency")]
        public decimal InvestmentBaseCurrency { get; set; }
        [JsonProperty("investment_quote_currency")]
        public decimal InvestmentQuoteCurrency { get; set; }
    }

    public class AIGridBotData
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("pair")]
        public string Pair { get; set; }
        [JsonProperty("total_quantity")]
        public decimal TotalQuantity { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("leverage_type")]
        public LeverageType? LeverageType { get; set; }
        [JsonProperty("leverage_custom_value")]
        public decimal? LeverageCustomValue { get; set; }
    }
    
    public class AIGridBotCreateData : AIGridBotData
    {
        public AIGridBotCreateData(int accountId, AIGridBotData data)
        {
            AccountId = accountId;
            TotalQuantity = data.TotalQuantity;
            LeverageCustomValue = data.LeverageCustomValue;
            LeverageType = data.LeverageType;
            Pair = data.Pair;
        }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("is_enabled")]
        public bool? IsEnabled { get; set; }
    }
    
    public class AIGridBotUpdateData : AIGridBotData
    {
        public AIGridBotUpdateData(int id, AIGridBotData data)
        {
            Id = id;
            Name = data.Name;
            TotalQuantity = data.TotalQuantity;
            LeverageCustomValue = data.LeverageCustomValue;
            LeverageType = data.LeverageType;
            Pair = data.Pair;
        }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
