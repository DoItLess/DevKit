// ReSharper disable InconsistentNaming

using System;
using System.Collections.Generic;

namespace DoItLess.DevKit.Extensions
{
    public static partial class IEnumerableExtensions
    {
        /// <summary>
        ///     返回序列中的非重复元素
        /// </summary>
        /// <param name="this"></param>
        /// <param name="selector">选择器，选择用于比较的对象</param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="this" /> is null</exception>
        /// <exception cref="ArgumentNullException"><paramref name="selector" /> is null</exception>
        public static IEnumerable<T> Distinct<T, TResult>(this IEnumerable<T> @this, Func<T, TResult> selector)
        {
            return @this.Distinct(selector, EqualityComparer<TResult>.Default);
        }

        /// <summary>
        ///     返回序列中的非重复元素
        /// </summary>
        /// <param name="this"></param>
        /// <param name="selector">选择器，选择用于比较的对象</param>
        /// <param name="equalityComparer">比较器</param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="this" /> is null</exception>
        /// <exception cref="ArgumentNullException"><paramref name="selector" /> is null</exception>
        /// <exception cref="ArgumentNullException"><paramref name="equalityComparer" /> is null</exception>
        public static IEnumerable<T> Distinct<T, TResult>(this IEnumerable<T> @this, Func<T, TResult> selector, IEqualityComparer<TResult> equalityComparer)
        {
            if (@this == null) throw new ArgumentNullException(nameof(@this), "is null");
            if (selector == null) throw new ArgumentNullException(nameof(selector), "is null");
            if (equalityComparer == null) throw new ArgumentNullException(nameof(equalityComparer), "is null");

            var rs = new HashSet<TResult>(equalityComparer);
            foreach (var element in @this)
            {
                var setValue = selector(element);
                if (rs.Contains(setValue)) continue;
                yield return element;
                rs.Add(setValue);
            }
        }
    }
}