using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum BotScope
    {
        [EnumMember(Value = "enabled")]
        Enabled,
        [EnumMember(Value = "disabled")]
        Disabled,
    }
}
