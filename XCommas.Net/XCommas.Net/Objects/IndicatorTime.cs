using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum IndicatorTime
    {
        [EnumMember(Value = "3m")]
        ThreeMinutes,
        [EnumMember(Value = "5m")]
        FiveMinutes,
        [EnumMember(Value = "15m")]
        FifteenMinutes,
        [EnumMember(Value = "30m")]
        ThirtyMinutes,
        [EnumMember(Value = "1h")]
        OneHour,
        [EnumMember(Value = "2h")]
        TwoHours,
        [EnumMember(Value = "4h")]
        FourHours,
        [EnumMember(Value = "8h")]
        EightHours,
        [EnumMember(Value = "1d")]
        OneDay,
        [EnumMember(Value = "3d")]
        ThreeDays,
        [EnumMember(Value = "1w")]
        OneWeek
    }
}
