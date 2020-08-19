using System.Data;

namespace DoItLess.DevKit.Extensions
{
    public static partial class DataTableExtensions
    {
        /// <summary>
        ///     是否存在数据行
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// dataTable.HasRows();
        ///         ]]>
        ///     </code>
        /// </example>
        public static bool HasRows(this DataTable @this)
        {
            return @this.Rows.Count > 0;
        }
    }
}