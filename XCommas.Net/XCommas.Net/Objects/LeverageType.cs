using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum LeverageType
    {
        [EnumMember(Value = "not_specified")]
        NotSpecified,
        [EnumMember(Value = "cross")]
        Cross,
        [EnumMember(Value = "custom")]
        Custom,
    }
}
