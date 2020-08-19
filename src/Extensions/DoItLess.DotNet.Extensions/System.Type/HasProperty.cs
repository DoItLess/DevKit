using System;
using System.Linq;
using System.Reflection;

namespace DoItLess.DotNet.Extensions
{
    public static partial class TypeExtensions
    {
        /// <summary>
        ///     是否包含属性 <see cref="PropertyInfo" />
        /// </summary>
        /// <param name="this"></param>
        /// <param name="propertyName">属性名，忽略大小写</param>
        /// <param name="bindingFlags">默认 <see cref="BindingFlags.Instance"/> | <see cref="BindingFlags.Static"/> | <see cref="BindingFlags.Public"/></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var rs = typeof(DataTable).HasProperty("Rows"); // true
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool HasProperty(this Type @this, string propertyName, BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public)
        {
            return @this.GetProperties(bindingFlags).Any(w => w.Name.IgnoreCaseEquals(propertyName));
        }
    }
}