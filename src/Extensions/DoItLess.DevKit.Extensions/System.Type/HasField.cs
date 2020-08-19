using System;
using System.Linq;
using System.Reflection;

namespace DoItLess.DevKit.Extensions
{
    public static partial class TypeExtensions
    {
        /// <summary>
        ///     是否包含字段名 <see cref="FieldInfo" />
        /// </summary>
        /// <param name="this"></param>
        /// <param name="fieldName">字段名，忽略大小写</param>
        /// <param name="bindingFlags">
        ///     默认 <see cref="BindingFlags.Instance" /> | <see cref="BindingFlags.Static" /> |
        ///     <see cref="BindingFlags.Public" />
        /// </param>
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
        public static bool HasField(this Type @this, string fieldName, BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public)
        {
            return @this.GetFields(bindingFlags).Any(w => w.Name.IgnoreCaseEquals(fieldName));
        }
    }
}