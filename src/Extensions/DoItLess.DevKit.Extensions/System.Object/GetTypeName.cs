using System;

namespace DoItLess.DevKit.Extensions
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        ///     获取当前对象类型名称
        /// </summary>
        /// <param name="this"></param>
        /// <returns>如果为空 返回 <see cref="string.Empty" /></returns>
        /// <exception cref="NullReferenceException"></exception>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var obj1 = new MyClass();
        /// obj1.GetTypeName(); // "MyClass"
        ///         ]]>
        ///     </code>
        /// </example>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var obj2 = "";
        /// obj2.GetTypeName(); // "String"
        ///         ]]>
        ///     </code>
        /// </example>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// object obj4 = null;
        /// obj4.GetTypeName(); // string.Empty
        ///         ]]>
        ///     </code>
        /// </example>
        public static string GetTypeName(this object @this)
        {
            return @this.GetTypeName(string.Empty);
        }

        /// <summary>
        ///     获取当前对象类型名称
        /// </summary>
        /// <param name="this"></param>
        /// <param name="defaultTypeName">默认类型名称</param>
        /// <returns>如果为空 返回 <paramref name="defaultTypeName" /></returns>
        public static string GetTypeName(this object @this, string defaultTypeName)
        {
            return @this == null ? defaultTypeName : @this.GetType().Name;
        }
    }
}