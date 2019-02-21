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

        public static ApiResponse Subscribe<TFilter>(this IService<TFilter> service, List<TFilter> filterList)
        {
            return service.With(filterList);
        }

        public static ApiResponse<TResult> GetData<TResult, TFilter>(this IService<TResult, TFilter> service, TFilter filter)
        {
            return service.WithResult(filter);
        }

        public static ApiResponse<TResult> GetData<TResult, TFilter>(this IService<TResult, TFilter> service, List<TFilter> filterList)
        {
            return service.WithResult(filterList);
        }
    }
}
