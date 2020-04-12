using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum TradingViewTime
    {
        [EnumMember(Value = "1m")]
        OneMinute,
        [EnumMember(Value = "5m")]
        FiveMinutes,
        [EnumMember(Value = "15m")]
        FifteenMinutes,
        [EnumMember(Value = "1h")]
        OneHour,
        [EnumMember(Value = "4h")]
        FourHours,
        [EnumMember(Value = "1d")]
        OneDay,
        [EnumMember(Value = "1w")]
        OneWeek,
        [EnumMember(Value = "1M")]
        OneMonth,
        [EnumMember(Value = "cumulative")]
        Cumulative
    }
}
