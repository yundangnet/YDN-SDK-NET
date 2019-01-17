using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDN
{
    public class Publisher : IPublishable
    {
        public IQueryable<ISubscribable> Query()
        {
            throw new System.NotImplementedException();
        }
    }
}
