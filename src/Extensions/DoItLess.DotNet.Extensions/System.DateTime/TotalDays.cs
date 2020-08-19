using System;

namespace DoItLess.DotNet.Extensions
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        ///     获取时间戳的日表示
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var dt = new DateTime(2019, 4, 1, 11, 11, 11);
        /// dt.TotalDays(); // 17987.466099537036
        ///         ]]>
        ///     </code>
        /// </example>
        public static double TotalDays(this DateTime @this)
        {
            return (@this - OriginDateTime).TotalDays;
        }
    }
}
