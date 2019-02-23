using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum SmartTradeCompletionType
    {
        [EnumMember(Value = "classic")]
        Classic,
        [EnumMember(Value = "step_sell")]
        StepSell
    }
}
