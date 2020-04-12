using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using XCommas.Net.Objects;

namespace XCommas.Net.Converters
{
    public class StrategyListConverter : JsonConverter
    {
        private readonly Dictionary<string, Type> strategyMapping;
        public StrategyListConverter()
        {
            this.strategyMapping = new Dictionary<string, Type>();
            this.strategyMapping.Add(NonStopBotStrategy.Id, typeof(NonStopBotStrategy));
            this.strategyMapping.Add(QflBotStrategy.Id, typeof(QflBotStrategy));
            this.strategyMapping.Add(CqsTelegramBotStrategy.Id, typeof(CqsTelegramBotStrategy));
            this.strategyMapping.Add(TaPresetsBotStrategy.Id, typeof(TaPresetsBotStrategy));
            this.strategyMapping.Add(TradingViewBotStrategy.Id, typeof(TradingViewBotStrategy));
            this.strategyMapping.Add(RsiBotStrategy.Id, typeof(RsiBotStrategy));
            this.strategyMapping.Add(UltBotStrategy.Id, typeof(UltBotStrategy));
            this.strategyMapping.Add(CqsPremiumBotStrategy.Id, typeof(CqsPremiumBotStrategy));
            this.strategyMapping.Add(ManualStrategy.Id, typeof(ManualStrategy));
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {

            if (reader.TokenType != JsonToken.Null)
            {
                if (reader.TokenType == JsonToken.StartArray)
                {
                    var result = new List<BotStrategy>();
                    JArray arr = JArray.Load(reader);
                    foreach (var tkn in arr)
                    {
                        var strategyType = tkn["strategy"]?.Value<string>();
                        if (string.IsNullOrEmpty(strategyType) || !this.strategyMapping.ContainsKey(strategyType))
                        {
                            result.Add(new UnknownStrategy(strategyType));
                            continue;
                        }

                        var type = this.strategyMapping[strategyType];
                        var strategy = Activator.CreateInstance(type);

                        serializer.Populate(tkn.CreateReader(), strategy);

                        result.Add((BotStrategy)strategy);
                    }

                    return result;
                }
            }

            return new List<BotStrategy>();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
