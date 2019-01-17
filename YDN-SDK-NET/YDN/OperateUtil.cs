using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDN
{
    public static class OperateUtil
    {
        public static ApiResponse Subscribe<T>(this IService service,T filter)
        {
            return service.With(filter);
        }

        public static ApiResponse Subscribe<T>(this IService service, List<T> filterList)
        {
            return service.With(filterList);
        }
    }
}
