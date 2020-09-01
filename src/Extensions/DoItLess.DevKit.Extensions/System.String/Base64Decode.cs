using System;
using System.Text;

namespace DoItLess.DevKit.Extensions
{
    /// <summary>
    ///     String 扩展方法
    /// </summary>
    public static partial class StringExtensions
    {
        /// <summary>
        ///     BASE64 字符串解码
        ///     <para>默认使用 <see cref="Encoding.UTF8" /></para>
        /// </summary>
        /// <param name="this"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var base64 = "QUJDRA==";
        /// base64.Base64Decode(); // "ABCD"
        ///         ]]>
        ///     </code>
        /// </example>
        public static string Base64Decode(this string @this, Encoding encoding = null)
        {
            encoding ??= Encoding.UTF8;

            var bytes = Convert.FromBase64String(@this);
            return encoding.GetString(bytes);
        }
    }
}