using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDN.Tracking
{
    public class FlightFilter
    {
        /// <summary>
        /// 运单号
        /// </summary>
        public string awbno { get; set; }
        /// <summary>
        /// 航司代码（二字码，必填）
        /// </summary>
        public string carriercd { get; set; }
    }

    public class BookingResult
    {
    }

    public class Flight : IService<Flight.Filter>, IService<BookingResult, Flight.Filter>
    {
        /// <summary>
        /// 空运订阅之单票订阅
        /// </summary>
        /// <param name="awbno">运单号</param>
        /// <param name="carriercd">航司代码（二字码）</param>
        /// <returns></returns>
        public string BookingAwbno(string awbno, string carriercd)
        {
            return "";
        }

        #region 对象模型
        /// <summary>
        /// 空运上传订阅返回值模型
        /// </summary>
        public class AirBkUploadRespone
        {
            public bool success { get; set; }
            public int number { get; set; }

            public List<AirBkResultModule> result { get; set; }
        }


        public class AirBkResultModule
        {
            /// <summary>
            /// 本地关键字
            /// </summary>
            public string localkeyid { get; set; }
            /// <summary>
            /// 一程空运单号
            /// </summary>
            public string awbno { get; set; }
            /// <summary>
            /// 一程航空公司
            /// </summary>
            public string carriercd { get; set; }
            /// <summary>
            /// 二程空运单号
            /// </summary>
            public string awbno2 { get; set; }
            /// <summary>
            /// 二程航空公司
            /// </summary>
            public string carriercd2 { get; set; }
            /// <summary>
            /// 三程空运单号
            /// </summary>
            public string awbno3 { get; set; }
            /// <summary>
            /// 三程航空公司
            /// </summary>
            public string carriercd3 { get; set; }
            /// <summary>
            /// 是否订阅成功
            /// </summary>
            public bool success { get; set; }
            /// <summary>
            /// 错误信息
            /// </summary>
            public string message { get; set; }
        }

        public class AirBookingResult : ApiResponse
        {
            private AirLinerTracking _objairlinertracking;

            public AirLinerTracking objairlinertracking
            {
                get
                {
                    if (_objairlinertracking == null)
                    {
                        _objairlinertracking = new AirLinerTracking();

                    }
                    return _objairlinertracking;
                }
                set
                {
                    _objairlinertracking = value;
                }
            }
        }

        public class AirLinerTracking
        {
            public string keyid { get; set; }
            /// <summary>
            /// 本地keyid
            /// </summary>
            public string localkeyid { get; set; }
            /// <summary>
            /// 空运单号表主键
            /// </summary>
            public string fkeyid { get; set; }
            /// <summary>
            /// 空运单号
            /// </summary>
            public string awbno { get; set; }
            /// <summary>
            /// 航班号
            /// </summary>
            public string flightno { get; set; }
            /// <summary>
            /// 始发站
            /// </summary>
            public string org { get; set; }
            /// <summary>
            /// 始发站代码
            /// </summary>
            public string orgcd { get; set; }
            /// <summary>
            /// 目的站
            /// </summary>
            public string dst { get; set; }
            /// <summary>
            /// 目的站代码
            /// </summary>
            public string dstcd { get; set; }
            /// <summary>
            /// 当前节点
            /// </summary>
            public string currentnode { get; set; }
            /// <summary>
            /// 当前节点时间
            /// </summary>
            public string currentnodetime { get; set; }
            /// <summary>
            /// 当前节点地点
            /// </summary>
            public string currentnodeplace { get; set; }
            /// <summary>
            /// 航空公司代码
            /// </summary>
            public string carriercd { get; set; }
            /// <summary>
            /// 航空公司
            /// </summary>
            public string carrier { get; set; }
            /// <summary>
            /// 二程空运单号
            /// </summary>
            public string awbno2 { get; set; }
            /// <summary>
            /// 二程航空公司代码
            /// </summary>
            public string carriercd2 { get; set; }
            /// <summary>
            /// 二程航空公司
            /// </summary>
            public string carrier2 { get; set; }
            /// <summary>
            /// 三程空运单号
            /// </summary>
            public string awbno3 { get; set; }
            /// <summary>
            /// 三程航空公司代码
            /// </summary>
            public string carriercd3 { get; set; }
            /// <summary>
            /// 三程航空公司
            /// </summary>
            public string carrier3 { get; set; }
            /// <summary>
            /// 修改时间
            /// </summary>
            public string updatetime { get; set; }
            /// <summary>
            /// 创建时间
            /// </summary>
            public string createtime { get; set; }
            /// <summary>
            /// 订舱时间
            /// </summary>
            public string bkdtime { get; set; }
            /// <summary>
            /// 订舱地点
            /// </summary>
            public string bkdplace { get; set; }
            /// <summary>
            /// 收货时间
            /// </summary>
            public string rcstime { get; set; }
            /// <summary>
            /// 收货地点
            /// </summary>
            public string rcsplace { get; set; }
            /// <summary>
            /// 配载时间
            /// </summary>
            public string mnftime { get; set; }
            /// <summary>
            /// 配载地点
            /// </summary>
            public string mnfplace { get; set; }
            /// <summary>
            ///起飞时间
            /// </summary>
            public string deptime { get; set; }
            /// <summary>
            ///起飞地点
            /// </summary>
            public string depplace { get; set; }
            /// <summary>
            /// 中转抵达时间
            /// </summary>
            public string tartime { get; set; }
            /// <summary>
            /// 中转抵达地点
            /// </summary>
            public string tarplace { get; set; }
            /// <summary>
            /// 中转起飞时间
            /// </summary>
            public string tdetime { get; set; }
            /// <summary>
            /// 中转起飞地点
            /// </summary>
            public string tdeplace { get; set; }
            /// <summary>
            /// 抵达时间
            /// </summary>
            public string arrtime { get; set; }
            /// <summary>
            /// 抵达地点
            /// </summary>
            public string arrplace { get; set; }
            /// <summary>
            /// 收单时间
            /// </summary>
            public string rwbtime { get; set; }
            /// <summary>
            /// 收单地点
            /// </summary>
            public string rwbplace { get; set; }
            /// <summary>
            /// 卸货时间
            /// </summary>
            public string rcftime { get; set; }
            /// <summary>
            /// 卸货地点
            /// </summary>
            public string rcfplace { get; set; }
            /// <summary>
            /// 清关时间
            /// </summary>
            public string custime { get; set; }
            /// <summary>
            /// 清关地点
            /// </summary>
            public string cusplace { get; set; }
            /// <summary>
            /// 到货通知时间
            /// </summary>
            public string nfdtime { get; set; }
            /// <summary>
            /// 到货通知地点
            /// </summary>
            public string nfdplace { get; set; }
            /// <summary>
            /// 提货时间
            /// </summary>
            public string dlvtime { get; set; }
            /// <summary>
            /// 提货地点
            /// </summary>
            public string dlvplace { get; set; }
            /// <summary>
            /// 结束时间
            /// </summary>
            public string endtime { get; set; }
            /// <summary>
            /// 订阅号
            /// </summary>
            public string referenceno { get; set; }

            public List<AirLinerTrackingStatus> lstairlinertrackingstatus { get; set; }

        }
        public class AirLinerTrackingStatus
        {
            /// <summary>
            /// 
            /// </summary>
            public string keyid { get; set; }
            /// <summary>
            ///空运线性记录表主键
            /// </summary>
            public string fkeyid { get; set; }
            /// <summary>
            /// 空运单号
            /// </summary>
            public string awbno { get; set; }
            /// <summary>
            /// 状态代码
            /// </summary>
            public string statuscd { get; set; }
            /// <summary>
            /// 状态描述
            /// </summary>
            public string statedescription { get; set; }
            /// <summary>
            /// 状态描述_英文
            /// </summary>
            public string statedescription_en { get; set; }
            /// <summary>
            /// 状态时间
            /// </summary>
            public string statustime { get; set; }
            /// <summary>
            /// 状态地点
            /// </summary>
            public string statusplace { get; set; }
            /// <summary>
            /// 航班号
            /// </summary>
            public string flightno { get; set; }
            /// <summary>
            /// 是否预计时间（Y=是，N=否）
            /// </summary>
            public string isest { get; set; }
            /// <summary>
            /// 更新时间
            /// </summary>
            public string updatetime { get; set; }
            /// <summary>
            /// 创建时间
            /// </summary>
            public string createtime { get; set; }
            /// <summary>
            /// 序号
            /// </summary>
            public int sno { get; set; }
            /// <summary>
            /// 件数
            /// </summary>
            public int? pieces { get; set; }
            /// <summary>
            /// 重量
            /// </summary>
            public decimal? weight { get; set; }
            /// <summary>
            /// 体积
            /// </summary>
            public decimal? volume { get; set; }
        }
        public class Filter : FlightFilter
        {

        }
        #endregion

        public string CompanyId { get; set; }

        public string Secret { get; set; }

        public void Remove(Flight.Filter filter)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 单票查询并订阅
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public AirBookingResult Subscribe(Flight.Filter filter)
        {
            string url = "http://apis.yundangnet.com/api/v1/airbooking-download";
            Dictionary<string, string> queryData = new Dictionary<string, string>();
            Dictionary<string, string> formData = new Dictionary<string, string>();
            queryData.Add("companyid", CompanyId);

            string formString1 = JsonConvert.SerializeObject(filter);
            formData.Add("data", formString1);

            HttpUtil.HashRequest(queryData, formData, Secret, true);
            var json = HttpUtil.HttpPost(url, queryData, formData);
            var results = JsonConvert.DeserializeObject<AirBookingResult>(json);
            return results;
        }

        /// <summary>
        /// 批量上传订阅
        /// </summary>
        /// <param name="filterList"></param>
        /// <returns></returns>
        public AirBkUploadRespone Subscribe(List<Flight.Filter> filterList)
        {
            string url = "http://apis.yundangnet.com/api/v1/airbookings";
            Dictionary<string, string> queryData = new Dictionary<string, string>();
            Dictionary<string, string> formData = new Dictionary<string, string>();
            queryData.Add("companyid", CompanyId);

            string formString1 = JsonConvert.SerializeObject(filterList);
            formData.Add("data", formString1);

            HttpUtil.HashRequest(queryData, formData, Secret, true);
            var json = HttpUtil.HttpPost(url, queryData, formData);
            var results = JsonConvert.DeserializeObject<AirBkUploadRespone>(json);
            return results;
        }

        public AirBookingResult GetData(Flight.Filter filter)
        {
            string url = "http://apis.yundangnet.com/api/v1/airbooking-download";
            Dictionary<string, string> queryData = new Dictionary<string, string>();
            Dictionary<string, string> formData = new Dictionary<string, string>();
            queryData.Add("companyid", CompanyId);

            string formString1 = JsonConvert.SerializeObject(filter);
            formData.Add("data", formString1);

            HttpUtil.HashRequest(queryData, formData, Secret, true);
            var json = HttpUtil.HttpPost(url, queryData, formData);
            var results = JsonConvert.DeserializeObject<AirBookingResult>(json);
            return results;
        }

        public List<AirBookingResult> GetData(List<Flight.Filter> filterList)
        {
            string url = "http://apis.yundangnet.com/api/v1/airbooking-liner";
            Dictionary<string, string> queryData = new Dictionary<string, string>();
            Dictionary<string, string> formData = new Dictionary<string, string>();
            queryData.Add("companyid", CompanyId);

            string formString1 = JsonConvert.SerializeObject(filterList);
            formData.Add("data", formString1);

            HttpUtil.HashRequest(queryData, formData, Secret, true);
            var json = HttpUtil.HttpPost(url, queryData, formData);
            var results = JsonConvert.DeserializeObject<List<AirBookingResult>>(json);
            return results;
        }
    }
}
