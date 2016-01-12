using System;
using System.Data;
using System.IO;
using System.Linq;

namespace Kupci
{
    class DataTable_ExportImport
    {
        /// <summary>
        /// Export DataTable Columns , Rows to file
        /// </summary>
        /// <param name="datatable">The datatable to exported from.</param>
        /// <param name="delimited">string for delimited exported row items</param>
        /// <param name="exportcolumnsheader">Including columns header with exporting</param>
        /// <param name="file">The file path to export to.</param>
        public void ExportDataTabletoFile(DataTable datatable, string delimited, bool exportcolumnsheader, string file)
        {
            StreamWriter strFile = new StreamWriter(file, false, System.Text.Encoding.Default);
            if (exportcolumnsheader)
            {
                string Columns = string.Empty;
                foreach (DataColumn column in datatable.Columns)
                {
                    Columns += column.ColumnName + delimited;
                }
                strFile.WriteLine(Columns.Remove(Columns.Length - 1, 1));
            }
            
                foreach (DataRow datarow in datatable.Rows)
                {

                    string row = string.Empty;
                    foreach (object items in datarow.ItemArray)
                    {
                        
                        row += items.ToString() + delimited;
                    }
                    strFile.WriteLine(row.Remove(row.Length - 1, 1));

                }
           
            strFile.Flush();
            strFile.Close();
        }

        /// <summary>
        /// Import file with delimited rows, columns to datatable 
        /// </summary>
        /// <param name="file">The file path to imported from.</param>
        /// <param name="delimited">string for delimited imported row items</param>
        /// <param name="exportcolumnsheader">Including columns header with importing , (if true, the first row will be added as DataColumns) , (if false, DataColumns will be numbers)</param>
        /// <param name="datatable">The datatable to imported to.</param>
        public void ImportDataTableFromFile(string file, string delimited, bool importcolumnsheader, DataTable datatable)
        {
            StreamReader strFile = new StreamReader(file, System.Text.Encoding.Default);

            if (importcolumnsheader)
            {
                string[] ColumnsArray = strFile.ReadLine().Split(delimited.ToCharArray());
                foreach (string strCol in ColumnsArray)
                {
                    datatable.Columns.Add(strCol);
                }
            }
            else
            {
                int ColumnsCount = strFile.ReadLine().Split(delimited.ToCharArray()).Length;
                for (int iCol = 1; iCol <= ColumnsCount; iCol++)
                {
                    datatable.Columns.Add(iCol.ToString());
                }

                strFile = new StreamReader(file, System.Text.Encoding.Default);
            }

            while (strFile.Peek() > 0)
            {
                datatable.Rows.Add(strFile.ReadLine().Split(delimited.ToCharArray()));
            }
            strFile.Close();
        }

        public System.Boolean IsNumeric(System.Object Expression)
        {
            if (Expression == null || Expression is DateTime)
                return false;

            if (Expression is Int16 || Expression is Int32 || Expression is Int64 || Expression is Decimal || Expression is Single || Expression is Double || Expression is Boolean)
                return true;

            if (Expression is string)
                return false;

            //try
            //{
            //    if (Expression is string)
            //        Double.Parse(Expression as string);
            //    else
            //        Double.Parse(Expression.ToString());
            //    return true;
            //}
            //catch { } // just dismiss errors but return false

            return false;
        }


        //public bool IsNumeric(DataColumn col)
        //{
        //    if (col == null)
        //        return false;
        //    // Make this const
        //    var numericTypes = new[] { typeof(Byte), typeof(Decimal), typeof(Double),
        //                               typeof(Int16), typeof(Int32), typeof(Int64), typeof(SByte),
        //                               typeof(Single), typeof(UInt16), typeof(UInt32), typeof(UInt64)};
        //    return numericTypes.Contains(col.DataType);
        //}

        

    }
}
