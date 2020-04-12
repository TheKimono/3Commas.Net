using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace XCommas.Net.Objects
{
    public enum UserMode
    {
        [EnumMember(Value = "paper")]
        Paper,
        [EnumMember(Value = "real")]
        Real
    }
}
