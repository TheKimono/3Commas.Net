﻿using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using XCommas.Net.Objects;

namespace XCommas.Net
{
    public class XCommasRequest : IDisposable
    {
        internal HttpRequestMessage request;
        private JsonSerializerSettings serializerSettings;
        bool disposed = false;
        private string content;

        private XCommasRequest()
        {
            this.request = new HttpRequestMessage();
            this.serializerSettings = new JsonSerializerSettings();
            this.serializerSettings.NullValueHandling = NullValueHandling.Ignore;
        }

        public XCommasRequest WithSerializedContent(object content)
        {
            this.content = JsonConvert.SerializeObject(content, serializerSettings);
            request.Content = new StringContent(this.content, Encoding.UTF8, "application/json");
            return this;
        }

        public XCommasRequest AddEnterpriseAppId(string appId)
        {
            if (!string.IsNullOrWhiteSpace(appId))
            {
                this.request.Headers.Add("commas-app-id", appId);
            }

            return this;
        }

        public XCommasRequest Force(UserMode userMode)
        {
            var userModeStr = userMode == UserMode.Paper
                ? "paper"
                : "real";
            this.request.Headers.Add("Forced-Mode", userModeStr);

            return this;
        }

        public XCommasRequest Sign(ICredentialsBearer credentialsBearer)
        {
            string toSign;

            if (this.content != null)
            {
                toSign = $"{request.RequestUri.AbsolutePath}?{this.content}";
            }
            else
            {
                toSign = request.RequestUri.PathAndQuery;
            }

            var signature = XCommasHelper.Sign(toSign, credentialsBearer.Secret);
            this.request.Headers.Add("Signature", signature);
            this.request.Headers.Add("APIKEY", credentialsBearer.ApiKey);
            return this;
        }

        public static XCommasRequest Post(string uri)
        {
            var result = new XCommasRequest();
            result.request.RequestUri = new Uri(uri, UriKind.RelativeOrAbsolute);
            result.request.Method = new HttpMethod("POST");
            return result;
        }
        public static XCommasRequest Get(string uri)
        {
            var result = new XCommasRequest();
            result.request.RequestUri = new Uri(uri, UriKind.RelativeOrAbsolute);
            result.request.Method = new HttpMethod("GET");
            return result;
        }

        public static XCommasRequest Delete(string uri)
        {
            var result = new XCommasRequest();
            result.request.RequestUri = new Uri(uri, UriKind.RelativeOrAbsolute);
            result.request.Method = new HttpMethod("DELETE");
            return result;
        }

        public static XCommasRequest Patch(string uri)
        {
            var result = new XCommasRequest();
            result.request.RequestUri = new Uri(uri, UriKind.RelativeOrAbsolute);
            result.request.Method = new HttpMethod("PATCH");
            return result;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                request?.Dispose();
            }

            disposed = true;
        }
    }
}
