using System;
using System.Text;

namespace DoItLess.DevKit.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        ///     BASE64 字符串编码
        ///     <para>默认使用 <see cref="Encoding.UTF8" /></para>
        /// </summary>
        /// <param name="this"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var str1   = "ABCD";
        /// str1.Base64Encode(); // "QUJDRA=="
        ///         ]]>
        ///     </code>
        /// </example>
        public static string Base64Encode(this string @this, Encoding encoding = null)
        {
            encoding ??= Encoding.UTF8;

            var bytes = encoding.GetBytes(@this);
            return Convert.ToBase64String(bytes);
        }
    }
}