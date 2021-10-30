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
        [EnumMember(Value = "BB-20-1-UB")] 
        BB_20_1_UB,
        [EnumMember(Value = "BB-20-2-UB")] 
        BB_20_2_UB,
        [EnumMember(Value = "MFI-14\u003e65")] 
        MFI_14_65,
        [EnumMember(Value = "CCI-40\u003e0")] 
        CCI_40_0,
        [EnumMember(Value = "CCI-40\u003e100")]
        CCI_40_100
    }
}
