using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum TriggerCondition
    {
        [EnumMember(Value = "less")]
        Less,
        [EnumMember(Value = "greater")]
        Greater,
        [EnumMember(Value = "crossing_above")]
        CrossingAbove,
        [EnumMember(Value = "crossing_below")]
        CrossingBelow,
    }
}