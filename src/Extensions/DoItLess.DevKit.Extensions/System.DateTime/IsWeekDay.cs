using System;

namespace DoItLess.DevKit.Extensions
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        ///     是否工作日 (周一至周五)
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var dt = new DateTime(2019,5,4);
        /// dt.IsWeekDay();  // false
        /// var dt2 = new DateTime(2019,5,1);
        /// dt2.IsWeekDay(); // true
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsWeekDay(this DateTime @this)
        {
            return @this.DayOfWeek != DayOfWeek.Saturday && @this.DayOfWeek != DayOfWeek.Sunday;
        }
    }
}