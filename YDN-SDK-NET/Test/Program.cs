using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YDN;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ////海运订阅DEMO
            //#region 海运订阅
            ////创建海运订阅对象
            //YDN.Tracking.Shipping seaTrack = new YDN.Tracking.Shipping("云当企业代码", "云当秘钥");

            //#region 海运批量订阅
            ////订阅的对象数组
            //List<YDN.Tracking.Shipping.Filter> filterLst = new List<YDN.Tracking.Shipping.Filter>();

            ////对象
            //YDN.Tracking.Shipping.Filter filter = new YDN.Tracking.Shipping.Filter
            //{
            //    blno = "966877857",
            //    carriercd = "MSK",
            //    portcd = "CNSZX"
            //};

            //filterLst.Add(filter);

            ////批量上传订阅
            //var uploadResult = seaTrack.BookingUploadLst(filterLst);

            ////批量下载订阅数据
            //var downloadResult = seaTrack.BookingDownloadLst(filterLst);
            //#endregion

            //#region 海运单票查询订阅

            ////单票查询并订阅
            //var result = seaTrack.BookingBlno("966877857", "", "MSK", "CNSZX");

            //#endregion
            //#endregion

            ////空运订阅DEMO
            //#region 空运订阅
            ////创建空运订阅对象
            //YDN.Tracking.Flight airTrack = new YDN.Tracking.Flight("云当企业代码", "云当秘钥");

            //#region 空运批量订阅
            ////订阅的对象数组
            List<YDN.Tracking.Flight.Filter> airFilterLst = new List<YDN.Tracking.Flight.Filter>();

            //单票订阅
            var shippingFilter = new YDN.Tracking.Shipping.Filter
            {
                //订阅号（提单号或订舱号都可）
                ReferenceNo = "WMHB004074",
                //箱号（使用箱号订阅时必填，否则可不填）
                CtnrNo = "",
                //船东代码（必填，详见云当船东代码）
                CarrierCd = "CMA"
            };
            var resultSubscribe = EnterpriseService.GetInstance("云当企业代码", "云当秘钥").Shipping().Subscribe(shippingFilter);
            var resultData = EnterpriseService.GetInstance("云当企业代码", "云当秘钥").Shipping().GetData(shippingFilter);
            
            //YDN.Tracking.Shipping.BookingResult
            //成功调用结果
            //result={status:0,message:null};
            //失败调用结果
            //result={status:1,message:"船东代码不可为空"};

            //调用结果result对象结构,YDN.ApiResponse
            //{
            //    /// <summary>
            //    /// 调用结果代码：0=成功；1=失败
            //    /// </summary>
            //    public int status { get; set; }
            //    /// <summary>
            //    /// 错误信息
            //    /// </summary>
            //    public string message { get; set; }
            //}


            //airFilterLst.Add(airFilter);

            ////空运批量上传订阅
            //var uploadAirResult = airTrack.BookingUploadLst(airFilterLst);

            ////空运批量下载订阅数据
            //var downloadAirResult = airTrack.BookingDownloadLst(airFilterLst);

            //#endregion

            ////空运单票订阅
            //#region 空运单票订阅
            //var airResult = airTrack.BookingAwbno("07419533780", "KL");
            //#endregion

            //#endregion


            #region service test

            var es = EnterpriseService.GetInstance("云当企业代码", "云当秘钥");
            //var result = EnterpriseService.GetInstance("云当企业代码", "云当秘钥").Flight().Subscribe(airFilter);
            //var resultList = EnterpriseService.GetInstance("云当企业代码", "云当秘钥").Flight().Subscribe(airFilterLst);
            //var result2 = EnterpriseService.GetInstance("云当企业代码", "云当秘钥").Shipping().Subscribe(shippingFilter);
            //var resultList2 = EnterpriseService.GetInstance("云当企业代码", "云当秘钥").Shipping().Subscribe(airFilterLst);

            #endregion
        }
    }
}
