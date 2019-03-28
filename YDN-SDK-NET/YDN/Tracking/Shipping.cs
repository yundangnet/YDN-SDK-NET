using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDN.Tracking
{
    #region 对象模型
    /// <summary>
    /// 上传订阅对象
    /// </summary>
    public class ShippingFilter
    {
        /// <summary>
        /// 订阅号（提单号或订舱号）
        /// </summary>
        public string ReferenceNo { get; set; }
        /// <summary>
        /// 箱号
        /// </summary>
        public string CtnrNo { get; set; }
        /// <summary>
        /// 船东代码（必填）
        /// </summary>
        public string CarrierCd { get; set; }
        /// <summary>
        /// 装货港港口代码
        /// </summary>
        public string PortCd { get; set; }
        /// <summary>
        /// 目的港港口代码
        /// </summary>
        public string PodCd { get; set; }
    }



    /// <summary>
    /// 订阅主表
    /// </summary>
    public class LinerTracking
    {
        public string KeyId { get; set; }
        /// <summary>
        /// 本地keyid
        /// </summary>
        public string localkeyid { get; set; }
        /// <summary>
        /// 堆场提单信息主键
        /// </summary>
        public string dkeyid { get; set; }
        /// <summary>
        /// 码头箱动态主键
        /// </summary>
        public string tkeyid { get; set; }
        /// <summary>
        /// 海运提单信息主键
        /// </summary>
        public string ckeyid { get; set; }
        /// <summary>
        /// 提单号前缀
        /// </summary>
        public string blprefix { get; set; }
        /// <summary>
        /// 提单号
        /// </summary>
        public string blno { get; set; }
        /// <summary>
        /// 订舱号
        /// </summary>
        public string bkgno { get; set; }
        /// <summary>
        /// 码头单号terminal reference no
        /// </summary>
        public string trfsno { get; set; }
        /// <summary>
        /// 箱号
        /// </summary>
        public string ctnrno { get; set; }
        /// <summary>
        /// 码头单号类型（0=提单号，1=订舱号）
        /// </summary>
        public string terminalnotype { get; set; }
        /// <summary>
        /// 订舱箱量
        /// </summary>
        public string bkgvolumn { get; set; }
        /// <summary>
        /// 装货港
        /// </summary>
        public string pol { get; set; }
        /// <summary>
        /// 装货港代码
        /// </summary>
        public string polcd { get; set; }
        /// <summary>
        /// 目的港
        /// </summary>
        public string dtp { get; set; }
        /// <summary>
        /// 目的港代码
        /// </summary>
        public string dtpcd { get; set; }
        /// <summary>
        /// 提箱/空时间
        /// </summary>
        public string stsptime { get; set; }
        /// <summary>
        /// 提箱/空地点
        /// </summary>
        public string stspplace { get; set; }
        /// <summary>
        /// 返场时间(外/拖装)
        /// </summary>
        public string fcgitime { get; set; }
        /// <summary>
        /// 入货时间(内/场装)
        /// </summary>
        public string cggitime { get; set; }
        /// <summary>
        /// 封箱时间(内/场装)
        /// </summary>
        public string cloadtime { get; set; }
        /// <summary>
        /// 集港时间
        /// </summary>
        public string cytctime { get; set; }
        /// <summary>
        /// 集港地点
        /// </summary>
        public string cytcplace { get; set; }
        /// <summary>
        /// 进场时间
        /// </summary>
        public string gitmtime { get; set; }
        /// <summary>
        /// 进场地点
        /// </summary>
        public string gitmplace { get; set; }
        /// <summary>
        /// 放行时间
        /// </summary>
        public string passtime { get; set; }
        /// <summary>
        /// 放行地点
        /// </summary>
        public string passplace { get; set; }
        /// <summary>
        /// 海关是否放行（Y=放行；N=未放行；C=退关
        /// </summary>
        public string ispass { get; set; }
        /// <summary>
        /// 是否配载（Y=已配载；N=未配载；)
        /// </summary>
        public string ispreload { get; set; }
        /// <summary>
        /// 装船时间
        /// </summary>
        public string lobdtime { get; set; }
        /// <summary>
        /// 装船地点
        /// </summary>
        public string lobdplace { get; set; }
        /// <summary>
        /// 离港时间
        /// </summary>
        public string dlpttime { get; set; }
        /// <summary>
        /// 离港地点
        /// </summary>
        public string dlptplace { get; set; }
        /// <summary>
        /// 预计离港时间
        /// </summary>
        public string etdpol { get; set; }
        /// <summary>
        /// 中转时间
        /// </summary>
        public string trsptime { get; set; }
        /// <summary>
        /// 中转地点
        /// </summary>
        public string trspplace { get; set; }
        /// <summary>
        /// 预计卸船时间
        /// </summary>
        public string etapld { get; set; }
        /// <summary>
        /// 卸船时间
        /// </summary>
        public string dschtime { get; set; }
        /// <summary>
        /// 卸船地点
        /// </summary>
        public string dschplace { get; set; }
        /// <summary>
        /// 卸船码头
        /// </summary>
        public string terminalpld { get; set; }
        /// <summary>
        /// 提柜时间
        /// </summary>
        public string stcstime { get; set; }
        /// <summary>
        /// 提柜地点
        /// </summary>
        public string stcsplace { get; set; }
        /// <summary>
        /// 还空时间
        /// </summary>
        public string rcvetime { get; set; }
        /// <summary>
        /// 还空地点
        /// </summary>
        public string rcveplace { get; set; }
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
        /// 场站代码
        /// </summary>
        public string depotcd { get; set; }
        /// <summary>
        /// 场站
        /// </summary>
        public string depot { get; set; }
        /// <summary>
        /// 堆场场/拖装标识(I=场装；E=拖装)
        /// </summary>
        public string dptloadid { get; set; }
        /// <summary>
        /// 码头代码
        /// </summary>
        public string terminalcd { get; set; }
        /// <summary>
        /// 码头
        /// </summary>
        public string terminal { get; set; }
        /// <summary>
        /// 船名
        /// </summary>
        public string vslname { get; set; }
        /// <summary>
        /// 航次
        /// </summary>
        public string voy { get; set; }
        /// <summary>
        /// 所属船东代码
        /// </summary>
        public string carriercd { get; set; }
        /// <summary>
        /// 所属船东
        /// </summary>
        public string carrier { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public string updatetime { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string createtime { get; set; }
        /// <summary>
        /// 报关单号
        /// </summary>
        public string declarationno { get; set; }
        /// <summary>
        /// 线性状态从表
        /// </summary>
        public List<LinerTrackingStatus> lstlinertrackingstatus { get; set; }
        /// <summary>
        /// 订阅号
        /// </summary>
        public string referenceno { get; set; }
        /// <summary>
        /// 是否是箱号订阅（0=否;1=是）
        /// </summary>
        public string isctnr { get; set; }

    }

    /// <summary>
    /// 订阅状态从表
    /// </summary>
    public class LinerTrackingStatus
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string keyid { get; set; }
        /// <summary>
        /// 海运线性记录表主键
        /// </summary>
        public string fkeyid { get; set; }
        /// <summary>
        /// 提单号
        /// </summary>
        public string blno { get; set; }
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
        /// 状态地点_中文
        /// </summary>
        public string statusplace_cn { get; set; }
        /// <summary>
        /// 船名
        /// </summary>
        public string vslname { get; set; }
        /// <summary>
        /// 航次
        /// </summary>
        public string voy { get; set; }
        /// <summary>
        /// 是否预计时间（Y=是，N=否）
        /// </summary>
        public string isest { get; set; }
        /// <summary>
        /// 无效标识（Y=已退载或甩柜）
        /// </summary>
        public string cancelid { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public string updatetime { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string createtime { get; set; }
    }

    /// <summary>
    /// 批量上传API返回结果
    /// </summary>
    public class UploadResponse
    {
        public bool success { get; set; }

        public int number { get; set; }

        public List<BkResultModule> result { get; set; }
    }

    /// <summary>
    /// 批量上传API具体单号订阅状态
    /// </summary>
    public class BkResultModule
    {
        /// <summary>
        /// 本地关键字
        /// </summary>
        public string localkeyid { get; set; }
        /// <summary>
        /// 订阅号
        /// </summary>
        public string referenceno { get; set; }
        /// <summary>
        /// 箱号
        /// </summary>
        public string ctnrno { get; set; }
        /// <summary>
        /// 船东
        /// </summary>
        public string carriercd { get; set; }
        /// <summary>
        /// 是否是箱号订阅（0=否;1=是）
        /// </summary>
        public string isctnr { get; set; }
        /// <summary>
        /// 是否成功订阅
        /// </summary>
        public bool success { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string message { get; set; }
    }
    #endregion
    /// <summary>
    /// 海运跟踪API
    /// </summary>
    public class Shipping : IService<Shipping.BookingResult, Shipping.Filter>, IService<Shipping.Filter>
    {
        #region 对象模型
        /// <summary>
        /// 单票API返回对象
        /// </summary>
        public class BookingResult : ApiResponse
        {
            private LinerTracking _objlinertracking;

            public LinerTracking objlinertracking
            {
                get
                {
                    if (_objlinertracking == null)
                    {
                        _objlinertracking = new LinerTracking();

                    }
                    return _objlinertracking;
                }
                set
                {
                    _objlinertracking = value;
                }
            }
        }

        /// <summary>
        /// 海运跟踪之上传参数
        /// </summary>
        public class Filter : ShippingFilter
        {

        }
        #endregion



        /// <summary>
        /// 海运订阅之批量上传订阅
        /// </summary>
        /// <param name="filterLst">订阅单号对象数组</param>
        /// <returns></returns>
        private UploadResponse BookingUploadList(List<Filter> filterLst)
        {
            string url = "http://apis.yundangnet.com/api/v1/bookingsv2";
            Dictionary<string, string> queryData = new Dictionary<string, string>();
            Dictionary<string, string> formData = new Dictionary<string, string>();
            queryData.Add("companyid", CompanyId);

            string formString1 = JsonConvert.SerializeObject(filterLst);
            formData.Add("data", formString1);

            HttpUtil.HashRequest(queryData, formData, Secret, true);
            var json = HttpUtil.HttpPost(url, queryData, formData);
            var results = JsonConvert.DeserializeObject<UploadResponse>(json);
            return results;
        }

        private ApiResponse<TResult> BookingUploadList<TResult>(List<Filter> filterLst)
        {
            string url = "http://apis.yundangnet.com/api/v1/bookingsv2";
            Dictionary<string, string> queryData = new Dictionary<string, string>();
            Dictionary<string, string> formData = new Dictionary<string, string>();
            queryData.Add("companyid", CompanyId);

            string formString1 = JsonConvert.SerializeObject(filterLst);
            formData.Add("data", formString1);

            HttpUtil.HashRequest(queryData, formData, Secret, true);
            var json = HttpUtil.HttpPost(url, queryData, formData);
            var results = JsonConvert.DeserializeObject<List<TResult>>(json);
            var apiResponse = new ApiResponse<TResult>
            {
                status = 0,
                message = "成功",
                results = results
            };
            return apiResponse;
        }

        /// <summary>
        /// 海运订阅之批量下载订阅数据
        /// </summary>
        /// <param name="filterLst">订阅提单号对象数组</param>
        /// <returns></returns>
        private List<BookingResult> BookingDownloadLst(List<Filter> filterLst)
        {
            string url = "http://apis.yundangnet.com/api/v1/bookingv2-liner";
            Dictionary<string, string> queryData = new Dictionary<string, string>();
            Dictionary<string, string> formData = new Dictionary<string, string>();
            queryData.Add("companyid", CompanyId);

            string formString1 = JsonConvert.SerializeObject(filterLst);
            formData.Add("data", formString1);

            HttpUtil.HashRequest(queryData, formData, Secret, true);
            var json = HttpUtil.HttpPost(url, queryData, formData);
            var results = JsonConvert.DeserializeObject<List<BookingResult>>(json);
            return results;
        }

        public string CompanyId { get; set; }

        public string Secret { get; set; }

        public void Remove(Shipping.Filter filter)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 单票查询并订阅
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public BookingResult Subscribe(Shipping.Filter filter)
        {
            string url = "http://apis.yundangnet.com/api/v1/seabooking-download";
            Dictionary<string, string> queryData = new Dictionary<string, string>();
            Dictionary<string, string> formData = new Dictionary<string, string>();
            queryData.Add("companyid", CompanyId);

            string formString1 = JsonConvert.SerializeObject(filter);
            formData.Add("data", formString1);

            HttpUtil.HashRequest(queryData, formData, Secret, true);
            var json = HttpUtil.HttpPost(url, queryData, formData);
            var results = JsonConvert.DeserializeObject<BookingResult>(json);
            return results;
        }

        public UploadResponse Subscribe(List<Shipping.Filter> filterList)
        {
            return BookingUploadList(filterList);
        }

        public BookingResult GetData(Shipping.Filter filter)
        {
            string url = "http://apis.yundangnet.com/api/v1/seabooking-download";
            Dictionary<string, string> queryData = new Dictionary<string, string>();
            Dictionary<string, string> formData = new Dictionary<string, string>();
            queryData.Add("companyid", CompanyId);

            string formString1 = JsonConvert.SerializeObject(filter);
            formData.Add("data", formString1);

            HttpUtil.HashRequest(queryData, formData, Secret, true);
            var json = HttpUtil.HttpPost(url, queryData, formData);
            var results = JsonConvert.DeserializeObject<BookingResult>(json);
            return results;
        }

        public List<BookingResult> GetData(List<Shipping.Filter> filterList)
        {
            return BookingDownloadLst(filterList);
        }
    }
}
