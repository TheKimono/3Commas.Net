using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum TaPresetsType
    {
        [EnumMember(Value = "BB-20-1-LB")]
        BB_20_1_LB,
        [EnumMember(Value = "BB-20-2-LB")]
        BB_20_2_LB,
        [EnumMember(Value = "MFI-14\u003c40")]
        MFI_14_40,
        [EnumMember(Value = "MFI-14\u003c20")]
        MFI_14_20,
        [EnumMember(Value = "CCI-40\u003c-200")]
        CCI_40_200,
    }
}
