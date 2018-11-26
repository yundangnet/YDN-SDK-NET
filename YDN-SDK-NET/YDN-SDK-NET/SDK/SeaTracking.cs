using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDN_SDK_NET.SDK
{
    /// <summary>
    /// 海运跟踪API
    /// </summary>
    public class SeaTracking
    {
        public SeaTracking()
        {
            _companyid = "";
            _secret = "";
        }
        public SeaTracking(string setCompanycd, string setSecret)
        {
            _companyid = setCompanycd;
            _secret = setSecret;
        }

        private string _companyid;
        private string _secret;
        public string companyId
        {
            get { return _companyid; }
            set { _companyid = value; }
        }
        public string secret
        {
            get { return _secret; }
            set { _secret = value; }
        }

        public class Filter
        {
            public string blno { get; set; }
            public string carriercd { get; set; }
            public string portcd { get; set; }
        }



        /// <summary>
        /// 海运订阅之批量上传订阅提单号
        /// </summary>
        /// <param name="filters">订阅提单号对象数组</param>
        /// <returns></returns>
        public string BookingUploadBlnoLst(List<Filter> filters)
        {
            return "";
        }

        /// <summary>
        /// 海运订阅之批量下载订阅数据
        /// </summary>
        /// <param name="filters">订阅提单号对象数组</param>
        /// <returns></returns>
        public string BookingDownloadBlnoLst(List<Filter> filters)
        {
            return "";
        }

        /// <summary>
        /// 海运订阅之即时更新
        /// </summary>
        /// <param name="blno"></param>
        /// <param name="carriercd"></param>
        /// <param name="portcd"></param>
        /// <returns></returns>
        public string BookingBlno(string blno, string carriercd, string portcd)
        {
            return "";
        }

        /// <summary>
        /// 箱号订阅之即时更新
        /// </summary>
        /// <param name="ctnrno"></param>
        /// <param name="carriercd"></param>
        /// <param name="vslname"></param>
        /// <param name="voy"></param>
        /// <param name="portcd"></param>
        /// <returns></returns>
        public string BookingCtnrno(string ctnrno, string carriercd, string vslname, string voy, string portcd)
        {
            return "";
        }
    }
}
