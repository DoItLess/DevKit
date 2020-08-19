namespace DoItLess.DotNet.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        ///     是否null或空白
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// "   ".IsNullOrWhiteSpace(); // true
        /// "\r".IsNullOrWhiteSpace();  // true
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsNullOrWhiteSpace(this string @this)
        {
            return string.IsNullOrWhiteSpace(@this);
        }
    }
}
