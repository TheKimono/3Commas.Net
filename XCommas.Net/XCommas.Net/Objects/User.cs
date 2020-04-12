using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace XCommas.Net.Objects
{
    public enum User
    {
        [EnumMember(Value = "paper")]
        paper,
        [EnumMember(Value = "real")]
        real
    }
}
