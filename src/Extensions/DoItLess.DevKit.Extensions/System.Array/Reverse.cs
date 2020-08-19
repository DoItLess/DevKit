using System;

namespace DoItLess.DevKit.Extensions
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        ///     反转数组中元素的顺序
        /// </summary>
        /// <param name="this"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RankException"></exception>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var s = new[] {"a", "A", "B", "b", "0"};
        /// s.Reverse(); // {"0", "b", "B", "A", "a"}
        ///         ]]>
        ///     </code>
        /// </example>
        public static void Reverse<T>(this T[] @this)
        {
            Array.Reverse(@this);
        }
    }
}