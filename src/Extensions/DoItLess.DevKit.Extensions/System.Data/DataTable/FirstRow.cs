using System.Data;

namespace DoItLess.DevKit.Extensions
{
    public static partial class DataTableExtensions
    {
        /// <summary>
        ///     获取首行
        ///     <para>当前DataTable没有行时，返回 <c>null</c></para>
        /// </summary>
        /// <param name="this"></param>
        /// <returns>当前DataTable没有行时，返回 <c>null</c></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// dataTable.FirstRow();
        ///         ]]>
        ///     </code>
        /// </example>
        public static DataRow FirstRow(this DataTable @this)
        {
            if (!@this.HasRows()) return null;
            return @this.Rows[0];
        }
    }
}