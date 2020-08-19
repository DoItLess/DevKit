using System;

namespace DoItLess.DevKit.Extensions
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        ///     获取时间戳的分钟表示
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var dt = new DateTime(2019, 4, 1, 11, 11, 11);
        /// dt.TotalMinutes(); // 25901951.183333334
        ///         ]]>
        ///     </code>
        /// </example>
        public static double TotalMinutes(this DateTime @this)
        {
            return (@this - OriginDateTime).TotalMinutes;
        }
    }
}