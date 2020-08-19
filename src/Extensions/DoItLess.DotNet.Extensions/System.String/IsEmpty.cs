namespace DoItLess.DotNet.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        ///     是否空字符串
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var a = "";
        /// var b = " ";
        ///
        /// a.IsEmpty(); // true
        /// b.IsEmpty(); // false
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsEmpty(this string @this)
        {
            return @this.Equals(string.Empty);
        }
    }
}
