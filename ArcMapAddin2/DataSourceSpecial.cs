using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ArcMapAddin2
{
    public class DataSourceSpecial
    {
        public static DataTable CreateSource ();
            DataTable table = new DataTable();
            table.Columns.Add("ProductID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Clasification", typeof(int));
            DataRow row = table.NewRow();
            row["ProductID"] = 1;
            row["Name"] = "asdas1";
            row["Clasification"] = "nai1";
            table.Rows.Add(row)
            return table;
    }
}
