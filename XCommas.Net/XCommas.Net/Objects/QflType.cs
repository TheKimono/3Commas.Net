using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum QflType
    {
        [EnumMember(Value = "day_trade")]
        DayTrading,
        [EnumMember(Value = "conservative")]
        ConservativeTrader,
        [EnumMember(Value = "original")]
        Original,
        [EnumMember(Value = "position")]
        PositionTrader,
    }
}
