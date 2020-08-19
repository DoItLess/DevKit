using System;

namespace DoItLess.DevKit.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        ///     <para>忽略大小写比较</para>
        ///     <para>使用 <see cref="StringComparison.OrdinalIgnoreCase" /></para>
        /// </summary>
        /// <param name="this"></param>
        /// <param name="value">需要进行比较的字符串</param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// "aaa".IgnoreCaseEquals("AaA"); // true
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IgnoreCaseEquals(this string @this, string value)
        {
            return @this.Equals(value, StringComparison.OrdinalIgnoreCase);
        }
    }
}