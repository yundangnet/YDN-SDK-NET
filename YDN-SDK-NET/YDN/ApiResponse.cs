using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDN
{
    public class ApiResponse<TResult> : ApiResponse
    {

        public List<TResult> results { get; set; }
    }

        //    /// <summary>
        ///// 调用API状态：true=成功调用；false=失败
        ///// </summary>
        //public bool success { get; set; }
    public class ApiResponse
    {
        /// <summary>
        /// 调用结果代码：0=成功；1=失败
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string message { get; set; }
    }
}
