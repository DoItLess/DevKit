using System;

namespace DoItLess.DevKit.Extensions
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        ///     是否 0 时 0 分 0 秒
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var dt = new DateTime(2019, 5, 4, 1, 1, 1);
        /// dt.IsZeroTime(); // false
        ///         ]]>
        ///     </code>
        /// </example>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var dt = new DateTime(2019, 5, 4);
        /// dt.IsZeroTime(); // true
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsZeroTime(this DateTime @this)
        {
            return @this.CompareTo(@this.Date) == 0;
        }
    }
}