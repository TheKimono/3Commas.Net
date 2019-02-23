using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

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
