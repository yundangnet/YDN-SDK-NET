using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDN
{
    public class ApiResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool? success { get; set; }
        /// <summary>
        /// 状态码，0=成功；1=失败；1000=查无数据；1001=(⊙ω⊙)系统繁忙，请稍候再查；1005=未订阅;1006=第一次订阅成功;1007=已存在
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string message { get; set; }
    }
}
