namespace DoItLess.DotNet.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        ///     是否 null 或 string.Empty
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// " ".IsNullOrEmpty(); // false
        /// "".IsNullOrEmpty();  // true
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsNullOrEmpty(this string @this)
        {
            return string.IsNullOrEmpty(@this);
        }
    }
}
