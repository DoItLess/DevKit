using System;

namespace DoItLess.DotNet.Extensions
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        ///     是否当天
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var dt = DateTime.Now;
        /// dt.IsToday(); // true
        /// var dt2 = new DateTime(2019,1,1);
        /// dt2.IsToday(); // false
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsToday(this DateTime @this)
        {
            return @this.Date == DateTime.Today;
        }
    }
}