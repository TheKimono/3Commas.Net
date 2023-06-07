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
        public RsiOptions(IndicatorTime time = IndicatorTime.ThreeMinutes, int points = 25, int timePeriod = 7, TriggerCondition triggerCondition = TriggerCondition.Less)
        {
            // If no value is present, it falls back to the default legacy RSI time period value (7).
            // https://github.com/TheKimono/3Commas.Net/issues/56
            if (timePeriod == 0) timePeriod = 7;

            this.Time = time;
            this.Points = points;
            this.TimePeriod = timePeriod;
            this.Condition = triggerCondition;
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

        private int timePeriod;
        [JsonProperty("time_period")]
        public int TimePeriod
        {
            get
            {
                return this.timePeriod;
            }
            set
            {
                if (value < 1 || value > 30) throw new Exception("Value must be between 1 and 30");
                this.timePeriod = value;
            }
        }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("trigger_condition")]
        public TriggerCondition Condition { get; set; }
    }

    public class BbOptions
    {
        public BbOptions(IndicatorTime time = IndicatorTime.ThreeMinutes, decimal points = 0, string deviation = "2", string timePeriod = "20", TriggerCondition triggerCondition = TriggerCondition.Less)
        {
            this.Time = time;
            this.Points = points;
            this.Deviation = deviation;
            this.TimePeriod = timePeriod;
            this.Condition = triggerCondition;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("time")]
        public IndicatorTime Time { get; set; }
        private decimal points;
        [JsonProperty("points")]
        public decimal Points
        {
            get
            {
                return this.points;
            }
            set
            {
                if (value < -1 || value > 2) throw new Exception("Value must be between -1.0 and 2.0");
                this.points = value;
            }
        }

        private string deviation;
        [JsonProperty("deviation")]
        public string Deviation
        {
            get
            {
                return this.deviation;
            }
            set
            {
                if (value != "1" && value != "2") throw new Exception("Value must be 1 or 2");
                this.deviation = value;
            }
        }

        private string timePeriod;
        [JsonProperty("time_period")]
        public string TimePeriod
        {
            get
            {
                return this.timePeriod;
            }
            set
            {
                if (value != "10" && value != "20" && value != "30" && value != "40" && value != "50") throw new Exception("Value must be 10, 20, 30, 40 or 50");
                this.timePeriod = value;
            }
        }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("trigger_condition")]
        public TriggerCondition Condition { get; set; }
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
