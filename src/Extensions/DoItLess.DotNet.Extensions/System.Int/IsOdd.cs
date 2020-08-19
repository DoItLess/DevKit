namespace DoItLess.DotNet.Extensions
{
    public static partial class IntExtensions
    {
        /// <summary>
        ///     是否奇数
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// (-1L).IsOdd(); // true
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsOdd(this long @this)
        {
            return @this % 2 != 0;
        }


        /// <summary>
        ///     是否奇数
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// (-1).IsOdd(); // true
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsOdd(this int @this)
        {
            return @this.ToLong().IsOdd();
        }
    }
}