// ReSharper disable InconsistentNaming

using System;
using System.Collections.Generic;
using System.Linq;

namespace DoItLess.DevKit.Extensions
{
    public static partial class IEnumerableExtensions
    {
        /// <summary>
        ///     <para>是否包含任一元素</para>
        ///     <para> <paramref name="this" /> 是否包含 <paramref name="items" /> 中任一元素 </para>
        /// </summary>
        /// <param name="this"></param>
        /// <param name="items">需要进行判断的元素集合</param>
        /// <typeparam name="T">集合中元素的类型</typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="this" /> is null </exception>
        /// <exception cref="ArgumentNullException"><paramref name="items" /> is null </exception>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var arr    = new[] {"aa", "bb"};
        /// var match  = new[] {"aa", "bb"};
        /// var match2 = new [] {"aa", "bb", "cc"};
        /// var rs = arr.ContainsAny(match); // true
        /// var rs2 = arr.ContainsAny(match2); // true
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool ContainsAny<T>(this IEnumerable<T> @this, IEnumerable<T> items)
        {
            if (@this == null) throw new ArgumentNullException(nameof(@this), $"{nameof(@this)} is null");
            if (items == null) throw new ArgumentNullException(nameof(items), $"{nameof(items)} is null");
            return items.Any(@this.Contains);
        }
    }
}