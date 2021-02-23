using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EbayPlatform.Utility.Extensions
{
    /// <summary>
    /// where if 扩展类
    /// </summary>
    public static class WhereIfExtension
    {
        //
        // 摘要:
        //     如果condition指定的条件成立便执行predicate子句。
        //
        // 参数:
        //   source:
        //
        //   predicate:
        //
        //   condition:
        //
        // 类型参数:
        //   T:
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> source, bool condition, Expression<Func<T, bool>> predicate)
        {
            if (condition)
            {
                source = source.Where(predicate);
            }
            return source;
        }

        //
        // 摘要:
        //     如果condition指定的条件成立便执行predicate子句。
        //
        // 参数:
        //   source:
        //
        //   predicate:
        //
        //   condition:
        //
        // 类型参数:
        //   T:
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source, bool condition, Func<T, bool> predicate)
        {
            if (condition)
            {
                source = source.Where(predicate);
            }
            return source;
        }
    }
}
