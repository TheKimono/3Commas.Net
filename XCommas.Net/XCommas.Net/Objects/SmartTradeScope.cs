using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace XCommas.Net.Objects
{
    public enum SmartTradeScope
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "finished")]
        Finished,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "all")]
        All
    }
}
