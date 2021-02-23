using System;

namespace EbayPlatform.Utility.Extensions
{
    /// <summary>
    /// 日期扩展类
    /// </summary>
    public static class DateTimeExtension
    {
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime GetUTCDateTime(this DateTime date)
        {
            return date <= DateTime.Now ? date.ToUniversalTime() : DateTime.Now.ToUniversalTime();
        }
    }
}
