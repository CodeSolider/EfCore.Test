using Newtonsoft.Json;

namespace EbayPlatform.Utility.Extensions
{
    /// <summary>
    /// Json 扩展类
    /// </summary>
    public static class JsonExtension
    {
        /// <summary>
        /// String->转实体类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val"></param>
        /// <returns></returns>
        public static T ToEntity<T>(this string val)
        {
            return JsonConvert.DeserializeObject<T>(val);
        }

        /// <summary>
        /// 实体类->转Json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="formatting"></param>
        /// <returns></returns>
        public static string ToJson<T>(this T entity, Formatting formatting = Formatting.None)
        {
            return JsonConvert.SerializeObject(entity, formatting);
        }
    }
}
