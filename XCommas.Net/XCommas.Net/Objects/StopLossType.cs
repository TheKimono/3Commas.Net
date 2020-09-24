using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum StopLossType
    {
        [EnumMember(Value = "stop_loss")]
        StopLoss,
        [EnumMember(Value = "stop_loss_and_disable_bot")]
        StopLossAndDisableBot
    }
}