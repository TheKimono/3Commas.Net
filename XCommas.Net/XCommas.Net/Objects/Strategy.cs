using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace XCommas.Net.Objects
{
    public enum Strategy
    {
        [EnumMember(Value = "long")]
        Long,
        [EnumMember(Value = "short")]
        Short
    }
}
