using System.Collections.Generic;
using YDN.Tracking;

namespace YDN
{
    public interface ISubscribable<TFilter>
    {
        void Remove(TFilter filter);

        ApiResponse With(TFilter filter);

        ApiResponse With(List<TFilter> filterList);
    }
    public interface ISubscribable<TResult, TFilter>
    {
        ApiResponse<TResult> WithResult(TFilter filter);

        ApiResponse<TResult> WithResult(List<TFilter> filterList);
    }
}
