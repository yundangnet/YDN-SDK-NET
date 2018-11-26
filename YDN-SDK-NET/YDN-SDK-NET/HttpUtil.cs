using KinnCould;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace YDN_SDK_NET
{
    public class HttpUtil
    {
        /// <summary>
        /// 提交post请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="queryString">查询参数</param>
        /// <param name="formString">提交数据</param>
        /// <returns>服务端响应</returns>
        public static string HttpPost(string url, string queryString, string formString)
        {
            //添加查询参数
            if (!string.IsNullOrEmpty(queryString))
            {
                url += "?";
                url += queryString;
            }
            string responseFromServer = string.Empty;
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            byte[] byteArray = Encoding.UTF8.GetBytes(formString);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
            }
            using (WebResponse response = request.GetResponse())
            {
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    responseFromServer = reader.ReadToEnd();

                    reader.Close();
                    dataStream.Close();
                    response.Close();
                }
            }
            return responseFromServer;
        }

        /// <summary>
        /// 提交post请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="queryData">查询参数</param>
        /// <param name="formData">提交数据</param>
        /// <returns>服务端响应</returns>
        public static string HttpPost(string url, QueryCollection queryData, FormCollection formData)
        {
            return HttpPost(url, ConvertToQueryString(EncodeQueryCollection(queryData)), ConvertToQueryString(EncodeFormCollection(formData)));
        }

        /// <summary>
        /// 提交put请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="queryString">查询参数</param>
        /// <param name="formString">提交数据</param>
        /// <returns>服务端响应</returns>
        public static string HttpPut(string url, string queryString, string formString)
        {
            //添加查询参数
            if (!string.IsNullOrEmpty(queryString))
            {
                url += "?";
                url += queryString;
            }
            string responseFromServer = string.Empty;
            WebRequest request = WebRequest.Create(url);
            request.Method = "PUT";
            byte[] byteArray = Encoding.UTF8.GetBytes(formString);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
            }


            using (WebResponse response = request.GetResponse())
            {
                using (var dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    responseFromServer = reader.ReadToEnd();
                    reader.Close();
                    dataStream.Close();
                }
                response.Close();
            }
            return responseFromServer;
        }

        /// <summary>
        /// 提交put请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="queryData">查询参数</param>
        /// <param name="formData">提交数据</param>
        /// <returns>服务端响应</returns>
        public static string HttpPut(string url, QueryCollection queryData, FormCollection formData)
        {
            return HttpPut(url, ConvertToQueryString(EncodeQueryCollection(queryData)), ConvertToQueryString(EncodeFormCollection(formData)));
        }

        /// <summary>
        /// 提交get请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="queryString">查询参数</param>      
        /// <returns>服务端响应</returns>
        public static string HttpGet(string url, string queryString)
        {
            //添加查询参数
            if (!string.IsNullOrEmpty(queryString))
            {
                url += "?";
                url += queryString;
            }
            string responseFromServer = string.Empty;
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            using (WebResponse response = request.GetResponse())
            {
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    responseFromServer = reader.ReadToEnd();
                    reader.Close();
                    dataStream.Close();
                }
                response.Close();
            }

            return responseFromServer;


        }

        /// <summary>
        /// 提交get请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="queryData">查询参数</param>      
        /// <returns>服务端响应</returns>
        public static string HttpGet(string url, QueryCollection queryData)
        {
            return HttpGet(url, ConvertToQueryString(EncodeQueryCollection(queryData)));
        }

        /// <summary>
        /// 提交delete请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="queryString">查询参数</param>      
        /// <returns>服务端响应</returns>
        public static string HttpDelete(string url, string queryString)
        {
            //System.GC.Collect();
            //添加查询参数
            if (!string.IsNullOrEmpty(queryString))
            {
                url += "?";
                url += queryString;
            }
            string responseFromServer = string.Empty;
            WebRequest request = WebRequest.Create(url);
            request.Method = "DELETE";
            using (WebResponse response = request.GetResponse())
            {
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    responseFromServer = reader.ReadToEnd();

                    reader.Close();
                    dataStream.Close();
                }
                response.Close();
            }
            return responseFromServer;
        }

        /// <summary>
        /// 提交delete请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="queryData">查询参数</param>      
        /// <returns>服务端响应</returns>
        public static string HttpDelete(string url, QueryCollection queryData)
        {
            return HttpDelete(url, ConvertToQueryString(EncodeQueryCollection(queryData)));
        }

        /// <summary>
        /// 将参数字典转为查询字符串
        /// </summary>
        /// <param name="queryData">参数字典</param>
        /// <returns>查询字符串</returns>
        public static string ConvertToQueryString(IEnumerable<KeyValuePair<string, string>> queryData)
        {
            string result = string.Empty;
            if (queryData != null && queryData.Count() > 0)
            {
                foreach (KeyValuePair<string, string> item in queryData)
                {
                    result += string.Format("{0}={1}&", item.Key, item.Value);
                }

                result = result.Remove(result.Length - 1, 1);
            }

            return result;
        }

        /// <summary>
        /// 将queryString进行编码
        /// </summary>
        /// <param name="queryData">需要编码的queryString</param>
        /// <returns>编码后的参数</returns>
        public static QueryCollection EncodeQueryCollection(QueryCollection queryData)
        {
            QueryCollection result = new QueryCollection();

            foreach (KeyValuePair<string, string> item in queryData)
            {
                result.Add(HttpUtility.UrlEncode(item.Key), HttpUtility.UrlEncode(item.Value));
            }

            return result;
        }

        //<summary>
        //将formData进行编码
        //</summary>
        //<param name="formData">需要编码的formData</param>
        //<returns>编码后的参数</returns>
        public static FormCollection EncodeFormCollection(FormCollection formData)
        {
            FormCollection result = new FormCollection();

            foreach (KeyValuePair<string, string> item in formData)
            {
                result.Add(HttpUtility.UrlEncode(item.Key), HttpUtility.UrlEncode(item.Value));
            }

            return result;
        }


        private static IEnumerable<KeyValuePair<string, string>> OrderCollection(CollectionBase collection)
        {
            //排序查询字符串
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> item in collection)
            {
                dict.Add(item.Key, item.Value);
            }

            var orderedData = (
                        from query in dict
                        orderby query.Key ascending
                        select query).ToDictionary(pair => pair.Key, pair => pair.Value);

            return orderedData;
        }



        /// <summary>
        /// 请求的参数进行Hash计算
        /// </summary>
        /// <param name="queryData">提交的查询参数集合</param>
        /// <param name="publickey">签名的公钥</param>
        /// <param name="addTimestamp">是否添加时间戳</param>
        /// <remarks>配合VerifyHashRequest使用</remarks>
        public static void HashRequest(QueryCollection queryData, string publickey, bool addTimestamp)
        {
            if (queryData == null)
            {
                return;
            }

            //添加时间戳
            if (addTimestamp)
            {
                queryData.Add("timestamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            }

            var orderedQueryData = OrderCollection(queryData);
            string originalContent = ConvertToQueryString(orderedQueryData) + "||" + publickey;
            string hashContent = SecurityUtil.HashData(originalContent);
            queryData.Add("hash", hashContent);
        }
        /// <summary>
        /// 请求的参数进行Hash计算
        /// </summary>
        /// <param name="queryData">提交的查询参数集合</param>
        /// <param name="formData">提交的表单数据集合</param>
        /// <param name="publickey">签名的公钥</param>
        /// <param name="addTimestamp">是否添加时间戳</param>
        /// <remarks>配合VerifyHashRequest使用</remarks>
        public static void HashRequest(QueryCollection queryData, FormCollection formData, string publickey, bool addTimestamp)
        {
            if (queryData == null)
            {
                return;
            }

            var orderedQueryData = OrderCollection(queryData);

            if (formData == null)
            {
                formData = new FormCollection();
            }

            //添加时间戳
            if (addTimestamp)
            {
                formData.Add("timestamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            }

            //排序表单数据
            Dictionary<string, string> formDict = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> item in formData)
            {
                formDict.Add(item.Key, item.Value);
            }

            var orderedFormData = OrderCollection(formData);


            string originalContent = ConvertToQueryString(orderedQueryData) + "||" + ConvertToQueryString(orderedFormData) + "||" + publickey;
            string hashContent = SecurityUtil.HashData(originalContent);
            formData.Add("hash", hashContent);
        }
    }
}
