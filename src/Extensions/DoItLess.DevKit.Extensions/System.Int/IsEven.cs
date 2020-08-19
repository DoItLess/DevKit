namespace DoItLess.DevKit.Extensions
{
    public static partial class IntExtensions
    {
        /// <summary>
        ///     是否偶数
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// 0L.IsEven(); // true
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsEven(this long @this)
        {
            return @this % 2 == 0;
        }


        /// <summary>
        ///     是否偶数
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// 0.IsEven(); // true
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsEven(this int @this)
        {
            return @this.ToLong().IsEven();
        }
    }
}