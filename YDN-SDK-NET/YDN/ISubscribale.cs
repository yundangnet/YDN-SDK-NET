using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDN
{
    public interface ISubscribable
    {
        void Remove<T>(T filter);

        ApiResponse With<T>(T filter);

        ApiResponse With<T>(List<T> filterList);
    }
}
