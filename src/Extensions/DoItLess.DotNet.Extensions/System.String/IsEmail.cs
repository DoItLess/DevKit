using System;
using System.Text.RegularExpressions;

namespace DoItLess.DotNet.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        ///     是否Email
        /// </summary>
        /// <param name="this"></param>
        /// <param name="regex">自定义正则表达式</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><permission cref="@this"></permission> 字符串为空 </exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="RegexMatchTimeoutException"></exception>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// "abc@qqq.com".IsEmail();  // true
        /// "abc@qqq#.com".IsEmail(); // false
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool IsEmail(this string @this, string regex = null)
        {
            regex ??= EmailRegexPatterns.Pattern1;
            if (@this == null) throw new ArgumentNullException(nameof(@this), "字符串为空");
            var match = Regex.Match(@this, regex);
            return match.Success;
        }

        public static class EmailRegexPatterns
        {
            /// <summary>
            /// 正则表达式1
            /// </summary>
            public const string Pattern1 = @"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
        }
        
    }
}