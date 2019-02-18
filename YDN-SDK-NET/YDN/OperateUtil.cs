using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDN
{
    public static class OperateUtil
    {
        /// <summary>
        /// 上传订阅
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="service"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static ApiResponse Subscribe<T>(this IService<T> service, T filter)
        {
            return service.With(filter);
        }

        public static ApiResponse Subscribe<T>(this IService<T> service, List<T> filterList)
        {
            return service.With(filterList);
        }

        public static ApiResponse GetData<T>(this IService<T> service, T filter)
        {
            return service.With(filter);
        }
    }
}
