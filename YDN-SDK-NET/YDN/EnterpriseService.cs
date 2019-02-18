using YDN.Tracking;

namespace YDN
{
    public class EnterpriseService
    {
        #region 初始化

        private static readonly object Locker = new object();
        private static EnterpriseService _enterpriseService;

        /// <summary>
        /// 获取唯一实例
        /// </summary>
        /// <returns></returns>
        public static EnterpriseService GetInstance(string companyId, string secrect)
        {
            if (_enterpriseService == null)
            {
                lock (Locker)
                {
                    if (_enterpriseService == null)
                    {
                        _enterpriseService = new EnterpriseService(companyId, secrect);
                    }
                }
            }
            return _enterpriseService;
        }
        public string CompanyId { get; set; }

        public string Secret { get; set; }

        private EnterpriseService(string companyId, string secrect)
        {
            CompanyId = companyId;
            Secret = secrect;
        }

        #endregion

        public Flight Flight()
        {
            var flight = new Flight
            {
                CompanyId = CompanyId,
                Secret = Secret
            };
            return flight;
        }

        /// <summary>
        /// 海运跟踪
        /// </summary>
        /// <returns></returns>
        public Shipping Shipping()
        {
            var shipping = new Shipping
            {
                CompanyId = CompanyId,
                Secret = Secret
            };
            return shipping;
        }
    }
}
