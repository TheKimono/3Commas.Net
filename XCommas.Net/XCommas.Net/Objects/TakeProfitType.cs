using Newtonsoft.Json;
using System.Runtime.Serialization;
using XCommas.Net.Converters;

namespace XCommas.Net.Objects
{
    public enum TakeProfitType
    {
        [EnumMember(Value = "base")]
        Base,
        [EnumMember(Value = "total")]
        Total
    }
}
