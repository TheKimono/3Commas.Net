using System.Runtime.Serialization;

namespace XCommas.Net.Objects
{
    public enum TaPresetsType
    {
        [EnumMember(Value = "BB-20-1-LB")] BB_20_1_LB,
        [EnumMember(Value = "BB-20-2-LB")] BB_20_2_LB,
        [EnumMember(Value = "MFI-14\u003c40")] MFI_14_40,
        [EnumMember(Value = "MFI-14\u003c20")] MFI_14_20,
        [EnumMember(Value = "CCI-40\u003c-200")] CCI_40_200,
        [EnumMember(Value = "MACD-12-26-9")] MACD_12_26_9,
        [EnumMember(Value = "Parabolic-SAR")] Parabolic_SAR,
        [EnumMember(Value = "SMA-20-50")] SMA_20_50,
        [EnumMember(Value = "SMA-50-100")] SMA_50_100,
        [EnumMember(Value = "SMA-50-200")] SMA_50_200,
        [EnumMember(Value = "SMA-100-200")] SMA_100_200,
        [EnumMember(Value = "BB-20-1-UB")] BB_20_1_UB,
        [EnumMember(Value = "BB-20-2-UB")] BB_20_2_UB,
        [EnumMember(Value = "MFI-14\u003e65")] MFI_14_65,
        [EnumMember(Value = "CCI-40\u003e0")] CCI_40_0,
        [EnumMember(Value = "CCI-40\u003e100")] CCI_40_100,
        [EnumMember(Value = "Heikin-Ashi-1")] Heikin_Ashi_1,
        [EnumMember(Value = "Heikin-Ashi-3")] Heikin_Ashi_3,
        [EnumMember(Value = "Heikin-Ashi-5")] Heikin_Ashi_5
    }
}
