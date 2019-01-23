using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDN
{
    public class EnterpriseService
    {
        public EnterpriseService(string companyId, string secrect)
        {
            throw new System.NotImplementedException();
        }

        public Tracking.Flight Flight
        {
            get;
            private set;
        }
        public Tracking.Shipping Shipping
        {
            get;
            private set;
        }

        public Publisher Publisher
        {
            get;
            private set;
        }
    }
}
