using KinnCould;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDN_SDK_NET
{
    public class RequestApi
    {
        public static string HttpGet(string apiName, string secret, Dictionary<string, string> query)
        {

            QueryCollection queryData = new QueryCollection();

            if (query != null)
            {
                foreach (var item in query.Keys)
                {
                    queryData.Add(item, query[item]);
                }
            }
            HttpUtil.HashRequest(queryData, secret, true);
            var json = HttpUtil.HttpGet(apiName, queryData);
            return json;
        }
        public static string HttpPost(string apiName, string secret, Dictionary<string, string> query, Dictionary<string, string> form)
        {
            QueryCollection queryData = new QueryCollection();

            if (query != null)
            {
                foreach (var item in query.Keys)
                {
                    queryData.Add(item, query[item]);
                }
            }
            FormCollection formData = new FormCollection();

            if (form != null)
            {
                foreach (var item in form.Keys)
                {
                    formData.Add(item, form[item]);
                }
            }
            HttpUtil.HashRequest(queryData, formData, secret, true);
            var json = HttpUtil.HttpPost(apiName, queryData, formData);
            return json;
        }
        public static string HttpPut(string apiName, string secret, Dictionary<string, string> query, Dictionary<string, string> form)
        {
            QueryCollection queryData = new QueryCollection();

            if (query != null)
            {
                foreach (var item in query.Keys)
                {
                    queryData.Add(item, query[item]);
                }
            }

            FormCollection formData = new FormCollection();

            if (form != null)
            {
                foreach (var item in form.Keys)
                {
                    formData.Add(item, form[item]);
                }
            }
            HttpUtil.HashRequest(queryData, formData, secret, true);
            var json = HttpUtil.HttpPut(apiName, queryData, formData);
            return json;
        }
        public static string HttpDelete(string apiName, string secret, Dictionary<string, string> query)
        {
            var queryString = JsonConvert.SerializeObject(query);
            QueryCollection queryData = new QueryCollection();
            if (query != null)
            {
                foreach (var item in query.Keys)
                {
                    queryData.Add(item, query[item]);
                }
            }
            HttpUtil.HashRequest(queryData, secret, true);
            var json = HttpUtil.HttpDelete(apiName, queryData);
            return json;
        }
    }
}
