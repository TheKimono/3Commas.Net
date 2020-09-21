using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace XCommas.Net.Objects
{
    public class QflOptions
    {
        public QflOptions(QflType type = QflType.Original, decimal percent = 3)
        {
            this.Type = type;
            this.Percent = percent;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public QflType Type { get; set; }
        [JsonProperty("percent")]
        public decimal Percent { get; set; }
    }

    public class TaPresetsOptions
    {
        public TaPresetsOptions(TaPresetsType type = TaPresetsType.BB_20_1_LB, IndicatorTime time = IndicatorTime.ThreeMinutes)
        {
            this.Type = type;
            this.Time = time;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public TaPresetsType Type { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("time")]
        public IndicatorTime Time { get; set; }
    }

    public class TradingViewOptions
    {
        public TradingViewOptions(TradingViewIndicatorType type = TradingViewIndicatorType.StrongBuy, TradingViewTime time = TradingViewTime.Cumulative)
        {
            this.Type = type;
            this.Time = time;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public TradingViewIndicatorType Type { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("time")]
        public TradingViewTime Time { get; set; }
    }

    public class RsiOptions
    {
        public RsiOptions(IndicatorTime time = IndicatorTime.ThreeMinutes, int points = 25)
        {
            this.Time = time;
            this.Points = points;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("time")]
        public IndicatorTime Time { get; set; }
        private int points;
        [JsonProperty("points")]
        public int Points
        {
            get
            {
                return this.points;
            }
            set
            {
                if (value < 1 || value > 100) throw new Exception("Value must be between 1 and 100");
                this.points = value;
            }
        }
    }

    public class UltOptions
    {
        public UltOptions(IndicatorTime time = IndicatorTime.ThreeMinutes, int points = 40)
        {
            this.Time = time;
            this.Points = points;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("time")]
        public IndicatorTime Time { get; set; }
        private int points;
        [JsonProperty("points")]
        public int Points
        {
            get
            {
                return this.points;
            }
            set
            {
                if (value < 1 || value > 100) throw new Exception("Value must be between 1 and 100");
                this.points = value;
            }
        }
    }
}
