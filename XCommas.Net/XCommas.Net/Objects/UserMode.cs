using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum UserMode
    {
        [EnumMember(Value = "paper")]
        Paper,
        [EnumMember(Value = "real")]
        Real
    }
}
