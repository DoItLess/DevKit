using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DoItLess.DotNet.Extensions
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        ///     <para>深复制</para>
        ///     <remarks><paramref name="this" />为空时， 返回 <c>default&lt;T&gt;</c></remarks>
        /// </summary>
        /// <param name="this"></param>
        /// <exception cref="ArgumentException">目标类型 <typeparamref name="T"/> 需要支持序列化</exception>
        /// <exception cref="SerializationException"> <typeparamref name="T"/> 未标记为可序列化的</exception>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// [Serializable]
        /// private class MyClass
        /// {
        ///     public string Name { get; set; }
        /// }
        /// var obj = new MyClass{Name = "aa"};
        /// var rs = obj.DeepClone();
        /// // obj.Name == rs.Name
        /// // obj != rs
        ///         ]]>
        ///     </code>
        /// </example>
        public static T DeepClone<T>(this T @this) where T : class
        {
            if (!typeof(T).IsSerializable) throw new ArgumentException("目标类型需要支持序列化", nameof(@this));
            if (ReferenceEquals(@this, null)) return null;

            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, @this);
                stream.Seek(0, SeekOrigin.Begin);
                return (T) formatter.Deserialize(stream);
            }
        }
    }
}