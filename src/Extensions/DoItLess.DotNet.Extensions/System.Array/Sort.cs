using System;
using System.Collections;
using System.Collections.Generic;

namespace DoItLess.DotNet.Extensions
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        ///     排序
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T">数组的元素类型</typeparam>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var s = new[] {"a", "b", "c", "d"};
        /// s.Sort(); // {"a", "b", "c", "d"}
        ///         ]]>
        ///     </code>
        /// </example>
        public static void Sort<T>(this T[] @this)
        {
            @this.Sort(Comparer<T>.Default);
        }

        /// <summary>
        ///     排序
        /// </summary>
        /// <param name="this"></param>
        /// <param name="comparer">
        ///     <para>比较元素时使用的 IComparer&lt;T&gt; </para>
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var s = new[] {"aa", "AA", "A"};
        /// s.Sort(StringComparer.Ordinal); // {"A", "AA", "a"}
        ///         ]]>
        ///     </code>
        /// </example>
        public static void Sort(this Array @this, IComparer comparer)
        {
            Array.Sort(@this, comparer);
        }
    }
}