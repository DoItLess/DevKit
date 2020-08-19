namespace DoItLess.DevKit.Extensions
{
    public static partial class IntExtensions
    {
        /// <summary>
        ///     是否在指定范围内
        /// </summary>
        /// <param name="this"></param>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// (-1L).IsInRange(0, 10); // false
        /// 10L.IsInRange(0, 10);   // true
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsInRange(this long @this, long min, long max)
        {
            return min <= @this && @this <= max;
        }


        /// <summary>
        ///     是否在指定范围内
        /// </summary>
        /// <param name="this"></param>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// (-1).IsInRange(0, 10); // false
        /// 10.IsInRange(0, 10);   // true
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsInRange(this int @this, int min, int max)
        {
            return min <= @this && @this <= max;
        }
    }
}