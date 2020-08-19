// ReSharper disable InconsistentNaming

using System.Collections.Generic;
using System.Linq;

namespace DoItLess.DotNet.Extensions
{
    public static partial class IEnumerableExtensions
    {
        /// <summary>
        ///     是否空或空集合
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T">集合中元素的类型</typeparam>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var arr = new[] {"aa", "bb"};
        /// var rs = arr.IsNullOrEmpty(); // false
        ///
        /// var arr2 = new string[] { };
        /// var rs2 = arr.IsNullOrEmpty(); // true
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            return @this == null || !@this.Any();
        }
    }
}