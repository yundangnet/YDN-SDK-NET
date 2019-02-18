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
    public class Flight : IService<FlightFilter>
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

        public class Filter : FlightFilter
        {

        }

        /// <summary>
        /// 空运订阅之批量上传订阅
        /// </summary>
        /// <param name="filterLst">订阅单号对象数组</param>
        /// <returns></returns>
        public string BookingUploadLst(List<Filter> filterLst)
        {
            return "";
        }

        /// <summary>
        /// 空运订阅之批量下载订阅数据
        /// </summary>
        /// <param name="filterLst">订阅提单号对象数组</param>
        /// <returns></returns>
        public string BookingDownloadLst(List<Filter> filterLst)
        {
            return "";
        }
        public string CompanyId { get; set; }

        public string Secret { get; set; }

        public void Remove(FlightFilter filter)
        {
            throw new NotImplementedException();
        }

        public ApiResponse With(FlightFilter filter)
        {
            throw new NotImplementedException();
        }

        public ApiResponse With(List<FlightFilter> filterList)
        {
            throw new NotImplementedException();
        }
    }
}
