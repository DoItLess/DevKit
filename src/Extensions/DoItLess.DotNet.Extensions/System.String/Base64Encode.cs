using System;
using System.Text;

namespace DoItLess.DotNet.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        ///     进行 BASE64 编码
        /// </summary>
        /// <param name="this"></param>
        /// <param name="encoding">默认使用 <see cref="Encoding.UTF8" /></param>
        /// <returns>转换失败返回 <c>null</c></returns>
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