using System;
using System.Collections.Generic;
using System.Text;

namespace XCommas.Net
{
    public class XCommasResponse<T>
    {
        public string Error { get; set; }
        public bool IsSuccess => string.IsNullOrEmpty(Error);
        public T Data { get; set; }
        public string RawData { get; set; }

        public XCommasResponse(T data, string rawData, string error)
        {
            this.Data = data;
            this.RawData = rawData;
            this.Error = error;
        }
    }
}
