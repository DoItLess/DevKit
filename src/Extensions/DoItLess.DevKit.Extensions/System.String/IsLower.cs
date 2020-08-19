using System.Linq;

namespace DoItLess.DevKit.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        ///     是否全部小写
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// "abcddd".IsLower(); // true;
        /// "abDD".IsLower();   // false
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsLower(this string @this)
        {
            return @this.All(char.IsLower);
        }
    }
}