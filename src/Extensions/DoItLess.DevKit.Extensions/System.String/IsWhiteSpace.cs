using System.Linq;

namespace DoItLess.DevKit.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        ///     是否空白字符串
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// 
        /// "".IsWhiteSpace(); // true
        /// "".IsWhiteSpace(); // unicode: 00A0  true
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsWhiteSpace(this string @this)
        {
            return @this.All(char.IsWhiteSpace);
        }
    }
}