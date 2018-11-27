using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //海运订阅DEMO
            #region 海运订阅
            //创建海运订阅对象
            YDN_SDK_NET.SDK.SeaTracking seaTrack = new YDN_SDK_NET.SDK.SeaTracking("云当企业代码", "云当秘钥");

            #region 批量订阅
            //订阅的对象数组
            List<YDN_SDK_NET.SDK.SeaTracking.Filter> filterLst = new List<YDN_SDK_NET.SDK.SeaTracking.Filter>();

            //对象
            YDN_SDK_NET.SDK.SeaTracking.Filter filter = new YDN_SDK_NET.SDK.SeaTracking.Filter();
            filter.blno = "966877857";
            filter.carriercd = "MSK";
            filter.portcd = "CNSZX";

            filterLst.Add(filter);

            //批量上传订阅
            var uploadResult = seaTrack.BookingUploadLst(filterLst);

            //批量下载订阅数据
            var downloadResult = seaTrack.BookingDownloadLst(filterLst);
            #endregion

            #region 单票查询订阅

            //单票查询并订阅
            var result = seaTrack.BookingBlno("966877857", "", "MSK", "CNSZX");

            #endregion
            #endregion

            //空运订阅DEMO
            #region 空运订阅
            //创建空运订阅对象
            YDN_SDK_NET.SDK.AirTracking airTrack = new YDN_SDK_NET.SDK.AirTracking("云当企业代码", "云当秘钥");

            #region 批量订阅
            //订阅的对象数组
            List<YDN_SDK_NET.SDK.AirTracking.Filter> airFilterLst = new List<YDN_SDK_NET.SDK.AirTracking.Filter>();

            YDN_SDK_NET.SDK.AirTracking.Filter airFilter = new YDN_SDK_NET.SDK.AirTracking.Filter();
            airFilter.awbno = "07419533780";
            airFilter.carriercd = "KL";

            airFilterLst.Add(airFilter);

            //空运批量上传订阅
            var uploadAirResult = airTrack.BookingUploadLst(airFilterLst);

            //空运批量下载订阅数据
            var downloadAirResult = airTrack.BookingDownloadLst(airFilterLst);

            #endregion

            //空运单票订阅
            #region 单票订阅
            var airResult = airTrack.BookingAwbno("07419533780", "KL");
            #endregion

            #endregion

        }
    }
}
