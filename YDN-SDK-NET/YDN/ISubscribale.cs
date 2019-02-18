using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDN
{
    public interface ISubscribable<T>
    {
        void Remove(T filter);

        ApiResponse With(T filter);

        ApiResponse With(List<T> filterList);
    }
}
