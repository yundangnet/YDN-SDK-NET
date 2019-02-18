using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDN
{
    public interface IService<T> : ISubscribable<T>, IPublishable<T>
    {

    }
}
