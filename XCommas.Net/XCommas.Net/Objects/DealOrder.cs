using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace XCommas.Net.Objects
{
    public enum DealOrder
    {
        [EnumMember(Value = "created_at")]
        CreatedAt,
        [EnumMember(Value = "closed_at")]
        ClosedAt,
    }
}
