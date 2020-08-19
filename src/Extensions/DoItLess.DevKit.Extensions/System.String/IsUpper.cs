using System.Linq;

namespace DoItLess.DevKit.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        ///     是否全部大写
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// "ABC".IsUpper(); // true
        /// "ABd".IsUpper(); // false
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsUpper(this string @this)
        {
            return @this.All(char.IsUpper);
        }
    }
}