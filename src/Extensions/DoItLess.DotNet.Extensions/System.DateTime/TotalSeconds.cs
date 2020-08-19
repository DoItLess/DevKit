using System;

namespace DoItLess.DotNet.Extensions
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        ///     获取时间戳的秒表示
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var dt = new DateTime(2019, 4, 1, 11, 11, 11);
        /// dt.TotalSeconds(); // 1554117071
        ///         ]]>
        ///     </code>
        /// </example>
        public static double TotalSeconds(this DateTime @this)
        {
            return (@this - OriginDateTime).TotalSeconds;
        }
    }
}