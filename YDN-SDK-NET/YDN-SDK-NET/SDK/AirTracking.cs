﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDN_SDK_NET.SDK
{
    public class AirTracking
    {
        public AirTracking()
        {
            _companyid = "";
            _secret = "";
        }
        public AirTracking(string setCompanycd, string setSecret)
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
        /// <summary>
        /// 空运订阅之即时更新
        /// </summary>
        /// <param name="blno"></param>
        /// <param name="carriercd"></param>
        /// <param name="portcd"></param>
        /// <returns></returns>
        public string QueryAwbno(string awbno, string carriercd)
        {
            return "";
        }

        public class Filter
        {
            /// <summary>
            /// 运单号
            /// </summary>
            public string awbno { get; set; }
            /// <summary>
            /// 航司代码（必填）
            /// </summary>
            public string carriercd { get; set; }
        }

        /// <summary>
        /// 空运订阅之批量上传订阅
        /// </summary>
        /// <param name="filters">订阅单号对象数组</param>
        /// <returns></returns>
        public string BookingUploadLst(List<Filter> filterLst)
        {
            return "";
        }

        /// <summary>
        /// 空运订阅之批量下载订阅数据
        /// </summary>
        /// <param name="filters">订阅提单号对象数组</param>
        /// <returns></returns>
        public string BookingDownloadLst(List<Filter> filterLst)
        {
            return "";
        }
    }
}