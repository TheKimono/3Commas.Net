using System;
using System.Collections.Generic;
using System.Text;

namespace XCommas.Net
{
    public interface ICredentialsBearer
    {
        string ApiKey { get; }
        string Secret { get; }
    }
}
