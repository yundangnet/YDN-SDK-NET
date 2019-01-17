using Newtonsoft.Json;
using System.Collections.Generic;

namespace YDN
{
    public class RequestApi
    {
        public static string HttpGet(string apiName, string secret, Dictionary<string, string> query)
        {

            Dictionary<string, string> queryData = new Dictionary<string, string>();

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
            Dictionary<string, string> queryData = new Dictionary<string, string>();

            if (query != null)
            {
                foreach (var item in query.Keys)
                {
                    queryData.Add(item, query[item]);
                }
            }
            Dictionary<string, string> formData = new Dictionary<string, string>();

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
            Dictionary<string, string> queryData = new Dictionary<string, string>();

            if (query != null)
            {
                foreach (var item in query.Keys)
                {
                    queryData.Add(item, query[item]);
                }
            }

            Dictionary<string, string> formData = new Dictionary<string, string>();

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
            Dictionary<string, string> queryData = new Dictionary<string, string>();
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
